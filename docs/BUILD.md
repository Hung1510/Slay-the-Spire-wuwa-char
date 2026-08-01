# Build & local test

This gets filled in with exact commands once `Shorekeeper/` is generated from the official
template — the template's own README/wiki is the source of truth for build output paths, since
they can shift between STS2 patches. Rough shape:

1. Build the project in Rider (or `dotnet build`).
2. Copy the build output (`.dll` + manifest `.json` + any `.pck`) into:
   - Windows: `Steam\steamapps\common\Slay the Spire 2\mods\Shorekeeper\`
3. Confirm BaseLib is present in the same `mods\` folder and enabled.
4. In STS2: Mods menu → enable Shorekeeper + BaseLib → restart.
5. Character select → Shorekeeper should be selectable.

## Suggested local script (PowerShell)

Adjust `$sts2Mods` to your actual install path once confirmed:

```powershell
$sts2Mods = "$env:ProgramFiles(x86)\Steam\steamapps\common\Slay the Spire 2\mods"
$buildOut = ".\Shorekeeper\bin\Debug\net8.0"  # confirm actual target framework/output dir

Copy-Item -Path "$buildOut\*" -Destination "$sts2Mods\Shorekeeper\" -Recurse -Force
Write-Host "Copied build to $sts2Mods\Shorekeeper"
```

Wire this up as a Rider "Run/Debug" post-build step once the project exists, so build → copy →
launch is a single action instead of a manual copy every iteration.
