using MegaCrit.Sts2.Core.Entities.Powers;

namespace Shorekeeper.ShorekeeperCode.Powers;

// Her persistent field, base tier. Applied by the starter relic (ArchivistsLedger) at combat
// start. Escalates to SophisticatedStellarealmPower after enough Skills are played while active
// (see DESIGN.md) - that escalation trigger is one of the unconfirmed pieces, same as
// CollapsedCorePower. Single stack type matches the design intent: this doesn't stack in
// quantity, it upgrades in place to a different power entirely.
public class ElementaryStellarealmPower : ShorekeeperPower
{
    public override PowerType Type => PowerType.Buff;
    public override PowerStackType StackType => PowerStackType.Single;

    // TODO: passive Block-per-turn effect, and the escalation trigger to
    // SophisticatedStellarealmPower after N Skills played. Needs the same API confirmation as
    // CollapsedCorePower.cs.
}
