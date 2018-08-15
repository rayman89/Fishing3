using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace Fishing3.Mounts
{
	public class MechaFishron : ModMountData
	{
		public override void SetDefaults()
		{
			base.mountData.buff = base.mod.BuffType("MechaFishron");
			base.mountData.flightTimeMax = 999;
			base.mountData.swimSpeed = 14f;
			base.mountData.heightBoost = 20;
			base.mountData.fallDamage = 0f;
			base.mountData.acceleration = 0.5f;
			base.mountData.jumpSpeed = 8f;
			base.mountData.spawnDust = 11;
			base.mountData.heightBoost = 20;
			mountData.dashSpeed = 8f;
			mountData.runSpeed = 14f;
			mountData.fatigueMax = 0;
			mountData.fallDamage = 0f;
			base.mountData.runSpeed = 15f;
			base.mountData.dashSpeed = 15f;
			base.mountData.jumpHeight = 12;
			base.mountData.blockExtraJumps = true;
			base.mountData.totalFrames = 4;
			base.mountData.constantJump = true;
			int[] array = new int[base.mountData.totalFrames];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 20;
			}
			base.mountData.playerYOffsets = array;
			base.mountData.xOffset = 13;
			base.mountData.bodyFrame = 3;
			base.mountData.yOffset = -12;
			base.mountData.playerHeadOffset = 22;
			base.mountData.standingFrameCount = 4;
			base.mountData.standingFrameDelay = 12;
			base.mountData.standingFrameStart = 0;
			base.mountData.runningFrameCount = 4;
			base.mountData.runningFrameDelay = 12;
			base.mountData.runningFrameStart = 0;
			base.mountData.flyingFrameCount = 0;
			base.mountData.flyingFrameDelay = 0;
			base.mountData.flyingFrameStart = 0;
			base.mountData.inAirFrameCount = 1;
			base.mountData.inAirFrameDelay = 12;
			base.mountData.inAirFrameStart = 0;
			base.mountData.idleFrameCount = 4;
			base.mountData.idleFrameDelay = 12;
			base.mountData.idleFrameStart = 0;
			base.mountData.idleFrameLoop = true;
			base.mountData.swimFrameCount = base.mountData.inAirFrameCount;
			base.mountData.swimFrameDelay = base.mountData.inAirFrameDelay;
			base.mountData.swimFrameStart = base.mountData.inAirFrameStart;
			if (Main.netMode != 2)
			{
				base.mountData.textureWidth = base.mountData.backTexture.Width + 20;
				base.mountData.textureHeight = base.mountData.backTexture.Height;
			}
		}

		public override void UpdateEffects(Player player)
		{
			if (Math.Abs(player.velocity.X) > 4f)
			{
				Rectangle rect = player.getRect();
				Dust.NewDust(new Vector2((float)rect.X, (float)rect.Y), rect.Width, rect.Height, base.mod.DustType("Smoke"), 0f, 0f, 0, default(Color), 1f);
			}
		}
	}
}
