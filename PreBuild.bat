REM @ECHO OFF
:: delims is a TAB followed by a space
if not defined InnerSpacePath FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B

if not defined InnerSpacePath FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKCU\Software\Microsoft\IntelliPoint\AppSpecific\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B

if not defined InnerSpacePath FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKCU\Software\Microsoft\IntelliType Pro\AppSpecific\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B

if not defined InnerSpacePath goto :error

if "%InnerSpacePath:~-15%" == "\InnerSpace.exe" set InnerSpacePath=%InnerSpacePath:~0,-15%

copy "%InnerSpacePath%\Lavish.InnerSpace.dll" "..\.."
copy "%InnerSpacePath%\Lavish.LavishVMRuntime.dll" "..\.."
copy "%InnerSpacePath%\Lavish.LavishNav.dll" "..\.."

exit /b 0

goto :eof

:error

ECHO "InnerSpace path is not known.  Set the InnerSpacePath environment variable."