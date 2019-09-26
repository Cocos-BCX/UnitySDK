#!/usr/bin/env bash

SHELL_FOLDER=$(cd "$(dirname "$0")";pwd)
pushd $SHELL_FOLDER

cd ../android
./genBridgeLibAndSync.sh

cd ../ios
./genBridgeLibAndSync.sh

popd

echo 'Done'
