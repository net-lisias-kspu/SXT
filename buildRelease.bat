
copy SXTContinued.version GameData\SXT

set DEFHOMEDRIVE=d:
set DEFHOMEDIR=%DEFHOMEDRIVE%%HOMEPATH%
set HOMEDIR=
set HOMEDRIVE=%CD:~0,2%

set RELEASEDIR=d:\Users\jbb\release
set ZIP="c:\Program Files\7-zip\7z.exe"
echo Default homedir: %DEFHOMEDIR%

rem set /p HOMEDIR= "Enter Home directory, or <CR> for default: "

if "%HOMEDIR%" == "" (
set HOMEDIR=%DEFHOMEDIR%
)
echo %HOMEDIR%

SET _test=%HOMEDIR:~1,1%
if "%_test%" == ":" (
set HOMEDRIVE=%HOMEDIR:~0,2%
)

type SXTContinued.version
set /p VERSION= "Enter version: "

rmdir /s /q %HOMEDIR%\install\Gamedata\SXTContinued

mkdir %HOMEDIR%\install\Gamedata\SXTContinued

copy ..\MiniAVC.dll Gamedata\SXTContinued
copy README.md Gamedata\SXTContinued


set FILE="%RELEASEDIR%\SXTContinued-%VERSION%-beta.zip"
IF EXIST %FILE% del /F %FILE%
%ZIP% a -tzip %FILE% GameData DepreciatedParts
del GameData\SXT\SXTContinued.version
