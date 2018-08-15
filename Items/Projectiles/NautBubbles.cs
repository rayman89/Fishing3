using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace Fishing3.Items.Projectiles
{
	public class NautBubbles : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NautBubbles");
		}
		
		public override void SetDefaults()
		{
			base.projectile.CloneDefaults(76);
			base.projectile.light = 0.4f;
			base.projectile.alpha = 0;
			base.projectile.ranged = false;
			base.projectile.melee = true;
		}

		public override void AI()
		{
			if (Main.time % 3.0 == 0.0)
			{
				base.projectile.alpha++;
				if (base.projectile.alpha >= 240)
				{
					base.projectile.Kill();
				}
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			base.projectile.Kill();
			return false;
		}
	}
}
