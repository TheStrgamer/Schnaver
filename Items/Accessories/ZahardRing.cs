using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Schnaver.Items.Accessories
{


	[AutoloadEquip(EquipType.HandsOn)]
	public class ZahardRing : ModItem
	{
		public static readonly float HealthPerSecond = 5f;
        public static readonly int DefenceBoost = 10;

        public static readonly int MaxHealthIncrease = 100;

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 22;

			Item.accessory = true;
			Item.rare = ItemRarityID.Red;
			Item.value = Item.buyPrice(gold: 125);
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
            player.statDefense += DefenceBoost;
            player.lifeRegen += (int)(HealthPerSecond * 2); 
            player.statLifeMax2 += MaxHealthIncrease;

			player.fireWalk = true; 

		}
	}
}