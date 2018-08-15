using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Fishing3.Items.Projectiles
{
	public class Sharks : ModProjectile
	{
		
				public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sharks");
		}
		
		public override void SetDefaults()
		{
			projectile.CloneDefaults(356); // 387 sharknado beam varias "mordidas" 356 se ve bien pero es muy rapido
			ProjectileID.Sets.Homing[projectile.type] = true;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.width = 20; //52
			projectile.height = 28;
			projectile.alpha = 0;
			projectile.penetrate = 2;
			projectile.tileCollide = true;
						
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.Kill();
			return true;
		}
		
		private void AdjustMagnitude(ref Vector2 vector)
        {
            float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (magnitude > 6f)
            {
                vector *= 6f / magnitude;
            }
        }

		public override void AI()
		{
			//projectile.rotation = projectile.velocity.ToRotation();
			if (projectile.velocity.X > 0f)
			{
				projectile.spriteDirection = (projectile.direction = 1);
			}
			else if (projectile.velocity.X < 0f)
			{
				projectile.spriteDirection = (projectile.direction = -1);
			}
			
			{
				AdjustMagnitude(ref projectile.velocity);
                projectile.localAI[0] = 1f;
            }
				Vector2 move = Vector2.Zero;
				float distance = 400f;
				bool target = false;
				for (int k = 0; k < 200; k++)
            {
                if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
                {
                    Vector2 newMove = Main.npc[k].Center - projectile.Center;
                    float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
                    if (distanceTo < distance)
                    {
                        move = newMove;
                        distance = distanceTo;
                        target = true;
                    }
                }
            }
            if (target)
            {
                AdjustMagnitude(ref move);
                projectile.velocity = (10 * projectile.velocity + move) / 11f;
                AdjustMagnitude(ref projectile.velocity);
            }
		}
	}
}