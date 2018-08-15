using Terraria.ModLoader;

namespace Fishing3
{
	public class Fishing3 : Mod
	{
		public static Fishing3 Instance;

		public override void Load()
		{
			Instance = this;
		}

		public override void PostSetupContent()
		{
			var miscellaniaMod = ModLoader.GetMod("GoldensMisc");
			if(miscellaniaMod != null)
			{
				miscellaniaMod.Call("RegisterHookCatchFish", typeof(FishingPlayer), "AutofisherCatchFish");
			}
		}
	}
}
