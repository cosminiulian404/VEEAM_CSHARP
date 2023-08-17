# VEEAM_CSHARP
The applicable test task for the VEEAM interview.
In regards with the task at hand and my thougths about it, and what can be improved with it.

This is the command line I used to test the app: 
# dotnet run veeam1.csproj d:\newSource d:\targetFile d:\outputLogger.txt 1000";
As it can be seen, it uses miliseconds for the time to update and copy, it can be changed internally so that it uses minutes or hours.

Unfortunatly the logger is buggy and I need to spend more time in orde to improve it, move it to another class, and general code readability maintanance.

It was an excellent test, and really made me scour the microsoft documentation for the information i needed, and some sites i wouldn't find otherwise like https://www.dotnetperls.com/ .
