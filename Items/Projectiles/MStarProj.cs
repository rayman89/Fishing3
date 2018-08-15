using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items.Projectiles
{
	public class MStarProj : ModProjectile
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MStarProj");
		}
		
		public override void SetDefaults()
		{
			projectile.CloneDefaults(3); // 3 shuriken 132 terra blade proj 330 star anis
			projectile.penetrate = 2;			
        }

         
			
	}
}