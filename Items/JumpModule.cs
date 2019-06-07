using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items
{
    public class JumpModule : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can be combined with other items to increase jump height.");
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
            recipe.AddIngredient(null, SiliconWafer, 3);
            recipe.AddIngredient(ItemID.CopperBar);
            recipe.AddIngredient(ItemID.GoldBar);
            recipe.AddIngredients(ItemID.Gel, 5);
            recipe.AddTile(null, "SolderingTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}