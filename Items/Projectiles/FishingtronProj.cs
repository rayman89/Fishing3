using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Fishing3.Items.Projectiles
{
	 public class FishingtronProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BobberReinforced);
        }

		public override bool PreDrawExtras(SpriteBatch spriteBatch)
		{
			Player player = Main.player[projectile.owner];
			if (projectile.bobber && Main.player[projectile.owner].inventory[Main.player[projectile.owner].selectedItem].holdStyle > 0)
			{
				float num = player.MountedCenter.X;
				float num2 = player.MountedCenter.Y;
				num2 += Main.player[projectile.owner].gfxOffY;
				int type = Main.player[projectile.owner].inventory[Main.player[projectile.owner].selectedItem].type;
				float gravDir = Main.player[projectile.owner].gravDir;

				if (type == mod.ItemType("Fishingtron"))
				{
					num += (float)(50 * Main.player[projectile.owner].direction);
					if (Main.player[projectile.owner].direction < 0)
					{
						num -= 13f;
					}
					num2 -= 30f * gravDir;
				}
				
				if (gravDir == -1f)
				{
					num2 -= 12f;
				}
				Vector2 value = new Vector2(num, num2);
				value = Main.player[projectile.owner].RotatedRelativePoint(value + new Vector2(8f), true) - new Vector2(8f);
				float num13 = projectile.position.X + (float)projectile.width * 0.5f - value.X;
				float num14 = projectile.position.Y + (float)projectile.height * 0.5f - value.Y;
				Math.Sqrt((double)(num13 * num13 + num14 * num14));
				float rotation2 = (float)Math.Atan2((double)num14, (double)num13) - 1.57f;
				bool flag2 = true;
				if (num13 == 0f && num14 == 0f)
				{
					flag2 = false;
				}
				else
				{
					float num15 = (float)Math.Sqrt((double)(num13 * num13 + num14 * num14));
					num15 = 12f / num15;
					num13 *= num15;
					num14 *= num15;
					value.X -= num13;
					value.Y -= num14;
					num13 = projectile.position.X + (float)projectile.width * 0.5f - value.X;
					num14 = projectile.position.Y + (float)projectile.height * 0.5f - value.Y;
				}
				while (flag2)
				{
					float num16 = 12f;
					float num17 = (float)Math.Sqrt((double)(num13 * num13 + num14 * num14));
					float num18 = num17;
					if (float.IsNaN(num17) || float.IsNaN(num18))
					{
						flag2 = false;
					}
					else
					{
						if (num17 < 20f)
						{
							num16 = num17 - 8f;
							flag2 = false;
						}
						num17 = 12f / num17;
						num13 *= num17;
						num14 *= num17;
						value.X += num13;
						value.Y += num14;
						num13 = projectile.position.X + (float)projectile.width * 0.5f - value.X;
						num14 = projectile.position.Y + (float)projectile.height * 0.1f - value.Y;
						if (num18 > 12f)
						{
							float num19 = 0.3f;
							float num20 = Math.Abs(projectile.velocity.X) + Math.Abs(projectile.velocity.Y);
							if (num20 > 16f)
							{
								num20 = 16f;
							}
							num20 = 1f - num20 / 16f;
							num19 *= num20;
							num20 = num18 / 80f;
							if (num20 > 1f)
							{
								num20 = 1f;
							}
							num19 *= num20;
							if (num19 < 0f)
							{
								num19 = 0f;
							}
							num20 = 1f - projectile.localAI[0] / 100f;
							num19 *= num20;
							if (num14 > 0f)
							{
								num14 *= 1f + num19;
								num13 *= 1f - num19;
							}
							else
							{
								num20 = Math.Abs(projectile.velocity.X) / 3f;
								if (num20 > 1f)
								{
									num20 = 1f;
								}
								num20 -= 0.5f;
								num19 *= num20;
								if (num19 > 0f)
								{
									num19 *= 2f;
								}
								num14 *= 1f + num19;
								num13 *= 1f - num19;
							}
						}
						rotation2 = (float)Math.Atan2((double)num14, (double)num13) - 1.57f;
						Microsoft.Xna.Framework.Color color2 = Lighting.GetColor((int)value.X / 16, (int)(value.Y / 16f), new Microsoft.Xna.Framework.Color(200, 200, 200, 100));
						if (type == 2294)
						{
							color2 = Lighting.GetColor((int)value.X / 16, (int)(value.Y / 16f), new Microsoft.Xna.Framework.Color(100, 180, 230, 100));
						}
						if (type == 2295)
						{
							color2 = Lighting.GetColor((int)value.X / 16, (int)(value.Y / 16f), new Microsoft.Xna.Framework.Color(250, 90, 70, 100));
						}
						if (type == 2293)
						{
							color2 = Lighting.GetColor((int)value.X / 16, (int)(value.Y / 16f), new Microsoft.Xna.Framework.Color(203, 190, 210, 100));
						}
						if (type == 2421)
						{
							color2 = Lighting.GetColor((int)value.X / 16, (int)(value.Y / 16f), new Microsoft.Xna.Framework.Color(183, 77, 112, 100));
						}
						if (type == 2422)
						{
							color2 = Lighting.GetColor((int)value.X / 16, (int)(value.Y / 16f), new Microsoft.Xna.Framework.Color(255, 226, 116, 100));
						}
						Main.spriteBatch.Draw(Main.fishingLineTexture, new Vector2(value.X - Main.screenPosition.X + (float)Main.fishingLineTexture.Width * 0.5f, value.Y - Main.screenPosition.Y + (float)Main.fishingLineTexture.Height * 0.5f), new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, 0, Main.fishingLineTexture.Width, (int)num16)), color2, rotation2, new Vector2((float)Main.fishingLineTexture.Width * 0.5f, 0f), 1f, SpriteEffects.None, 0f);
					}
				}
			}
			return false;
		}
	}
}