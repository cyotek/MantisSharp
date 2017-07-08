@ECHO OFF

SETLOCAL

CALL ..\..\..\build\set35vars.bat

%msbuild15exe% MantisSharp.sln /p:Configuration=Release /verbosity:minimal /nologo /m /t:Clean
%msbuild15exe% MantisSharp.sln /p:Configuration=Release /verbosity:minimal /nologo /m
CALL dualsigncmd src\bin\Release\net35\MantisSharp.dll
CALL dualsigncmd src\bin\Release\net40\MantisSharp.dll
CALL     signcmd src\bin\Release\net45\MantisSharp.dll
CALL     signcmd src\bin\Release\net46\MantisSharp.dll
rem CALL     signcmd src\bin\Release\net47\MantisSharp.dll

IF NOT EXIST nuget MKDIR nuget

%msbuild15exe% src\MantisSharp.csproj /p:Configuration=Release /verbosity:minimal /nologo /m /t:Pack /p:PackageOutputPath="%~dp0nuget"
rem /p:PackageVersion=0.0.2
rem /p:NuspecFile=MantisSharp.nuspec

ENDLOCAL
