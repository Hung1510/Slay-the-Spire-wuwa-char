using MegaCrit.Sts2.Core.Models.Relics;

namespace Shorekeeper.ShorekeeperCode.Relics;

// Starter relic. Deploys Elementary Stellarealm at the start of every combat.
// Extends the template-generated ShorekeeperRelic base, which already carries the
// [Pool(typeof(ShorekeeperRelicPool))] attribute and icon-path wiring.
//
// NOT YET CONFIRMED: the combat-start trigger override. ShorekeeperRelic's own file doesn't
// show one (it only wires icon paths), and the wiki's CustomRelicModel page doesn't document a
// trigger example either. Same fix as everything else flagged in API_STATUS.md: Ctrl+Click
// through CustomRelicModel in Rider, or decompile a real base-game starter relic
// (Ironclad's BurningBlood, referenced in Character/Shorekeeper.cs's current placeholder
// starting relic) to see the actual override signature.
public class ArchivistsLedger : ShorekeeperRelic
{
    public override RelicRarity Rarity => RelicRarity.Starter;

    // TODO verify against a decompiled base-game relic:
    // protected override async Task OnCombatStart(PlayerChoiceContext choiceContext, Creature owner)
    // {
    //     await PowerCmd.Apply<ElementaryStellarealmPower>(choiceContext, owner, 1, owner, this, false);
    // }
}
