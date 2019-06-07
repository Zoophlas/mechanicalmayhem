using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items
{
    public class FlightModule : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can be combined with other items to allow flight.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 25000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SiliconWafer", 3);
            recipe.AddIngredient(ItemID.CopperBar);
            recipe.AddIngredient(ItemID.GoldBar);
            recipe.AddIngredient(ItemID.SoulofFlight, 5);
            recipe.AddIngredient(ItemID.Feather, 3);
            recipe.AddTile(null, "SolderingTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}