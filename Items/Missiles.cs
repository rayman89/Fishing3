using System;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class Missiles : ModItem
	{
		public override void SetDefaults()
		{


			base.item.value = 1;
			base.item.rare = 10;
			base.item.maxStack = 99;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Missile System");
      Tooltip.SetDefault("The Missile System of a broken UFO.");
    }

	}
}
