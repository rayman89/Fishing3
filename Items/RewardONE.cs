using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class RewardONE : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 20;

			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item3;
			item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
			
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Bottomless Fishing Elixir");
      Tooltip.SetDefault("100th quest reward from the Angler. Gives Fishing Buffs.");
    }

		public override bool UseItem(Player player)
		{
			player.AddBuff(123,30000); //crate potion
			player.AddBuff(122,30000); //sonar potion
			player.AddBuff(121,30000); //fishing potion
			
		return true;
		}
	}
}
