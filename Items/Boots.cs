using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items
{
    public class Boots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can be upgraded into a various useful form of boot.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.value = 5000; // Set to 50 silver if not 50 silver
        }

        public override void AddRecipe()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Leather, 12);
            recipe.AddTile(ItemID.Workbenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}