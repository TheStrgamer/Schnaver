using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace Schnaver.Projectiles
{
    public class SyntaxError : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 120;
            Projectile.height = 30;
            Projectile.friendly = true;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 120;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.light = 0.5f;
        }

        public override void AI()
        {
            // Find the nearest enemy
            float closestDistance = float.MaxValue;
            int closestNPC = -1;
            for (int i = 0; i < Main.npc.Length; i++)
            {
                NPC npc = Main.npc[i];
                if (npc.active && !npc.friendly)
                {
                    float distance = Vector2.Distance(Projectile.Center, npc.Center);
                    if (distance < closestDistance)
                    {
                        closestDistance = distance;
                        closestNPC = i;
                    }
                }
            }

            // Slightly adjust the projectile's direction towards the nearest enemy
            if (closestNPC != -1)
            {
                NPC target = Main.npc[closestNPC];
                Vector2 direction = target.Center - Projectile.Center;
                direction.Normalize();
                Projectile.velocity += direction * Projectile.velocity.Length()*0.01f;
            }
        }

    }
}
