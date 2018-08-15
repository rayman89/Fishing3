using System;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class MagiCore : ModItem
	{
		public override void SetDefaults()
		{


			base.item.value = 1;
			base.item.rare = 10;
			base.item.maxStack = 99;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Magical Core");
      Tooltip.SetDefault("The magical core of a broken UFO.");
    }

	}
}
