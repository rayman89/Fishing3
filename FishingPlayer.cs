using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3
{
	public class FishingPlayer : ModPlayer
	{
		//handle Vanilla fishing (standard tML method)
		public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
		{
			var zone = Zone.None;
			if(player.ZoneCorrupt)
				zone |= Zone.Corrupt;
			if(player.ZoneCrimson)
				zone |= Zone.Crimson;
			if(player.ZoneSnow)
				zone |= Zone.Snow;
			if(player.ZoneJungle)
				zone |= Zone.Jungle;
			if(player.ZoneGlowshroom)
				zone |= Zone.Shroom;
			if(player.ZoneDesert)
				zone |= Zone.Desert;
			if(player.ZoneHoly)
				zone |= Zone.Holy;
			if(player.ZoneDungeon)
				zone |= Zone.Dungeon;

			_CatchFish(false, player.Center, zone, fishingRod, bait, power, liquidType, poolSize, worldLayer, ref caughtType, ref junk);
		}

		//handle Miscellania Autofisher
		public static void AutofisherCatchFish(Vector2 position, int zoneInfo, Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, ref int caughtType, ref bool junk)
		{
			_CatchFish(true, position, (Zone)zoneInfo, fishingRod, bait, power, liquidType, poolSize, worldLayer, ref caughtType, ref junk);
		}

		//actual fishing logic
		static void _CatchFish(bool automatic, Vector2 position, Zone zone, Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, ref int caughtType, ref bool junk)
		{
			//Main.NewText("you called? automatic: " + automatic);
			//Main.NewText("zone: " + zone);
			//Main.NewText("bait item: " + bait);
			//Main.NewText("liquidType: " + liquidType);
			//Main.NewText("worldLayer: " + worldLayer);
			//Main.NewText("fishing power: " + power);
			var mod = Fishing3.Instance;
			int rarityMultiplier = automatic ? 3 : 1;
			if(bait.type == Fishing3.Instance.ItemType("SoulBait") && liquidType == 0)
			{
				if(Main.rand.Next(0, 10 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Dungeon))
				{
					caughtType = mod.ItemType("PossessedCrate");
				}
				if(Main.rand.Next(0, 10 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Jungle))
				{
					caughtType = mod.ItemType("PJungleCrate");
				}
				if(Main.rand.Next(0, 10 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Crimson))
				{
					caughtType = mod.ItemType("PCrimsonCrate");
				}
				if(Main.rand.Next(0, 10 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Corrupt))
				{
					caughtType = mod.ItemType("PCorruptCrate");
				}
				if(Main.rand.Next(0, 10 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Holy))
				{
					caughtType = mod.ItemType("PHallowCrate");
				}
			}

			if(Main.rand.Next(0, 12 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Desert) && liquidType == 0)
			{
				caughtType = mod.ItemType("DesertCrate");
			}

			var coords = position.ToTileCoordinates16();
			bool ocean = (worldLayer == 1) && (coords.X < 380 || coords.X > Main.maxTilesX - 380);

			if(Main.rand.Next(0, 12 * rarityMultiplier) == 0 && zone == Zone.None && !ocean && liquidType == 0 && worldLayer == 1)
			{
				caughtType = mod.ItemType("ForestCrate");
			}

			if(Main.rand.Next(0, 12 * rarityMultiplier) == 0 && zone == Zone.None && worldLayer == 3 && liquidType == 0)
			{
				caughtType = mod.ItemType("CaveCrate");
			}
			if(Main.rand.Next(0, 12 * rarityMultiplier) == 0 && ocean && liquidType == 0)
			{
				caughtType = mod.ItemType("OceanCrate");
			}
			if(Main.rand.Next(0, 12 * rarityMultiplier) == 0 && zone.HasFlag(Zone.Snow) && liquidType == 0)
			{
				caughtType = mod.ItemType("IceCrate");
			}
			if(liquidType == 1 && Main.rand.Next(0, 12 * rarityMultiplier) == 0 && worldLayer == 4)
			{
				caughtType = mod.ItemType("ObsidianCrate");
			}
			if(fishingRod.type == mod.ItemType("Fishingtron") && liquidType == 0 && worldLayer == 1)
			{
				if(Main.rand.Next(0, 7 * rarityMultiplier) == 0)
				{
					caughtType = mod.ItemType("Scrap");
				}
				if(Main.rand.Next(0, 41 * rarityMultiplier) == 0)
				{
					caughtType = (new int[]
					{
						mod.ItemType("DarkMatterEngine"),
						mod.ItemType("Shield"),
						mod.ItemType("CloseCS"),
						mod.ItemType("Missiles"),
						mod.ItemType("MagiCore")
					})[Main.rand.Next(5)];
				}
			}

			if(Main.hardMode)
			{
				if(Main.bloodMoon && Main.rand.Next(0, 15 * rarityMultiplier) == 0)
				{
					caughtType = (int)(new short[]
					{
						1324, //bananarang
						900, //Moon Stone
						1327 // Death Sickle
					})[Main.rand.Next(3)];
				}
				if(Main.eclipse && NPC.downedGolemBoss && Main.rand.Next(0, 15 * rarityMultiplier) == 0)
				{
					caughtType = (int)(new short[]
					{
						3107, //nail gun
						3249, // Deadly Sphere Staff
						3292 // The Eye of Cthulhu yoyo
					})[Main.rand.Next(3)];
				}
			}
		}

		public override void AnglerQuestReward(float quality, List<Item> rewardItems)
		{
			if (base.player.anglerQuestsFinished == 7)
			{
				base.player.QuickSpawnItem(2374, 1);
			}
			if (base.player.anglerQuestsFinished == 12)
			{
				base.player.QuickSpawnItem(2375, 1);
			}
			if (base.player.anglerQuestsFinished == 18)
			{
				base.player.QuickSpawnItem(2373, 1);
			}
			if (base.player.anglerQuestsFinished == 21)
			{
				base.player.QuickSpawnItem(3183, 1); //golden bug net
			}
			if (base.player.anglerQuestsFinished == 23)
			{
				base.player.QuickSpawnItem(2360, 1);
			}
			if (base.player.anglerQuestsFinished == 25)
			{
				base.player.QuickSpawnItem(2422, 1);
			}
			if (base.player.anglerQuestsFinished == 27)
			{
				base.player.QuickSpawnItem(3036, 1);
			}
			if (base.player.anglerQuestsFinished == 35)
			{
				base.player.QuickSpawnItem(3031, 1);
			}
			if (base.player.anglerQuestsFinished == 40)
			{
				base.player.QuickSpawnItem(3032, 1);
			}
			if (base.player.anglerQuestsFinished == 45 && Main.hardMode)
			{
				base.player.QuickSpawnItem(2494, 1);
			}
			if (base.player.anglerQuestsFinished == 100 && Main.hardMode)
			{
				base.player.QuickSpawnItem(base.mod.ItemType("RewardONE"), 1);
			}
			if (base.player.anglerQuestsFinished == 120 && Main.hardMode)
			{
				base.player.QuickSpawnItem(1613, 1);
			}
			if (base.player.anglerQuestsFinished == 200 && Main.hardMode)
			{
				base.player.QuickSpawnItem(base.mod.ItemType("RewardPot"), 1);
			}
		}
	}
}
