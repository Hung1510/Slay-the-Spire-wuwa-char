using MegaCrit.Sts2.Core.Entities.Powers;

namespace Shorekeeper.ShorekeeperCode.Powers;

// Upgraded tier of her field. Doubles the Block/heal pulse of ElementaryStellarealmPower and
// unlocks Discernment. Applied in place of Elementary once the escalation condition fires.
public class SophisticatedStellarealmPower : ShorekeeperPower
{
    public override PowerType Type => PowerType.Buff;
    public override PowerStackType StackType => PowerStackType.Single;

    // TODO: doubled passive Block/heal pulse. Same unconfirmed-API note as the other two powers.
}
