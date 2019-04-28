#!/bin/bash

#
# This script needs to be run on Linux and OSX to copy
# the missing texture files.  Double-clicking on it
# should be sufficient

clear

echo -e "\n\nThis batch file will copy the missing textures from the inaccessable"
echo "Squad/zDeprecated directory "
echo -e "\n\n"
echo "Press return to continue"
read yn

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"
[ ! -d $DIR/Squad ] && mkdir $DIR/Squad
cd $DIR/Squad

mkdir fuelTankT800_v1
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankT800_v1/model000.dds fuelTankT800_v1
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankT800_v1/model001.dds fuelTankT800_v1

mkdir fuelTankT400_v1
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankT400_v1/model000.dds fuelTankT400_v1
#cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankT400_v1/model001.dds fuelTankT400_v1

mkdir fuelTankJumbo-64
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankJumbo-64/model000.dds fuelTankJumbo-64
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankJumbo-64/model001.dds fuelTankJumbo-64

mkdir Size3Decoupler
cp ../../Squad/zDeprecated/Parts/Structural/Size3Decoupler/decoupler_and_adaptor_cm.dds Size3Decoupler

mkdir fuelTankX200-32
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankX200-32/model000.dds fuelTankX200-32
cp ../../Squad/zDeprecated/Parts/FuelTank/fuelTankX200-32/model001.dds fuelTankX200-32



echo -e "/n/nThe files have been copied/n"
echo "Press return to continue"
read yn
