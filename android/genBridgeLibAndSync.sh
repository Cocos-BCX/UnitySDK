#!/usr/bin/env bash

SHELL_FOLDER=$(cd "$(dirname "$0")";pwd)
pushd $SHELL_FOLDER

echo ''
echo '>>> Generated BCX-Android-SDK'
echo ''

cd ./AndroidSdk/CocosBcxSdk/
./gradlew :bcx_sdk:assembleRelease
cp -v ./bcx_sdk/build/outputs/aar/bcx_sdk-release.aar ../../bcx/bcxbridge/deps/bcx_sdk.aar

cd ../../bcx
./gradlew :bcxbridge:assembleRelease
cp -v ./bcxbridge/build/outputs/aar/bcxbridge-release.aar ../../unity/bcx/Assets/BCX/Plugins/Android/bcxbridge.aar
cp -v ./bcxbridge/deps/bcx_sdk.aar ../../unity/bcx/Assets/BCX/Plugins/Android/bcx_sdk.aar

popd

echo ''
echo '>>> Generated BCX-Android-SDK Done'
echo ''
