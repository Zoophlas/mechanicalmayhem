using Terraria;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items.Accessories.Boots
{
    [AutoloadEquip(EquipType.Shoes)]
    public class SpeedBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Non magic way for immense speed. Faster too!");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 28;
            item.value = 300000;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed = 1.62f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Boots");
            recipe.AddIngredient(null, "SpeedModule");
            recipe.AddTile(null, "SolderingTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}