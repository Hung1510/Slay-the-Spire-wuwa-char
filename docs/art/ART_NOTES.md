# Art direction

## Reference sheet first
Generate one clean, transparent-background, front-facing reference image of Shorekeeper before
touching any card art. Use it as an image-to-image / character-reference seed for every later
generation so she stays visually consistent across 85+ cards — regenerating from a fresh text
prompt each time is how you end up with 85 slightly-different Shorekeepers.

Key design elements to lock in the reference (from her Wuthering Waves design):
- Pale/silver-white long hair, cold blue/violet color accents
- Archivist/rectifier aesthetic — celestial, data-glyph, "beacon"-adjacent visual motifs
- Calm, analytical expression — she's observing outcomes, not reacting to them

## Asset checklist & specs (from the STS2 character tooling — same specs apply whether
you build cards by hand or via the no-code tool)

| Asset | Size | Transparency |
|---|---|---|
| Card art | 500×375 PNG/JPG | not needed |
| Relic icon | 256×256 PNG | supported |
| Status/mechanic icon | 256×256 PNG | supported |
| Character portrait | 256×256 PNG/JPG | not needed |
| HUD icon (optional) | 88×88 PNG | supported |
| Select screen art (optional) | 132×195 PNG/JPG | not needed |
| Combat sprite | 512×512 PNG | **required** |
| Pose images ×5 (idle/attack/cast/hit/dead) | 512×512 PNG | **required** |

Generate anything needing transparency on a flat, solid-color background and knock it out — don't
rely on downstream tooling to invent transparency from a JPG.

## Tools
- NovelAI / Illustrious-based SDXL checkpoints handle this anime/gacha-game art style well.
- If generating locally (fits your existing dev setup better than per-image paid credits), an
  Illustrious or NoobAI SDXL checkpoint + a fixed seed/character LoRA-free consistency workflow
  (img2img from the reference sheet) is the most reliable route for a large, consistent card pool.

## Attribution
Mark the Workshop listing with an AI-artwork disclosure line (mirrors the Acheron listing's own
"This mod uses AI-generated artwork" note) — good practice for STS2 Workshop listings generally.
