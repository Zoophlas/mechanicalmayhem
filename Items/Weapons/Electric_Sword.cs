﻿using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace mechanicalmayhem.Items.Weapons
{
    public class Electric_Sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A Technologilcal sword that pulses with energy.");
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.melee = true;

            // Both of these values are placeholders
            item.width = 20;
            item.height = 20;

            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.buyPrice(gold: 2);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SiliconWafer", 12);
            recipe.AddIngredient(ItemID.GoldBar, 4);
            recipe.AddIngredient(ItemID.CopperBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
