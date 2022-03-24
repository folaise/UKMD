using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ukmd.Items
{
    public class Blood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Vial");
            Tooltip.SetDefault("Half-full or half-empty?");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 28;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(copper: 10);
            item.maxStack = 999;
        }
    }
}