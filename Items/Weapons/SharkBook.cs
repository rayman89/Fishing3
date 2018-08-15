using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items.Weapons
{
	public class SharkBook : ModItem
	{
		
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.CrystalStorm); //ItemID.Musket

			item.damage = 105;
            item.value = 500000;
            item.rare = 10;
			item.useTime = 15;
            item.shoot = mod.ProjectileType("Sharks");
			item.mana = 18;
			base.item.crit = 12;
			item.UseSound = SoundID.Item44;
			item.shootSpeed = 6f;

			
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Book of Sharknados");
      Tooltip.SetDefault("A book full of hungry sharks.");
    }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SharkFin, 12);
			recipe.AddIngredient(mod.ItemType("MagiCore"));
			recipe.AddTile(mod.TileType("AnalyzerTile"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

     public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}

	}
}
