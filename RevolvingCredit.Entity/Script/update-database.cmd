@rem 

@echo off

@echo on

cd ..
dotnet ef database update -v -s ..\RevolvingCredit.WebAPI
