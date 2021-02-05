using Terraria.ID;
using Terraria.ModLoader;

namespace BlackCloverAstaworld.Items
{
	public class Dispelda : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Dispelda"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Epée rouillé capable d'annihiller toute forme de Magie");
		}

		public override void SetDefaults() 
		{
			item.damage = 75;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}