using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace Schnaver.Projectiles
{
    public class SchnaBlast : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 30;
            Projectile.height = 30;
            Projectile.friendly = true;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 140;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
        }

        

    }
}
