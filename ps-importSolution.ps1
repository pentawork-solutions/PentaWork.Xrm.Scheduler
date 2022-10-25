Set-PSDebug -Trace 0

$solutionName = "PentaWorkScheduler"
$solutionFolder = $PSScriptRoot + "\solution"
$zipPath = $PSScriptRoot + "\output\" + $solutionName + ".zip"

if (Test-Path $zipPath) {
    Remove-Item -Force $zipPath
}

#Because the ZIP files created by Compress-Archive are not valid CRM solutions we have to use 7zip to create the files
Compress-7Zip -ArchiveFileName $zipPath -Path $solutionFolder -Format Zip

$conn = Get-CrmConnection -InteractiveMode | Set-XrmTimeout -Timeout 30
Import-XrmSolution -Connection $conn -SolutionFile $zipPath -Overwrite -PublishWorkflows -Force