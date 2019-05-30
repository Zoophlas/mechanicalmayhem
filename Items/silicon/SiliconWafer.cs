using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace mechanicalmayhem.Items.silicon
{
    public class SiliconWafer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A circular wafer made out of silicon.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 750;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Silicon", 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
