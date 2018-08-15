using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class Analyzer : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to decipher the mysteries of the alien technology.");
			DisplayName.SetDefault("Advanced Analyzer");
		}
		
		public override void SetDefaults()
		{
		    item.createTile = mod.TileType("AnalyzerTile");
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000;
			item.rare = 2;
			item.placeStyle = 0;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Scrap"), 20);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}