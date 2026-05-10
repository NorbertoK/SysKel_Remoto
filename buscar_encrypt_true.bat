@echo off
echo Buscando ocurrencias de Encrypt=True en C:\SysKel...
findstr /S /I /N /C:"Encrypt=True" C:\SysKel\*.config C:\SysKel\*.settings C:\SysKel\*.cs C:\SysKel\*.vb C:\SysKel\*.xsd C:\SysKel\*.resx > C:\SysKel\encrypt_true_ocurrencias.log
echo Búsqueda finalizada. El resultado está en C:\SysKel\encrypt_true_ocurrencias.log
pause
