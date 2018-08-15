using System;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class MetalicTruffle : ModItem
	{
		public override void SetDefaults()
		{

			base.item.width = 20;
			base.item.height = 30;

			base.item.useTime = 20;
			base.item.useAnimation = 20;
			base.item.useStyle = 1;
			base.item.value = 30000;
			base.item.rare = 2;
			base.item.noMelee = true;
			base.item.mountType = base.mod.MountType("MechaFishron");
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Metalic Truffle");
      Tooltip.SetDefault("Dark Matter Powered Mecha Fishron");
    }


		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(base.mod.ItemType("DarkMatterEngine"), 1);
			modRecipe.AddIngredient(3367, 1);
			modRecipe.AddTile(base.mod.TileType("AnalyzerTile"));
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}
	}
}
