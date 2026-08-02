using System.Collections.Generic;
using System.Threading.Tasks;
using BaseLib.Utils;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using Shorekeeper.ShorekeeperCode.Powers;

namespace Shorekeeper.ShorekeeperCode.Cards;

// Basic starter Attack. Small hit, generates 1 Collapsed Core.
// Extends ShorekeeperCard (the template-generated base class), which already carries the
// [Pool(typeof(ShorekeeperCardPool))] attribute and the portrait-path wiring, so this class
// doesn't need to repeat either.
public class CollapsedStrike() : ShorekeeperCard(1, CardType.Attack, CardRarity.Basic, TargetType.AnyEnemy)
{
    protected override HashSet<CardTag> CanonicalTags => [CardTag.Strike];
    protected override IEnumerable<DynamicVar> CanonicalVars => [new DamageVar(6, ValueProp.Move)];

    protected override async Task OnPlay(PlayerChoiceContext choiceContext, CardPlay play)
    {
        await CommonActions.CardAttack(this, play.Target, vfx: "vfx/vfx_attack_slash")
            .Execute(choiceContext);

        // TODO (see API_STATUS.md): apply 1 stack of CollapsedCorePower to play.Source.
        // Exact call unconfirmed - PowerCmd.Apply<T> is the shape shown for base-game powers
        // in the BaseLib mechanics docs, but hasn't been confirmed for a custom PowerModel yet.
        // await PowerCmd.Apply<CollapsedCorePower>(choiceContext, play.Source, 1, play.Source, this, false);
    }

    protected override void OnUpgrade()
    {
        DynamicVars.Damage.UpgradeValueBy(3m);
    }
}
