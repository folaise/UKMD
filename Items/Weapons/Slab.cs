using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace ukmd.Items.Weapons
{
    public class Slab : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slab Piercer");
        }
        public override void SetDefaults()
        {
            item.scale = 0.85f;
            item.Size = new Vector2(26, 48);
            item.rare = ItemRarityID.Lime;
            item.value = Item.sellPrice(silver: 22);

            item.useTime = 70;
            item.useAnimation = 71;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/SlabRev");

            item.autoReuse = true;
            item.noMelee = true;
            item.ranged = true;
            item.damage = 300;

            item.useAmmo = AmmoID.None;
            item.shoot = ProjectileID.HeatRay;
            item.shootSpeed = 10.0f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Blood>(), 50);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 3);
        }
    }
}