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

}


