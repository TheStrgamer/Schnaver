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
    public class SchnaBlaster : ModItem
    {

        public override void SetDefaults()
        {

            int damage = 16;
            int manaCost = 12;
            bool autoReuse = true;

            Item.DefaultToMagicWeapon(ModContent.ProjectileType<SchnaBlast>(), damage, manaCost, autoReuse);
            

			Item.width = 48;
			Item.height = 16;
			Item.UseSound = SoundID.Item20;


			Item.SetWeaponValues(damage, 2, 55);

			Item.SetShopValues(ItemRarityColor.LightRed4, 1000);

        }

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) 
        {
            int baseOffsetX = 45;    
            int baseOffsetY = 45;

            Vector2 mousePosition = Main.MouseWorld;
            Vector2 playerPosition = player.Center;
            Vector2 direction = mousePosition - playerPosition;
            direction.Normalize();

            float offsetX = baseOffsetX * direction.X * player.direction;   
            float offsetY = baseOffsetY * direction.Y;




            Vector2 spawnPosition = player.Center + new Vector2(offsetX * player.direction, offsetY);

            int projIndex = Projectile.NewProjectile(source, spawnPosition, velocity, type, damage, knockback, player.whoAmI);
            Projectile proj = Main.projectile[projIndex];
            proj.rotation = direction.ToRotation();



            return false;
        }

    }
}
