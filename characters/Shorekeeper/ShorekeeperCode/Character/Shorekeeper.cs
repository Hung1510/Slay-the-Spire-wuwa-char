using BaseLib.Abstracts;
using BaseLib.Utils.NodeFactories;
using Shorekeeper.ShorekeeperCode.Cards;
using Shorekeeper.ShorekeeperCode.Extensions;
using Shorekeeper.ShorekeeperCode.Relics;
using Godot;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Models.Relics;

namespace Shorekeeper.ShorekeeperCode.Character;

public class Shorekeeper : PlaceholderCharacterModel
{
    public const string CharacterId = "Shorekeeper";
    
    public static readonly Color Color = new("ffffff");

    public override Color NameColor => Color;
    public override CharacterGender Gender => CharacterGender.Neutral;
    public override int StartingHp => 70;
    
    // 5x CollapsedStrike (her real starter Attack) replacing the placeholder StrikeIronclad.
    // DefendIronclad is still a placeholder - swap for a real Skill (e.g. "Cast Stellarealm"
    // from DESIGN.md) once that card exists. Don't ship with a base-game card still in here.
    public override IEnumerable<CardModel> StartingDeck => [
        ModelDb.Card<CollapsedStrike>(),
        ModelDb.Card<CollapsedStrike>(),
        ModelDb.Card<CollapsedStrike>(),
        ModelDb.Card<CollapsedStrike>(),
        ModelDb.Card<CollapsedStrike>(),
        ModelDb.Card<DefendIronclad>(), // TODO replace with a real Shorekeeper Skill card
        ModelDb.Card<DefendIronclad>(), // TODO replace with a real Shorekeeper Skill card
        ModelDb.Card<DefendIronclad>(), // TODO replace with a real Shorekeeper Skill card
        ModelDb.Card<DefendIronclad>(), // TODO replace with a real Shorekeeper Skill card
        ModelDb.Card<DefendIronclad>()  // TODO replace with a real Shorekeeper Skill card
    ];

    public override IReadOnlyList<RelicModel> StartingRelics =>
    [
        ModelDb.Relic<ArchivistsLedger>()
    ];
    
    public override CardPoolModel CardPool => ModelDb.CardPool<ShorekeeperCardPool>();
    public override RelicPoolModel RelicPool => ModelDb.RelicPool<ShorekeeperRelicPool>();
    public override PotionPoolModel PotionPool => ModelDb.PotionPool<ShorekeeperPotionPool>();
    
    /*  PlaceholderCharacterModel will utilize placeholder basegame assets for most of your character assets until you
        override all the other methods that define those assets. 
        These are just some of the simplest assets, given some placeholders to differentiate your character with. 
        You don't have to, but you're suggested to rename these images. */
    public override Control CustomIcon
    {
        get
        {
            var icon = NodeFactory<Control>.CreateFromResource(CustomIconTexturePath);
            icon.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
            return icon;
        }
    }
    public override string CustomIconTexturePath => "character_icon_char_name.png".CharacterUiPath();
    public override string CustomCharacterSelectIconPath => "char_select_char_name.png".CharacterUiPath();
    public override string CustomCharacterSelectLockedIconPath => "char_select_char_name_locked.png".CharacterUiPath();
    public override string CustomMapMarkerPath => "map_marker_char_name.png".CharacterUiPath();
}