#!/usr/bin/env bash

SHELL_FOLDER=$(cd "$(dirname "$0")";pwd)
pushd $SHELL_FOLDER

cp -r iOSSDK BCXUnitySDK

cd BCXUnitySDK
git clean -dxf
git checkout -f
rm -rf ./Example
rm -rf ./.git
cd ..
tar -czvf BCXUnitySDK.tar.gz BCXUnitySDK
rm -rf ./BCXUnitySDK

cp -v ./BCXUnitySDK.tar.gz ../unity/bcx/Assets/BCX/Editor/iOS/

popd

echo 'Done'

