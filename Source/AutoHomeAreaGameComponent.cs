using RimWorld;
using Verse;

namespace AutoHomeAreaOffByDefault
{
    // Writes PlaySettings.autoHomeArea once, when a new colony starts.
    public class AutoHomeAreaGameComponent : GameComponent
    {
        public AutoHomeAreaGameComponent(Game game)
        {
        }

        public override void StartedNewGame()
        {
            PlaySettings playSettings = Current.Game?.playSettings;
            if (playSettings != null)
            {
                playSettings.autoHomeArea = false;
            }
        }
    }
}
