using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class Scrap : ModItem
	{
		public override void SetDefaults()
		{


			item.value = 1;
			item.rare = 1;
			item.maxStack = 99;
		}	

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Scrap");
      Tooltip.SetDefault("Metal scrap left by destroyed machinery during the alien invasion.");
    }

		
	}
}
