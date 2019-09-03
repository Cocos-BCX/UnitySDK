using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;
#if UNITY_5_6_OR_NEWER
using UnityEditor.Build;
#endif
using UnityEditor.Callbacks;

[InitializeOnLoad]
public class ProjectFileHook
{
    [PostProcessBuildAttribute]
    public static void OnPostProcessBuild(BuildTarget target, string path)
    {
        if (BuildTarget.Android == target) {
            string buildGradle = path + "/" + Application.productName + "/build.gradle";
            fixBuildGradle(buildGradle);
        } else if (BuildTarget.iOS == target) {
            geniOSSDK(path);
        }
    }

    private static void fixBuildGradle(string path)
    {
        if (!System.IO.File.Exists(path))
        {
            Debug.Log("ERROR! build.gradle not exist:" + path);
            return;
        }

        // remove follow lines:
        // compile(name: 'bcx_sdk', ext:'aar')
        // compile(name: 'bcxbridge', ext:'aar')
        List<string> lines = new List<string>();
        foreach (string line in File.ReadAllLines(path))
        {
            if (line.Contains("compile(name: 'bcx_sdk', ext:'aar')")
                || line.Contains("compile(name: 'bcxbridge', ext:'aar')")
                || line.Contains("implementation(name: 'bcx_sdk', ext:'aar')")
                || line.Contains("implementation(name: 'bcxbridge', ext:'aar')")
                )
            {
                continue;
            }
            lines.Add(line);
        }
        File.WriteAllLines(path, lines.ToArray());
    }

    private static void geniOSSDK(string path)
    {
        extractTarGz(Utils.PathCombine(Application.dataPath, "BCX", "Editor", "iOS", "BCXUnitySDK.tar.gz"), path);

        string podfile = Utils.PathCombine(path, "Podfile");
        if (!System.IO.File.Exists(podfile))
        {
            string podfileContent =
             "platform :ios, '8.0'\r\n"
            +"target 'Unity-iPhone' do\r\n"
            +"    use_frameworks!\r\n"
            +"    pod 'CocosSDK', :path => './BCXUnitySDK/'\r\n"
            +"    target 'Unity-iPhone Tests' do\r\n"
            +"        inherit! :search_paths\r\n"
            +"    end\r\n"
            +"end\r\n";
            System.IO.File.WriteAllText(podfile, podfileContent);
        }
    }

    private static void extractTarGz(string gzfile, string dstPath)
    {
        if (Directory.Exists(dstPath))
        {
            Directory.Delete(dstPath, true);
        }
        Tar.ExtractTarGz(gzfile, dstPath);
    }

}


