@echo off
setlocal enabledelayedexpansion

echo Reemplazando Encrypt=True por Encrypt=False en archivos de C:\SysKel...

for /R "C:\SysKel" %%f in (*.config *.settings *.cs *.vb *.xsd *.resx) do (
    echo Procesando %%f
    powershell -Command "(Get-Content -Raw '%%f') -replace 'Encrypt=True', 'Encrypt=False' | Set-Content '%%f'"
)

echo Listo.
pause
