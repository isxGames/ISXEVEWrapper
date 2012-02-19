@echo off
:: delims is a TAB followed by a space
if not defined InnerSpacePath FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B
if not defined InnerSpacePath FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKCU\Software\Microsoft\IntelliPoint\AppSpecific\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B
if not defined InnerSpacePath FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKCU\Software\Microsoft\IntelliType Pro\AppSpecific\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B
if not defined InnerSpacePath goto :ERROR

if "%InnerSpacePath:~-15%" == "\InnerSpace.exe" set InnerSpacePath=%InnerSpacePath:~0,-15%

:NEXTFILE
	if "%~1"=="" goto :EOF
	echo * Copy %1 to "%InnerSpacePath%\.NET Programs"
	copy /Y "%~1" "%InnerSpacePath%\.NET Programs" >NUL
	shift
	goto :NEXTFILE

:ERROR
	ECHO "InnerSpace path is not known.  Set the InnerSpacePath environment variable."
	exit 1

:EOF