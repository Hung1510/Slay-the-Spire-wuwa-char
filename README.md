# Wuthering Waves cast for Slay the Spire 2

Playable Wuthering Waves characters for STS2. Started with Shorekeeper, more planned. Each
character is its own STS2 character mod project under `characters/`, generated from the
official BaseLib character template.

## Status

- **Shorekeeper**: early dev, first real gameplay code written against the confirmed BaseLib
  API. See `docs/characters/Shorekeeper/DESIGN.md` for the kit spec and
  `characters/Shorekeeper/API_STATUS.md` for what's confirmed vs. still needs checking.
- Next character: not started.

`docs/ROADMAP.md` is the source of truth for what's actually done, treat this file as an
overview.

## Why

Same ambition as the Acheron (Honkai: Star Rail) mod on the STS2 workshop, Wuthering Waves cast
instead. Real signature mechanics per character, not reskinned vanilla cards, plus meta-
progression hooks so there's a reason to keep running them specifically.

## Requirements

- .NET SDK matching current STS2 MegaDot/Godot .NET version, check
  [BaseLib-StS2 releases](https://github.com/Alchyr/BaseLib-StS2/releases)
- Rider
- STS2 with [BaseLib](https://github.com/Alchyr/BaseLib-StS2) installed for local testing
- `dotnet new install Alchyr.Sts2.Templates`

## Adding a character

```powershell
cd characters
mkdir <CharacterName>
cd <CharacterName>
dotnet new alchyrsts2charmod --ModAuthor Hung1510
```

Then add `docs/characters/<CharacterName>/DESIGN.md` before writing code, same pattern as
Shorekeeper. Check `docs/ROADMAP.md` for the "extract shared pieces" step once a second
character is actually in progress, don't copy-paste Shorekeeper's power/status base classes
wholesale.

## Build and test locally

Per character, inside `characters/<CharacterName>/`:

1. Build.
2. The project's own build target copies the output into your STS2 `mods/` folder automatically
   (see `CopyToModsFolderOnBuild` in the `.csproj`).
3. Make sure BaseLib is in the same `mods/` folder and enabled.
4. Mods menu in STS2, enable both, restart.
5. Character shows up on character select.

## Publishing

Official uploader: [`megacrit/sts2-mod-uploader`](https://github.com/megacrit/sts2-mod-uploader).

```powershell
ModUploader.exe new -w <character>-workshop
# copy build into <character>-workshop/content/, fill in workshop.json, preview image under 1MB
ModUploader.exe upload -w <character>-workshop
```

## Layout

```
characters/
  Shorekeeper/             generated STS2 character mod project
    ShorekeeperCode/        actual C# source (Cards, Powers, Relics, Character, ...)
    API_STATUS.md            confirmed vs. unconfirmed BaseLib API notes
docs/
  ROADMAP.md                 project-wide build checklist
  characters/
    Shorekeeper/
      DESIGN.md               kit spec: mechanics, cards, relics, Qualia Archive
      BUILD.md                 local build/copy/test steps
      art/ART_NOTES.md         art direction, AI generation notes
.github/workflows/           CI build checks
```

## Credits

Wuthering Waves characters developed by Kuro Games. Fan project, not affiliated with Kuro Games
or Mega Crit. Card/portrait art AI-generated, see each character's `art/ART_NOTES.md`.
