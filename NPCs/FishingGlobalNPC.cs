using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.NPCs
{
	public class FishingGlobalNPC : GlobalNPC
	{


public override void NPCLoot(NPC npc)
		{
			if (npc.type == 395 && Main.rand.Next(0, 10) == 0) // 395 es martian saucer core
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Fishingtron"), 1);
			}
		}
	}
}