using BepInEx;
using BepInEx.Logging;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[BepInDependency("sparroh.uilibrary")]
[MycoMod(null, ModFlags.IsClientSide)]
public class GridClearPlugin : BaseUnityPlugin
{
    public const string PluginGUID = "sparroh.gridclear";
    public const string PluginName = "GridClear";
    public const string PluginVersion = "1.1.0";

    internal static ManualLogSource Logger;
    public static GridClearPlugin Instance;

    private void Awake()
    {
        Logger = base.Logger;
        Instance = this;

        ConfigManager.Initialize(Config, Logger);

        Logger.LogInfo($"{PluginName} v{PluginVersion} loaded successfully.");
    }

    private void Update()
    {
        ConfigManager.Tick();
        GridClearUI.UpdateUI();
    }

    private void OnDestroy()
    {
        GridClearUI.Cleanup();
        ConfigManager.Dispose();
    }
}