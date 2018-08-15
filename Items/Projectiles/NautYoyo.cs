using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items.Projectiles
{
	public class NautYoyo : ModProjectile
	{
		
				public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NautYoyo");
		}
		
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Terrarian);
			float basemeleespeed = Main.player[projectile.owner].meleeSpeed;
        }

        

        public override bool PreAI()
        {
            Main.player[projectile.owner].meleeSpeed *= 0.5f;
            if (Main.rand.Next(8) == 0)
            {
                float randvx = 3f * Main.rand.NextFloat() - 2f;
                float randvy = 3f * Main.rand.NextFloat() - 2f;
                int spark = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 1.5f * randvx, 1.5f * randvy, mod.ProjectileType("NautBubbles"), (int)(0.6f * projectile.damage), 1f, projectile.owner);
            }
           // if (Main.rand.Next(3) == 0)
         //   {
        //        int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), 50, 50, 181); //111 es el dust id a probar: 181 188 156 110 165 174
            //}

            return true;
        }

        public override void PostAI()
        {
            Main.player[projectile.owner].meleeSpeed *= 2f;
        }

			
	}
}