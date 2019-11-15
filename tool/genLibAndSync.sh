#!/usr/bin/env bash

set -o errexit

SHELL_FOLDER=$(cd "$(dirname "$0")";pwd)
pushd $SHELL_FOLDER

cd ../android
./genBridgeLibAndSync.sh

cd ../ios
./genBridgeLibAndSync.sh

popd

echo 'Done'
