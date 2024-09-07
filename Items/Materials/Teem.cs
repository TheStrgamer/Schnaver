using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Schnaver.Items.Materials
{
    public class Teem : ModItem
    {
        public new string LocalizationCategory => "Items.Materials";

        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 5;
            ItemID.Sets.SortingPriorityMaterials[Type] = 109;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.maxStack = 9999;
            Item.value = Item.sellPrice(0, 2, 50, 0);
            Item.rare = ItemRarityID.Purple;
        }
    }
}
