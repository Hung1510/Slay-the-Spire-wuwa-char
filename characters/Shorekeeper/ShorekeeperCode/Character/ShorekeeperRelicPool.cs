using BaseLib.Abstracts;
using Shorekeeper.ShorekeeperCode.Extensions;
using Godot;

namespace Shorekeeper.ShorekeeperCode.Character;

public class ShorekeeperRelicPool : CustomRelicPoolModel
{
    public override Color LabOutlineColor => Shorekeeper.Color;

    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();
}