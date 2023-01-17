Set-PSDebug -Trace 0

$solutionName = "PentaWorkScheduler"
$solutionFolder = $PSScriptRoot + "\solution\"

$conn = Get-CrmConnection -InteractiveMode
$solutionFile = Export-XrmSolution -Connection $conn -UniqueName $solutionName -ExportPath $env:temp -PublishAll
Remove-Item -Recurse -Force $solutionFolder
Expand-Archive $solutionFile -DestinationPath $solutionFolder