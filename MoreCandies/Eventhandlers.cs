using Exiled.API.Features;
using InventorySystem.Items.Usables.Scp330;

namespace MoreCandies
{
    internal class EventHandlers : Plugin<Config>
    {
        public static void OnTakingCandie(Exiled.Events.EventArgs.Scp330.InteractingScp330EventArgs ev)
        {
            if (Plugin.Instance.Config.MaxAmount < ev.UsageCount)
            {
                ev.ShouldSever = true;
            }
            else
            {
                ev.ShouldSever = false;
            }

        }
    }
}
