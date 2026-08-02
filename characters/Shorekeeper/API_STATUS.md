# API verification status

Tracks what's confirmed against real generated code / BaseLib docs vs. what's still a
placeholder. Update this as things get confirmed. Last updated after the first real
`dotnet new alchyrsts2charmod` generation.

## Confirmed (from the actual generated project + BaseLib wiki)

- `ShorekeeperCard`, `ShorekeeperPower`, `ShorekeeperRelic` - the template's own generated base
  classes for this mod, in `ShorekeeperCode/Cards|Powers|Relics`. All new cards/powers/relics
  should extend these, not `CustomCardModel`/`CustomPowerModel`/`CustomRelicModel` directly -
  the base classes already carry the `[Pool]` attribute and image-path wiring.
- `CustomPowerModel` exists (I was wrong earlier saying BaseLib had no such class - it's real,
  just wasn't on the wiki subpage I'd checked). Confirmed required overrides: `Type` (PowerType:
  Buff/Debuff) and `StackType` (PowerStackType: Counter = stacks add up on reapply, Single =
  doesn't stack like Barricade).
- `CustomCardModel` base shape, constructor args, `CanonicalTags`/`CanonicalVars`,
  `OnPlay`/`OnUpgrade` overrides, `CommonActions.CardAttack(...)` for dealing damage.
- `CustomRelicModel` base shape, `Rarity` override.
- `PlaceholderCharacterModel` - character definition shape: `StartingDeck`, `StartingRelics`,
  `CardPool`/`RelicPool`/`PotionPool`, `ModelDb.Card<T>()`/`ModelDb.Relic<T>()`/
  `ModelDb.CardPool<T>()` etc.
- Namespace convention: `Shorekeeper.ShorekeeperCode.{Cards,Powers,Relics,Character,...}`, not
  the flat `Shorekeeper.Cards` I used before seeing the real generated project.

## Not yet confirmed - do not ship without checking

- **The behavior/trigger methods on `CustomPowerModel`** beyond `Type`/`StackType`. Nothing
  I've seen documents what a power actually *does* on a trigger (start of turn, on card played,
  etc.). Fastest way to close this: in Rider, Ctrl+Click (Go to Declaration) on
  `CustomPowerModel` to see its full decompiled member list, or do the same on a simple
  base-game power like `PoisonPower` for a concrete stacking-power example.
- **`PowerCmd.Apply<T>` / `PowerCmd.GetAmount<T>`** for a *custom* power specifically - the
  BaseLib docs only show this call shape for a base-game power (`StrengthPower`) via the
  temporary-power wrapper. Likely works the same for a custom power, not confirmed.
- **Playability conditions** (gating Discernment on Sophisticated Stellarealm). No-code
  character creator exposes this as a UI dropdown; the underlying `CardModel` override isn't
  confirmed.
- **Relic trigger overrides** (`onPickup`, `combatStart`, etc.) - neither the wiki's
  `CustomRelicModel` page nor the generated `ShorekeeperRelic.cs` show a trigger example.
  Decompile Ironclad's `BurningBlood` (currently referenced as the placeholder starting relic
  this replaced) for a concrete example.

## How to close these gaps (fastest path)

Now that the project is generated and BaseLib is a real NuGet reference, use Rider's built-in
decompiler instead of a separate tool:
1. Type `CustomPowerModel` anywhere in a `.cs` file, Ctrl+Click it.
2. Do the same for a concrete example power (`PoisonPower`, `StrengthPower`) and a concrete
   starter relic (`BurningBlood`).
3. Paste the decompiled bodies back and the placeholders in `Powers/` and the commented-out
   lines in `Cards/CollapsedStrike.cs` / `Cards/Discernment.cs` get filled in for real.
