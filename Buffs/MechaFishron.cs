using System;
using Terraria;
using Terraria.ModLoader;

namespace Fishing3.Buffs
{
	public class MechaFishron : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Mecha Fishron");
			Description.SetDefault("Dark Matter Powered Mecha Fishron");
			Main.buffNoTimeDisplay[base.Type] = true;
			Main.buffNoSave[base.Type] = true;
		    
    }


		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(base.mod.MountType("MechaFishron"), player, false);
			player.buffTime[buffIndex] = 10;
		}
	}
}
