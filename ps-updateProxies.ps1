Set-PSDebug -Trace 0

$namespace = "PentaWork.Xrm.Scheduler"
$proxySuffix = ".Proxies"
$fakeSuffix = ".Tests.Fake"

$sourceFolder = $PSScriptRoot + "\src\PentaWork.Xrm.Scheduler\"
$testFolder = $PSScriptRoot + "\tests\PentaWork.Xrm.Scheduler.Tests\"
$projectPath = $PSScriptRoot + "\src\PentaWork.Xrm.Scheduler\PentaWork.Xrm.Scheduler.csproj";
$testProjectPath = $PSScriptRoot + "\tests\PentaWork.Xrm.Scheduler.Tests\PentaWork.Xrm.Scheduler.Tests.csproj";

$proxyFolder = "Proxies"
$fakeFolder = "Fake"

function Update-ProjectFiles {
    param (
        $ProjectPath,
        $SourcePath,
        $TargetPath,
        $RootProjectPath,
        $TargetFolderName
    )

    Write-Host "Deleting old files ..."
    Remove-Item -path $TargetPath -Recurse -Force -Confirm:$false

    Write-Host "Copy new proxies ...";
    Copy-Item -Path $SourcePath -Destination $TargetPath -Recurse -Container
    
    Write-Host "Removing all old proxy classes from project file ..."    
    [xml]$xml = (Get-Content $ProjectPath)
    ($xml.Project.ItemGroup.Compile | where {![string]::IsNullOrEmpty($_.Include) -And $_.Include.StartsWith(($TargetFolderName + "\"))}) |
    Foreach-Object {
	    $_.ParentNode.RemoveChild($_)
    }

    Write-Host "Adding all new proxy classes to project file ..."
    Get-ChildItem -recurse $TargetPath -Filter *.cs |
    Foreach-Object {
	    $proxyClass = $xml.CreateElement("Compile")
	    $proxyClass.SetAttribute("Include", $_.FullName.Replace($RootProjectPath, $null))
	    $xml.Project.ItemGroup[1].AppendChild($proxyClass)
    }

    $xml.Save($ProjectPath)
}

Get-CrmConnection -InteractiveMode | Get-XrmProxies -ProxyNamespace ($namespace + $proxySuffix) -FakeNamespace ($namespace + $fakeSuffix) -OutputPath ($PSScriptRoot + "\output") -Clear
Update-ProjectFiles -ProjectPath $projectPath -SourcePath ($PSScriptRoot + "\output\CSharp") -TargetPath ($sourceFolder + $proxyFolder) -RootProjectPath $sourceFolder -TargetFolderName $proxyFolder
Update-ProjectFiles -ProjectPath $testProjectPath -SourcePath ($PSScriptRoot + "\output\Fake") -TargetPath ($testFolder + $fakeFolder) -RootProjectPath $testFolder -TargetFolderName $fakeFolder