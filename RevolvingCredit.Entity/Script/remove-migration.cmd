@rem 

@echo off

@echo on

cd ..
dotnet ef migrations remove -v -s ..\RevolvingCredit.WebAPI
