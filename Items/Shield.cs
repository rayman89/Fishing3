using System;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class Shield : ModItem
	{
		public override void SetDefaults()
		{


			base.item.value = 1;
			base.item.rare = 10;
			base.item.maxStack = 99;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Defense System");
      Tooltip.SetDefault("A physical defense System from a broken UFO.");
    }

	}
}
