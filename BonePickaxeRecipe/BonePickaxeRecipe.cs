using Terraria.ModLoader;

namespace BonePickaxeRecipe
{
	public class BonePickaxeRecipe : Mod
	{
		public override void AddRecipes()
		{
			ModRecipe BPR = new ModRecipe(this);
			BPR.AddIngredient(ItemID.Bone, 10);
			BPR.AddIngredient(ItemID.Spike, 5);
			BPR.AddTile(TileID.Anvils);
			BPR.SetResult(ItemID.BonePickaxe);
			BPR.AddRecipe();
		}
	}
}