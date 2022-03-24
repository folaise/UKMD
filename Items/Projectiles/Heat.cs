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

namespace ukmd.Items.Projectiles
{
    public class Heat : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Heat Blast");
        }

        public override void SetDefaults()
        {
            projectile.width = 6;
            projectile.height = 120;
            projectile.aiStyle = 48;
            projectile.friendly = true;
            projectile.penetrate = 4;
            projectile.ranged = true;
            projectile.timeLeft = 300;
            projectile.arrow = false;
            drawOriginOffsetY = -60;
        }
    }
}