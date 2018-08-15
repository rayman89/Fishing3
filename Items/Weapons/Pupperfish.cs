using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace Fishing3.Items.Weapons
{
	public class Pupperfish : ModItem
	{
		public override void SetDefaults()
		{
			base.item.CloneDefaults(759);

			base.item.damage = 185;
			base.item.value = 500000;
			base.item.rare = 10;
			base.item.crit = 10;
			base.item.useAmmo = 0;
			base.item.useTime = 8;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Mecha Pupperfish");
      Tooltip.SetDefault("Explosive Biotech");
    }


		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(2625, 20);
			modRecipe.AddIngredient(base.mod.ItemType("Missiles"), 1);
			modRecipe.AddTile(base.mod.TileType("AnalyzerTile"));
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 vector = new Vector2(speedX, speedY).RotatedByRandom((double)MathHelper.ToRadians(14f));
			speedX = vector.X;
			speedY = vector.Y;
			return true;
		}
	}
}
