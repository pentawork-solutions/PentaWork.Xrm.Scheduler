#tool nuget:?package=NuGet.CommandLine&version=5.9.1

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Build");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// VARIABLES
//////////////////////////////////////////////////////////////////////

var solution = $"./PentaWork.Xrm.Scheduler.sln";
var buildDir = $"./src/PentaWork.Xrm.Scheduler/bin/{configuration}";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() => {
        CleanDirectory(buildDir);
    });

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() => { 
        NuGetRestore(solution);
    });

Task("Build")
    .IsDependentOn("Restore")
    .Does(() => {
        MSBuild(solution, settings => settings.SetConfiguration(configuration));
    });

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);