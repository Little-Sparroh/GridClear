using BepInEx;
using BepInEx.Logging;
using UnityEngine;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[BepInDependency("sparroh.uilibrary")]
[MycoMod(null, ModFlags.IsClientSide)]
public class SparrohPlugin : BaseUnityPlugin
{
    public const string PluginGUID = "sparroh.gridclear";
    public const string PluginName = "GridClear";
    public const string PluginVersion = "1.0.0";

    internal static ManualLogSource Logger;
    public static SparrohPlugin Instance;

    private void Awake()
    {
        Logger = base.Logger;
        Instance = this;

        GridClearMod.Initialize();

        Logger.LogInfo($"{PluginName} v{PluginVersion} loaded successfully.");
    }

    private void Update()
    {
        GridClearMod.UpdateUI();
    }

    private void OnDestroy()
    {
        GridClearMod.Cleanup();
    }
}
