using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items.Tools
{
    public class ElectricPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A Technologilcal pickaxe that pulses with energy.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useAnimation = 21;
            item.useTime = 21;
            item.pick = 80;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

            /* This may be important for later
             * Player.tileRangeX += 35;
             * Player.tileRangeY += 34; 
             */
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SiliconWafer", 12);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddIngredient(ItemID.CopperBar, 6);
            recipe.AddTile(null, "SolderingTable");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}