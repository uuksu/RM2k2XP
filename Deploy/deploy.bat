@ECHO OFF

IF NOT EXIST ..\RM2k2XP.Cli\bin\Release GOTO NOTCOMPILED
IF NOT EXIST ..\RM2k2XP.Gui\bin\Release GOTO NOTCOMPILED

IF NOT EXIST RM2k2XP MKDIR RM2k2XP

COPY ..\RM2k2XP.Gui\bin\Release\RM2k2XP.exe RM2k2XP
COPY ..\RM2k2XP.Gui\bin\Release\RM2k2XP.Converters.dll RM2k2XP
COPY ..\RM2k2XP.Gui\bin\Release\RM2k2XP.exe.config RM2k2XP
COPY ..\RM2k2XP.Cli\bin\Release\RM2k2XP-cli.exe RM2k2XP
COPY ..\RM2k2XP.Cli\bin\Release\RM2k2XP-cli.exe.config RM2k2XP
COPY ..\RM2k2XP.Cli\bin\Release\CommandLine.dll RM2k2XP

IF NOT EXIST release MKDIR release

7za a -tzip release\RM2k2XP.zip RM2k2XP

RMDIR /Q /S RM2k2XP

GOTO EXIT
   
:NOTCOMPILED
ECHO Solution needs to be compiled in Release mode for deploy.

:EXIT