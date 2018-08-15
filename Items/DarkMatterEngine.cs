using System;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class DarkMatterEngine : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An engine from a broken UFO.");
			DisplayName.SetDefault("Dark Matter Engine");
		}
		
		public override void SetDefaults()
		{
			base.item.value = 1;
			base.item.rare = 10;
			base.item.maxStack = 99;
		}
	}
}
