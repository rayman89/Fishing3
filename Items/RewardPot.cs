using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class RewardPot : ModItem
	{
		public override void SetDefaults()
		{

			base.item.width = 20;
			base.item.height = 20;

			base.item.value = 100;
			base.item.rare = 2;
			base.item.UseSound = SoundID.Item3;
			base.item.useStyle = 2;
			base.item.useTurn = true;
			base.item.useAnimation = 17;
			base.item.useTime = 17;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Bottomless Battle Elixir");
      Tooltip.SetDefault("200th quest reward from the Angler. Gives many benefitial buffs.");
    }


		public override bool UseItem(Player player)
		{
			player.AddBuff(3, 30000, true);
			player.AddBuff(11, 30000, true);
			player.AddBuff(2, 30000, true);
			player.AddBuff(5, 30000, true);
			if (WorldGen.crimson)
			{
				player.AddBuff(117, 30000, true);
			}
			else
			{
				player.AddBuff(115, 30000, true);
			}
			return true;
		}
	}
}
