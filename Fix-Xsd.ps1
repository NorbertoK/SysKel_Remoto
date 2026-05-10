# --- CONFIG ---
$Root = Split-Path -Parent $MyInvocation.MyCommand.Path   # carpeta del script
$CustomToolNamespace = "Administracion"

Write-Host "Carpeta raíz:" $Root -ForegroundColor Cyan

# 1) Arreglar todos los .csproj
$projFiles = Get-ChildItem -Path $Root -Recurse -Filter *.csproj
foreach ($proj in $projFiles) {
    Write-Host "`nProcesando:" $proj.FullName -ForegroundColor Yellow
    [xml]$xml = Get-Content $proj.FullName

    # Manejo de namespace MSBuild
    $nsmgr = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
    $ns = $xml.Project.NamespaceURI
    if (-not $ns) { $ns = "http://schemas.microsoft.com/developer/msbuild/2003" }
    $nsmgr.AddNamespace("msb", $ns)

    $changed = $false

    # Tomar cualquier Item (*.xsd) en cualquier ItemGroup, sea <None Include="..."> o <Content Include="...">
    $xsdNodes = $xml.SelectNodes("//msb:ItemGroup/*[contains(@Include,'.xsd')]", $nsmgr)
    foreach ($node in $xsdNodes) {
        # Forzar tipo None
        if ($node.LocalName -ne "None") {
            # Cambiar el nombre del nodo a None (MSBuild lo acepta)
            $newNode = $xml.CreateElement("None", $ns)
            foreach ($attr in $node.Attributes) { $null = $newNode.SetAttribute($attr.Name, $attr.Value) }
            foreach ($child in @($node.ChildNodes)) { $null = $newNode.AppendChild($child) }
            $null = $node.ParentNode.ReplaceChild($newNode, $node)
            $node = $newNode
            $changed = $true
        }

        # Asegurar <Generator>MSDataSetGenerator</Generator>
        $gen = $node.SelectSingleNode("msb:Generator", $nsmgr)
        if (-not $gen) {
            $gen = $xml.CreateElement("Generator", $ns)
            $null = $node.AppendChild($gen)
            $changed = $true
        }
        if ($gen.InnerText -ne "MSDataSetGenerator") {
            $gen.InnerText = "MSDataSetGenerator"
            $changed = $true
        }

        # Asegurar <CustomToolNamespace>Administracion</CustomToolNamespace>
        $ctn = $node.SelectSingleNode("msb:CustomToolNamespace", $nsmgr)
        if (-not $ctn) {
            $ctn = $xml.CreateElement("CustomToolNamespace", $ns)
            $null = $node.AppendChild($ctn)
            $changed = $true
        }
        if ($ctn.InnerText -ne $CustomToolNamespace) {
            $ctn.InnerText = $CustomToolNamespace
            $changed = $true
        }

        # Opcional pero útil para VS: marcar como diseñador
        $sub = $node.SelectSingleNode("msb:SubType", $nsmgr)
        if (-not $sub) {
            $sub = $xml.CreateElement("SubType", $ns)
            $sub.InnerText = "Designer"
            $null = $node.AppendChild($sub)
            $changed = $true
        }
    }

    if ($changed) {
        $xml.Save($proj.FullName)
        Write-Host "Guardado:" $proj.FullName -ForegroundColor Green
    } else {
        Write-Host "Sin cambios." -ForegroundColor DarkGray
    }
}

# 2) Limpiar basura del diseñador (.xsc/.xss) en toda la solución
$trash = Get-ChildItem -Path $Root -Recurse -Include *.xsc,*.xss -ErrorAction SilentlyContinue
if ($trash.Count -gt 0) {
    Write-Host "`nEliminando archivos .xsc/.xss ($($trash.Count))..." -ForegroundColor Yellow
    $trash | Remove-Item -Force
    Write-Host "Listo." -ForegroundColor Green
} else {
    Write-Host "`nNo se encontraron .xsc/.xss." -ForegroundColor DarkGray
}

Write-Host "`nHecho. Ahora abrí la solución en Visual Studio y corré 'Run Custom Tool' sobre los .xsd (ver pasos)." -ForegroundColor Cyan
