$env:version_major = Get-Date -format yyyy
$env:version_minor = Get-Date -format MM
$env:version_build = Get-Date -format dd
$env:version_revision = ([math]::round([int](Get-Date -format hhmmssfff) * 65534 / 235959999,0))
$env:version =  "$env:version_major.$env:version_minor.$env:version_build.$env:version_revision"
$env:author =  [string]::Join(",",$(git log --format='%an' | sort -u))
Update-AppveyorBuild -Version $env:version

if ($env:APPVEYOR_REPO_BRANCH -ne "master"){
  $env:version = "$env:Version-$env:APPVEYOR_REPO_BRANCH"
}
