using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items.Weapons
{
	public class MechaStar : ModItem
	{
		public override void SetDefaults()
		{
			base.item.CloneDefaults(757);

			base.item.damage = 112;
			base.item.value = 500000;
			base.item.rare = 10;
			base.item.shoot = base.mod.ProjectileType("MStarProj");
			base.item.shootSpeed = 16f;
			base.item.UseSound = SoundID.Item1;
			base.item.width = 18;
			base.item.height = 20;
			base.item.crit = 5;
			base.item.thrown = true;
			base.item.consumable = false;
			base.item.useAnimation = 15;
			base.item.useTime = 6;
			base.item.noUseGraphic = true;
			base.item.melee = false;
			base.item.noMelee = true;
			base.item.thrown = true;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Mechanical Starfish");
      Tooltip.SetDefault("Throwable biotech");
    }


		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(2626, 20);
			modRecipe.AddIngredient(base.mod.ItemType("CloseCS"), 1);
			modRecipe.AddTile(base.mod.TileType("AnalyzerTile"));
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int num = 3;
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = new Vector2(speedX, speedY).RotatedByRandom((double)MathHelper.ToRadians(15f));
				Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, type, damage, knockBack, player.whoAmI, 0f, 0f);
			}
			return false;
		}
	}
}
