using Terraria.ID;
using Terraria.ModLoader;

namespace Fishing3.Items.Weapons
{
	public class Fishingtron : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.MechanicsRod);

			item.fishingPole = 100;

			item.shoot = mod.ProjectileType("FishingtronProj");
			item.value = 10000;
			item.rare = 5;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Fishingtron");
      Tooltip.SetDefault("Advanced alien technology used to retrieve lost parts.");
    }



	}
}
