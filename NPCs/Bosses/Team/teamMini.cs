using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Schnaver.NPCs.Bosses.Team
{
    public class teamMini : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 4;
            NPCID.Sets.TrailingMode[NPC.type] = 1;
        }

        public override void SetDefaults()
        {
            NPC.CloneDefaults(NPCID.CaveBat);
            NPC.width = 36;
            NPC.height = 30;
            NPC.damage = 24;
            NPC.defense = 12;
            NPC.lifeMax = 70;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            NPC.lavaImmune = true;
            NPC.noGravity = true;
            NPC.noTileCollide = false;
            AnimationType = NPCID.Bee;
        }

        public override bool CanHitPlayer(Player target, ref int cooldownSlot)
        {
            return base.CanHitPlayer(target, ref cooldownSlot);

        }
        public override void OnHitPlayer(Player target, Player.HurtInfo hitInfo)
        {
            target.AddBuff(BuffID.Poisoned, 200);
        }

    }
}
