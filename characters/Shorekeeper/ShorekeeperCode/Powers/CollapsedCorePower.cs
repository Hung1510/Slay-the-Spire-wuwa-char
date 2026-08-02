using MegaCrit.Sts2.Core.Entities.Powers;

namespace Shorekeeper.ShorekeeperCode.Powers;

// Collapsed Core: her spendable resource stack. Attacks generate it, Discernment/Prophecy spend it.
//
// CONFIRMED against the real generated ShorekeeperPower base class (which extends BaseLib's
// CustomPowerModel): Type and StackType are the two required overrides, and their meaning is
// documented directly on the base class. Counter = stacks add up when reapplied, which is
// exactly what Collapsed Core needs to do.
//
// NOT YET CONFIRMED: the actual trigger/behavior methods (what happens when this is applied,
// whether/how it displays a stack count, how a card reads the current amount). ShorekeeperPower
// itself only shows icon-path and Type/StackType wiring, nothing about turn/trigger hooks.
// Next step: in Rider, Ctrl+Click (Go to Declaration) on CustomPowerModel to see its full member
// list via decompilation, or do the same on a simple base-game power like PoisonPower for a
// concrete stacking-power example to copy the pattern from.
public class CollapsedCorePower : ShorekeeperPower
{
    public override PowerType Type => PowerType.Buff;
    public override PowerStackType StackType => PowerStackType.Counter;

    // TODO: trigger/behavior implementation once the above is confirmed.
}
