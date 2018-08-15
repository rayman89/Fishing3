using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class DesertCrate : ModItem
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
      DisplayName.SetDefault("Desert Crate");
      Tooltip.SetDefault("Sandy in all the right places.");
    }


		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{		
		if (Main.hardMode)
			{
			player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(2, 10));

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
		if (Main.rand.Next(0, 28) == 0) 		{	
			player.QuickSpawnItem(ItemID.AncientHorn); }
			
					if (Main.rand.Next(0, 12) == 0) 		{	
int[] items = new int[] { ItemID.SkyFracture, ItemID.OnyxBlaster, 3795, 3783 }; //desert spirit lamp y Forbidden Fragment
int randomItem = Main.rand.Next(4);
player.QuickSpawnItem(items[randomItem]);
															}
				}
			
						
		if (!Main.hardMode)
			{		
		player.QuickSpawnItem(ItemID.SilverCoin, Main.rand.Next(1, 3));
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
				if (Main.rand.Next(0, 10) == 0) 		{	
			player.QuickSpawnItem(ItemID.PharaohsMask);
			player.QuickSpawnItem(ItemID.PharaohsRobe);}
				if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(3772); } //MandibleBlade
				
				if (Main.rand.Next(0, 14) == 0) 		{	
int[] items = new int[] { ItemID.SandstorminaBottle, ItemID.FlyingCarpet, ItemID.EnchantedSword }; 
int randomItem = Main.rand.Next(3);
player.QuickSpawnItem(items[randomItem]);
											}
			}
		
		}
	}
}
