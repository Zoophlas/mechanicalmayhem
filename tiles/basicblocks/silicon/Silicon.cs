using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace mechanicalmayhem.tiles.basicblocks.silicon
{
    public class Silicon : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            dustType = mod.DustType("Sparkle");
            drop = mod.ItemType("Silicon");
            AddMapEntry(new Color(128, 128, 128));

            // Aditional Data
            minPick = 50;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }
    }
}