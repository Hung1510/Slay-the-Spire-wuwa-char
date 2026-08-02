using System.Collections.Generic;
using System.Threading.Tasks;
using BaseLib.Utils;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using Shorekeeper.ShorekeeperCode.Powers;

namespace Shorekeeper.ShorekeeperCode.Cards;

// Signature Rare Attack. Intended to only be playable while Sophisticated Stellarealm is
// active, and to consume all Collapsed Cores for scaling damage.
//
// Two things still flagged unconfirmed in API_STATUS.md:
//   1. Reading/clearing the CollapsedCorePower stack count.
//   2. The playability-condition hook that would gate this card on Sophisticated Stellarealm
//      being active. The no-code character creator exposes this as a UI dropdown; the C#
//      override for it on CardModel isn't confirmed yet, so this card is NOT currently gated -
//      don't ship it as "signature/rare" without that restriction wired in.
public class Discernment() : ShorekeeperCard(2, CardType.Attack, CardRarity.Rare, TargetType.AnyEnemy)
{
    protected override HashSet<CardTag> CanonicalTags => [];
    protected override IEnumerable<DynamicVar> CanonicalVars => [new DamageVar(10, ValueProp.Move)];

    protected override async Task OnPlay(PlayerChoiceContext choiceContext, CardPlay play)
    {
        // TODO verify: read current CollapsedCorePower stack count on play.Source,
        // factor it into damage dealt, then clear the stacks to 0 after resolving.
        // int cores = PowerCmd.GetAmount<CollapsedCorePower>(play.Source);

        await CommonActions.CardAttack(this, play.Target, vfx: "vfx/vfx_attack_slash")
            .Execute(choiceContext);
    }

    protected override void OnUpgrade()
    {
        DynamicVars.Damage.UpgradeValueBy(4m);
    }
}
