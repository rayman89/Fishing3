using System;
using Terraria.ModLoader;

namespace Fishing3.Items.Weapons
{
	public class ArmoredNautilus : ModItem
	{
		public override void SetDefaults()
		{
			base.item.CloneDefaults(3389);

			base.item.damage = 165;
			base.item.shootSpeed = 20f;
			base.item.knockBack = 2.5f;
			base.item.crit = 12;
			base.item.value = 500000;
			base.item.rare = 10;
			base.item.shoot = base.mod.ProjectileType("NautYoyo");
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Armored Nautilus");
      Tooltip.SetDefault("Spiky Biotech on a string.");
    }


		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(2625, 20);
			modRecipe.AddIngredient(base.mod.ItemType("Shield"), 1);
			modRecipe.AddTile(base.mod.TileType("AnalyzerTile"));
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}
	}
}
