using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class CloseCS : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The close combat system of a broken UFO.");
			DisplayName.SetDefault("Close Combat System");
		}
		
		public override void SetDefaults()
		{
			item.value = 1;
			item.rare = 10;
			item.maxStack = 99;
		}	
		
	}
}