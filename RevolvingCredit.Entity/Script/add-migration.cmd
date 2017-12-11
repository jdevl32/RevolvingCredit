@rem 

@echo off

set "name=%1"

@echo on

cd ..
dotnet ef migrations add "%name%" -v -o Migration -s ..\RevolvingCredit.WebAPI
