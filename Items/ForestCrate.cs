using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class ForestCrate : ModItem
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
      DisplayName.SetDefault("Forest Crate");
      Tooltip.SetDefault("Smells like fresh cut grass.");
    }


		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			
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
				player.QuickSpawnItem(ItemID.ShinePotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.RegenerationPotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.IronskinPotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.SwiftnessPotion, Main.rand.Next(1, 3)); }
				
						}	
			
			if (!Main.hardMode){			
									if (Main.rand.Next(0, 28) == 0) 		{	
										player.QuickSpawnItem(ItemID.SlimeStaff); }
				
									if (Main.rand.Next(0, 10) == 0 && NPC.downedBoss1) 		{	
										player.QuickSpawnItem(ItemID.Code1); }
				
									if (Main.rand.Next(0, 12) == 0) 		{		
										int[] items = new int[] { ItemID.Spear, ItemID.WoodenBoomerang, ItemID.Blowpipe, ItemID.WandofSparking };
										int randomItem = Main.rand.Next(4);
										player.QuickSpawnItem(items[randomItem]);
																			}
											if (Main.rand.Next(0, 3) == 0) 		{	
				player.QuickSpawnItem(ItemID.JourneymanBait, Main.rand.Next(2, 4)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.ObsidianSkinPotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.ShinePotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.RegenerationPotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.IronskinPotion, Main.rand.Next(1, 3)); }
			if (Main.rand.Next(0, 5) == 0) 		{	
				player.QuickSpawnItem(ItemID.SwiftnessPotion, Main.rand.Next(1, 3)); }		
	if (Main.rand.Next(0, 3) == 0) 		{	
				player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 15)); }	
			if (Main.rand.Next(0, 3) == 0) 		{	
				player.QuickSpawnItem(ItemID.ManaPotion, Main.rand.Next(5, 15)); }				
																			
														
								}		
									
			if (Main.hardMode && NPC.downedMechBossAny){
					if (Main.rand.Next(0, 16) == 0) 	{		
					int[] items = new int[] { ItemID.PirateStaff, ItemID.Code2 };
					int randomItem = Main.rand.Next(2);
					player.QuickSpawnItem(items[randomItem]);
													}

														
				
							}
		}		
	}
}
