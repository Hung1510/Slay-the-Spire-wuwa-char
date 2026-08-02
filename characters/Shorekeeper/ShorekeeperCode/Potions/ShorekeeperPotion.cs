using BaseLib.Abstracts;
using BaseLib.Utils;
using Shorekeeper.ShorekeeperCode.Character;

namespace Shorekeeper.ShorekeeperCode.Potions;

[Pool(typeof(ShorekeeperPotionPool))]
public abstract class ShorekeeperPotion : CustomPotionModel;