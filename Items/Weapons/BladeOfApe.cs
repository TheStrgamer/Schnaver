using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Schnaver.Items.Weapons
{
	public class BladeOfApe : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Schnaver.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 30;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

        public override void AddRecipes()
        {
            CreateRecipe()
				.AddIngredient(ItemID.Banana, 10)
				.AddIngredient(ItemID.DemoniteBar, 10)
				.AddTile(TileID.Anvils)
				.Register();
        }

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(15))
			{
				player.AddBuff(BuffID.Rage, 180);
			}
		}
    }
}