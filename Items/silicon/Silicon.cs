using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace mechanicalmayhem.Items.silicon
{
    public class Silicon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The base ore for all electronic components.");
            ItemID.Sets.ExtractinatorMode[item.type] = item.type;

            // Translations to be added
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("Silicon");
            item.value = 150;
        }
    }
}
