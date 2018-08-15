using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class OceanCrate : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 20;
			item.maxStack = 99;

			item.rare = 2;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Ocean Crate");
      Tooltip.SetDefault("If you put it on your ear you will hear people laughing.");
    }


		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player){
			
		if (Main.hardMode){
			
		if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(ItemID.EndurancePotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 10) == 0) 		{	
			player.QuickSpawnItem(ItemID.MasterBait, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 3) == 0) 		{	
			player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 15)); }	
		if (Main.rand.Next(0, 3) == 0) 		{	
			player.QuickSpawnItem(ItemID.GreaterManaPotion, Main.rand.Next(5, 15)); }	
		if (Main.rand.Next(0, 3) == 0) 		{	
			player.QuickSpawnItem(ItemID.JourneymanBait, Main.rand.Next(2, 4)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.ObsidianSkinPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.ManaRegenerationPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.RegenerationPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.IronskinPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(ItemID.MagicPowerPotion, Main.rand.Next(1, 3)); }
	
	if (Main.rand.Next(0, 16) == 0) 		{		
int[] items = new int[] { ItemID.MoonCharm, ItemID.Tabi };
int randomItem = Main.rand.Next(2);
player.QuickSpawnItem(items[randomItem]);
											}

							}
							
		else 				{
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.RegenerationPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.IronskinPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.ObsidianSkinPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.SpelunkerPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.HunterPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.GravitationPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.HeartreachPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.NightOwlPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.ShinePotion, Main.rand.Next(1, 3)); }
				
	}
	
	if (Main.rand.Next(0, 2) == 0) 		{	
		player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(1, 3));
		if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.SharkFin);}
				if (Main.rand.Next(0, 3) == 0) 		{	
			player.QuickSpawnItem(ItemID.Coral, Main.rand.Next(1, 3)); }
	
	
	
		if (Main.rand.Next(0, 10) == 0) 		{		
int[] items = new int[] { ItemID.JellyfishNecklace, ItemID.DivingHelmet, ItemID.Trident };
int randomItem = Main.rand.Next(3);
player.QuickSpawnItem(items[randomItem]);
												}

	if (Main.rand.Next(0, 8) == 0) 		{		
int[] items = new int[] { ItemID.BreathingReed, ItemID.Flipper };
int randomItem = Main.rand.Next(2);
player.QuickSpawnItem(items[randomItem]);
											}

			if (Main.rand.Next(0, 12) == 0) 		{	
			player.QuickSpawnItem(ItemID.WaterWalkingBoots); }
			
			}
			}
			}
}
