using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items
{
    public class SpeedModule : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can be combined with other items to increase speed.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 5000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SiliconWafer", 3);
            recipe.AddIngredient(ItemID.CopperBar);
            recipe.AddIngredient(ItemID.GoldBar);
            recipe.AddIngredient(ItemID.PinkGel, 5);
            recipe.AddTile(null, "SolderingTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}