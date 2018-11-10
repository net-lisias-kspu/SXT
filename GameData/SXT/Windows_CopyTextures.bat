rem
rem This file should be run on Windows, in the SXT directory
rem
rem Double-clicking on the file while in Windows Explorer should
rem be sufficient

@echo off
echo.
echo This batch file will copy the missing textures from the inaccessable
echo Squad/zDeprecated directory for the SXTLT80 part, also known as
echo the LV-T80 "Robin" Liquid Fuel Engine
echo.
echo.
pause

mkdir Squad
cd Squad
mkdir fuelTankT800_v1
copy ..\..\Squad\zDeprecated\Parts\FuelTank\fuelTankT800_v1\model000.dds fuelTankT800_v1
copy ..\..\Squad\zDeprecated\Parts\FuelTank\fuelTankT800_v1\model001.dds fuelTankT800_v1

mkdir fuelTankT400_v1
copy ..\..\Squad\zDeprecated\Parts\FuelTank\fuelTankT400_v1\model000.dds fuelTankT400_v1
rem copy ..\..\Squad\zDeprecated\Parts\FuelTank\fuelTankT400_v1\model001.dds fuelTankT400_v1

echo.
echo.
echo The files have been copied
echo.
pause
