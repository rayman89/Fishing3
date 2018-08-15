using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class SoulBait : ModItem
	{
		public override void SetDefaults()
		{


			item.value = 1000;
			item.rare = 2;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.bait = 60;
			item.consumable = true;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Soul Bait");
      Tooltip.SetDefault("A possesed bait that attracts spirits from the deep waters");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MasterBait, 1);
			recipe.AddIngredient(ItemID.SoulofSight, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}
