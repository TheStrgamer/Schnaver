using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using System.Collections.Generic;
using Terraria.Utilities;
using Terraria.Localization;
using System;
using Schnaver.Items.Weapons;


namespace Schnaver.NPCs
{
    [AutoloadHead]
    public class Konrad : ModNPC
    {
        public const string shopName = "Konrads shop";

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.Angler]; 

            NPC.Happiness.SetBiomeAffection<ForestBiome>(AffectionLevel.Like)
            .SetBiomeAffection<CorruptionBiome>(AffectionLevel.Hate)
            .SetBiomeAffection<CrimsonBiome>(AffectionLevel.Dislike)
            .SetBiomeAffection<HallowBiome>(AffectionLevel.Like)
            .SetBiomeAffection<DesertBiome>(AffectionLevel.Dislike)
            .SetBiomeAffection<SnowBiome>(AffectionLevel.Like)
            .SetBiomeAffection<JungleBiome>(AffectionLevel.Love)
            .SetBiomeAffection<OceanBiome>(AffectionLevel.Like)
            .SetBiomeAffection<UndergroundBiome>(AffectionLevel.Like)
            .SetNPCAffection(NPCID.Nurse, AffectionLevel.Love)
            .SetNPCAffection(NPCID.Dryad, AffectionLevel.Love)
            .SetNPCAffection(NPCID.ArmsDealer, AffectionLevel.Like)
            .SetNPCAffection(NPCID.Painter, AffectionLevel.Dislike)
            .SetNPCAffection(NPCID.Angler, AffectionLevel.Hate)
            .SetNPCAffection(NPCID.GoblinTinkerer, AffectionLevel.Dislike)
            .SetNPCAffection(NPCID.WitchDoctor, AffectionLevel.Love)
            .SetNPCAffection(NPCID.Clothier, AffectionLevel.Like)
            .SetNPCAffection(NPCID.Mechanic, AffectionLevel.Love)
            .SetNPCAffection(NPCID.Wizard, AffectionLevel.Love)
            .SetNPCAffection(NPCID.TaxCollector, AffectionLevel.Dislike)
            .SetNPCAffection(NPCID.Truffle, AffectionLevel.Love)
            .SetNPCAffection(NPCID.Steampunker, AffectionLevel.Love)
            ;
        }

        public override void SetDefaults()
        {
            NPC.width = 18;
            NPC.height = 40;
            NPC.friendly = true;
            NPC.townNPC = true;
            NPC.aiStyle = 7;
            NPC.damage = 50;
            NPC.defense = 25;
            NPC.lifeMax = 350;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.Angler;
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                new FlavorTextBestiaryInfoElement("Konrad is a mysterious npc, he claims to be from a place called Bergen, must be a foreign land.")
            });
        }

        public override bool CanTownNPCSpawn(int numTownNPCs) {
            return Main.hardMode; // Returns true if the Wall of Flesh has been defeated
        }

        public override List<string> SetNPCNameList()
        {
            List<string> names = new List<string>();
            names.Add("Konrad");
            names.Add("Konrad the generous");
            names.Add("Konrad the wise");
            names.Add("Konrad the monke");
            names.Add("Konrad the computer scientist");
            names.Add("Konrad the mysterious");
            names.Add("Konrad Seime");
            names.Add("Konrad Oye");
            return names;
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Shop";
        }
       
        public override void AddShops()
        {
            var npcShop = new NPCShop(Type, shopName)
                .Add<BladeOfApe>()
                .Add(ItemID.IronskinPotion)
                .Add(ItemID.EndurancePotion)
                .Add(ItemID.RegenerationPotion)
                .Add(ItemID.SwiftnessPotion)
                .Add(ItemID.WrathPotion)
                .Add(ItemID.CrystalSerpent)
                .Add(ItemID.TerrasparkBoots);

            npcShop.Register();
        }

		public override void OnChatButtonClicked(bool firstButton, ref string shop) {
			if (firstButton) {

				shop = shopName; // Name of the shop tab we want to open.
			}
        }

        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();

            chat.Add(Language.GetTextValue("Do you like Java?"));
            chat.Add(Language.GetTextValue("This place is a lot weirder than Bergen"));
            chat.Add(Language.GetTextValue("Terraria is my favorite game"));
            chat.Add(Language.GetTextValue("Hello " + Environment.UserName));
            chat.Add(Language.GetTextValue("I never met someone named " + Environment.UserName + " before"));
            chat.Add(Language.GetTextValue("Where is the 3D printer?"));
            chat.Add(Language.GetTextValue("Why is my house not better?"));

            return chat.Get();
        }

    }
}
