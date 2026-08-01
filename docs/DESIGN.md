# Shorekeeper — Kit Design

## Fantasy

Shorekeeper is the Black Shores' archivist — cold, analytical, watching outcomes unfold before
they happen. She doesn't fight in the moment; she's already accounted for it. The kit should feel
like **setting up a prediction, then cashing it in for something disproportionate.**

That's the hook that makes people want to *keep* picking her, the same way Acheron's Blade
Drawing/Nihility loop gave that mod's players a reason to return: a signature verb, not a reskin.

## Core mechanics

### 1. Beacon (persistent field — her signature verb)
A custom status on **herself**, applied once early (starter relic or a cheap 0-cost starter card:
"Deploy Beacon"). While active:
- Passive Effect: allies take reduced damage / Shorekeeper gains Block at turn start (small,
  constant hum in the background).
- Several of her cards check `Beacon Active` as a condition for a bonus branch ("Otherwise" effect
  in the card creator's terms) — e.g. "Deal 8. If Beacon is active, deal 14 instead."
- A handful of Skills **pulse** the Beacon (trigger `after a card is played`, filtered to Beacon
  pulses) for a small AoE heal/shield — this is the "support" half of her identity.

### 2. Prediction (resource stack — the payoff engine)
A custom stack-scaled status, gained by playing Skills (her analytical half), spent by her
strongest Attacks and her Power/Ultimate-tier card for amplified effects. Mechanically: Skills
apply +1–2 Prediction to herself; her hardest-hitting cards have a scaling-damage effect keyed to
current Prediction stacks, then a `Change Own Stacks` effect to spend it down. This is her
equivalent of Acheron's crit/Nihility payoff — a number you visibly build and then detonate.

### 3. Prophecy (Ultimate-tier Power, Rare)
Her signature finisher: costs most/all energy (X-cost), damage scales with Prediction stacks
consumed, and also pulses the Beacon for a big heal. This is the card the whole kit points at —
same design role as Acheron's ultimate-style boss-damage cards.

## Card pool structure (target: 85+, matching Acheron's scope)

| Type | Rarity split (rough) | Count target |
|---|---|---|
| Attack | 2 Basic-tier / 10 Common / 8 Uncommon / **3+ Rare** | ~24 |
| Skill | 2 Basic-tier / 10 Common / 8 Uncommon / **3+ Rare** | ~24 |
| Power | 1 starter / 6 Common / 6 Uncommon / **2+ Rare** | ~16 |
| Token cards | (created by other effects, not in the pool count) | ~6–8 |
| Ancient (starting-deck only) | flavor cards, not shop/reward-eligible | 2–4 |

Remember the shop-crash rule: you need **≥2 Rare Attacks, ≥2 Rare Skills, ≥1 Rare Power** or the
compiler silently fills gaps with generic filler — budget those first, not last.

## Relics

- **Starter — "Archivist's Beacon"**: `onPickup` — deploy Beacon permanently for the run (this is
  how she gets her signature status without spending a card slot on it every combat).
- **Common — "Marginal Notes"**: `onCardPlay` (Skill filter) — small chance/guaranteed small
  Prediction gain.
- **Uncommon — "Recursion Ledger"**: `combatStart` — Beacon pulses once immediately.
- **Rare — "Closed Loop"**: `onDamageDealt` — if Prediction is at max, refund 1 energy (rewards
  perfect play, doesn't trivialize it).

## Qualia Archive — the meta-progression hook (your Eidolon-gacha equivalent)

This is the layer that made Acheron replayable beyond "it's a new character" — worth building
even though it's the most custom-code-heavy piece.

- Track a **Qualia** resource earned in small amounts from specific in-run triggers (first Beacon
  pulse each combat, killing a marked/Predicted enemy, etc.) — a `SpireField` on the player/save
  state, incremented via Harmony hook or BaseLib's model-driven config, not through the card editor.
- At rest sites (hook `onRest`, same trigger surface the card creator exposes for relics — you'll
  do this in code instead so it can open a custom UI), spend accumulated Qualia on one of a small
  pool of **permanent-for-this-run upgrades** ("Archive Entries") — e.g. Beacon pulses twice,
  Prediction cap +2, Prophecy cost –1. This is the "special upgrades mid-run" beat from the
  Acheron description, minus an actual gacha/RNG paywall — earned, not rolled, which reads better
  for a free fan mod than gambling mechanics would.
- This needs a custom Godot UI panel and a save-hook, which is exactly the kind of thing that
  isn't exposed by the no-code character creator — it's the reason Path B is worth the extra
  effort here.

## Open design questions to lock before building card #1

- Exact numbers (damage/block/energy costs) — needs a balance pass against vanilla STS2 characters'
  early/mid/late game power curve once you have a few in the game to compare against.
- Whether Prediction caps (e.g. max 5 stacks) or is uncapped with diminishing returns.
- Co-op behavior: does Beacon buff allies too, or is it self-only? (Target list includes
  `AllAllies` — worth deciding early since it changes several card designs.)
