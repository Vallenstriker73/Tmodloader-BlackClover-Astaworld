using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace BlackCloverAstaworld.Items.Bosses
{
    public class yunostar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Collier de yuno");
            Tooltip.SetDefault("Invoque le demon Zagreb");
        }

        public override void SetDefaults()
        {
            item.width = 80;
            item.height = 93;
            item.maxStack = 20;
            item.rare = 10;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            // We make sure that the boss doesn't already exist
            return !NPC.AnyNPCs(mod.NPCType("Zagred"));
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position);
            if (Main.netMode != 1)
            {
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Zagred"));
            }
            return true;
        }
    }
}