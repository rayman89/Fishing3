using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items
{
	public class PCorruptCrate : ModItem
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
      DisplayName.SetDefault("Possessed Corruption Crate");
      Tooltip.SetDefault("Infused with spiritual power");
    }


		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(2, 10));

		if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(ItemID.EndurancePotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(ItemID.MasterBait, Main.rand.Next(3, 5)); }
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
		if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(ItemID.InfernoPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 8) == 0) 		{	
			player.QuickSpawnItem(ItemID.MagicPowerPotion, Main.rand.Next(1, 3)); }
		if (Main.rand.Next(0, 12) == 0) 		{	
			player.QuickSpawnItem(ItemID.WrathPotion, Main.rand.Next(1, 3)); }
			
			if (Main.rand.Next(0, 5) == 0) 		{	
			player.QuickSpawnItem(ItemID.SoulofNight, Main.rand.Next(1, 5)); }
			
		if (Main.rand.Next(0, 10) == 0) 		{	
int[] items = new int[] { ItemID.DartRifle, ItemID.WormHook, ItemID.ChainGuillotines, ItemID.ClingerStaff, ItemID.PutridScent };
int randomItem = Main.rand.Next(5);
player.QuickSpawnItem(items[randomItem]);
											}
			
		}
	}
}
