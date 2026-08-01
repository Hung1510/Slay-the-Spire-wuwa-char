# Roadmap

## Phase 0 — Environment
- [ ] Install .NET SDK matching current STS2 MegaDot version
- [ ] Install Rider
- [ ] `dotnet new install Alchyr.Sts2.Templates`
- [ ] Subscribe to BaseLib on Workshop (or install manually) for local testing
- [ ] Generate the project: `dotnet new sts2-character` inside `Shorekeeper/`
      (confirm exact template short name via `dotnet new list` first)
- [ ] Confirm the generated project builds and a placeholder character loads in-game

## Phase 1 — Core mechanic proof of concept
- [ ] Beacon custom status: apply, passive effect, pulse trigger
- [ ] Prediction custom status: stack gain from Skills, spend from Attacks
- [ ] 5–10 cards wired to both, enough to combat-test the loop feels good
- [ ] Starter relic that deploys Beacon on pickup

## Phase 2 — Full card pool
- [ ] Fill out Attack/Skill/Power pool to spec in DESIGN.md
- [ ] Hit the Rare-per-type shop minimums (2 Attack / 2 Skill / 1 Power)
- [ ] Token cards (if any) built and referenced
- [ ] Upgrade (+) versions for every card — none left at "does nothing"

## Phase 3 — Relics
- [ ] Starter, Common, Uncommon, Rare relics per DESIGN.md
- [ ] Balance pass against a few real runs

## Phase 4 — Qualia Archive (meta-system)
- [ ] Persistent Qualia counter (SpireField / save hook)
- [ ] Qualia gain triggers wired via Harmony/BaseLib hooks
- [ ] Rest-site UI panel for spending Qualia on Archive Entries
- [ ] At least 4–6 Archive Entry upgrades implemented

## Phase 5 — Art
- [ ] Reference sheet (locks her design for consistent regen across 85+ cards)
- [ ] Card art × full pool (500×375, no transparency)
- [ ] Portrait, HUD icon, select-screen art
- [ ] Combat sprite + pose set OR spritesheet animation
- [ ] Relic + status icons

## Phase 6 — Localization
- [ ] English complete (baseline)
- [ ] Additional languages if pursuing full parity with the Acheron mod's 5-language pass

## Phase 7 — Polish & release
- [ ] Full playtest across multiple ascension levels
- [ ] Pre-flight checks clean (no dangling references, no missing starting relic)
- [ ] Steam Workshop listing: description, screenshots, preview image (<1MB)
- [ ] Publish via `sts2-mod-uploader`
- [ ] Post-release: watch Workshop comments/GitHub issues for balance feedback
