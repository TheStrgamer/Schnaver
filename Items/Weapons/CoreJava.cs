using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Schnaver.Items.Materials;
using Schnaver.Projectiles;
using Terraria.Enums;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using System;



namespace Schnaver.Items.Weapons
{
    public class CoreJava : ModItem
    {

        public override void SetDefaults()
        {


            Item.DefaultToMagicWeapon(ModContent.ProjectileType<SyntaxError>(), 20, 10, true);
            

			Item.width = 34;
			Item.height = 40;
			Item.UseSound = SoundID.Item20;


			Item.SetWeaponValues(40, 2, 25);

			Item.SetShopValues(ItemRarityColor.LightRed4, 10000);

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Book, 1)
                .AddIngredient<Teem>(7)
                .AddIngredient(ItemID.SoulofLight, 10)
                .AddIngredient(ItemID.SoulofNight, 10)
                .AddTile(TileID.Bookcases)
                .Register();
        }

    }
}
