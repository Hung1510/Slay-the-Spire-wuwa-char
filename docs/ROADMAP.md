# Roadmap

Project-wide roadmap. Per-character build checklists live at
`docs/characters/<Name>/ROADMAP.md` once a character has one, this file tracks the overall
project and Shorekeeper's status until that split is worth doing.

## Project structure

```
characters/
  Shorekeeper/          generated STS2 character mod project (dotnet new alchyrsts2charmod)
  <next character>/      same pattern, generated the same way
docs/
  ROADMAP.md             this file
  characters/
    Shorekeeper/
      DESIGN.md           kit spec
      BUILD.md             local build/test steps
      art/ART_NOTES.md     art direction
```

## Shorekeeper - Phase 0: Environment

- [x] Install .NET SDK, Rider
- [x] `dotnet new install Alchyr.Sts2.Templates`
- [x] Generate the project: `dotnet new alchyrsts2charmod --ModAuthor Hung1510`
- [ ] Confirm the generated placeholder character loads in-game before writing more content

## Shorekeeper - Phase 1: Core mechanic proof of concept

- [x] `CollapsedStrike` card written against confirmed `ShorekeeperCard` API
- [x] `Discernment` card written (playability gating still unconfirmed, see API_STATUS.md)
- [x] `ArchivistsLedger` starter relic written (trigger override still unconfirmed)
- [x] `CollapsedCorePower`, `ElementaryStellarealmPower`, `SophisticatedStellarealmPower` -
      `Type`/`StackType` confirmed, trigger/behavior methods still unconfirmed
- [x] Wired into `Character/Shorekeeper.cs` starting deck/relic (Defend still placeholder)
- [ ] Close the API gaps tracked in `characters/Shorekeeper/API_STATUS.md`
- [ ] First successful build + load in-game
- [ ] 5-10 cards wired end to end, enough to combat-test the loop feels good

## Shorekeeper - Phase 2: Full card pool

- [ ] Fill out Attack/Skill/Power pool to spec in `docs/characters/Shorekeeper/DESIGN.md`
- [ ] Hit the Rare-per-type shop minimums (2 Attack / 2 Skill / 1 Power)
- [ ] Token cards (Dim/Flare Star Butterfly) built and referenced
- [ ] Upgrade (+) versions for every card

## Shorekeeper - Phase 3: Relics

- [ ] Full relic set per DESIGN.md (Common/Uncommon/Rare/Boss/Shop)
- [ ] Balance pass against a few real runs

## Shorekeeper - Phase 4: Qualia Archive (meta-system)

- [ ] Persistent Qualia counter (SpireField / save hook)
- [ ] Qualia gain triggers wired via Harmony/BaseLib hooks
- [ ] Rest-site UI panel for spending Qualia on Archive Entries
- [ ] At least 4-6 Archive Entry upgrades implemented

## Shorekeeper - Phase 5: Art

- [ ] Reference sheet locking her design for consistent regen across the full card pool
- [ ] Card art, portrait, HUD icon, select-screen art
- [ ] Combat sprite + pose set or spritesheet animation
- [ ] Relic + status icons

## Shorekeeper - Phase 6: Localization & polish

- [ ] English complete
- [ ] Full playtest across multiple ascension levels
- [ ] Pre-flight checks clean

## Second character

- [ ] Pick who's next (Zhezhi, Jinhsi, Changli, etc.)
- [ ] Extract genuinely shared pieces (generic field/stance base power, generic
      spendable-resource base power, rest-site upgrade UI) into a small shared project
      referenced by both characters, instead of copy-pasting Shorekeeper's code
- [ ] Confirm Shorekeeper still builds/works unchanged after that extraction
- [ ] `mkdir characters/<Name>`, `cd` into it, `dotnet new alchyrsts2charmod --ModAuthor Hung1510`
- [ ] New `docs/characters/<Name>/DESIGN.md`, own card/relic/power set
- [ ] Own Steam Workshop listing, or bundled into this mod as a second selectable character -
      decide this once a second character is actually in scope

## Publishing (per character, or per release)

- [ ] Steam Workshop listing: description, screenshots, preview image (<1MB)
- [ ] Publish via `sts2-mod-uploader`
- [ ] Watch Workshop comments / GitHub issues for balance feedback
