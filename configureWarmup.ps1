param ($websitename)

Add-PSSnapin WebAdministration -ErrorAction SilentlyContinue
Import-Module WebAdministration -ErrorAction SilentlyContinue

$ApplicationPreloadType = "PentaWork.Xrm.SchedulerService.SchedulerMaintenanceTask, PentaWork.Xrm.SchedulerService"
$ApplicationPreloadProvider = "PreWarmUp"
$WebSiteFullName = "IIS:\Sites\" + $websitename

Set-WebConfiguration -Filter '/system.applicationHost/serviceAutoStartProviders' -Value (@{name=$ApplicationPreloadProvider;type=$ApplicationPreloadType})
Set-ItemProperty $WebSiteFullName -Name applicationDefaults.serviceAutoStartEnabled -Value True
Set-ItemProperty $WebSiteFullName -Name applicationDefaults.serviceAutoStartProvider -Value $ApplicationPreloadProvider