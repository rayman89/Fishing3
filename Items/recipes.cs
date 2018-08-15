using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.GameContent;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class recipes : ModItem
	{	
		public override void AddRecipes()
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldenCrate, 1);
				recipe.AddIngredient(ItemID.JungleSpores, 10);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(3208, 1);
				recipe.AddRecipe();
			
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldenCrate, 1);
				recipe.AddIngredient(ItemID.EbonstoneBlock, 100);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(3203, 1);
				recipe.AddRecipe();
			
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldenCrate, 1);
				recipe.AddIngredient(ItemID.CrimstoneBlock, 100);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(3204, 1);
				recipe.AddRecipe();
			
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldenCrate, 1);
				recipe.AddIngredient(ItemID.CrystalShard, 10);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(3207, 1);
				recipe.AddRecipe();
			
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldenCrate, 1);
				recipe.AddIngredient(ItemID.Feather, 10);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(3206, 1);
				recipe.AddRecipe();
			
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GoldenCrate, 1);
				recipe.AddIngredient(ItemID.Bone, 10);
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(3205, 1);
				recipe.AddRecipe();
			}		
	}
}


