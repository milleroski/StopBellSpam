using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using StopBellSpam.Patches;

namespace StopBellSpam
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class StopBellSpamPlugin : BaseUnityPlugin
    {

        private readonly Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        public static StopBellSpamPlugin Instance;

        internal ManualLogSource logger;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            logger = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.PLUGIN_GUID);
            logger.LogInfo("StopBellSpam has loaded successfully!");

            harmony.PatchAll(typeof(StopBellSpamPlugin));
            harmony.PatchAll(typeof(DepositItemsDeskPatch));
        }
    }
}