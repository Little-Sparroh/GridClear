using Sparroh.UI;

public static class GridClearUI
{
    private static bool _registered;

    public static void UpdateUI()
    {
        GearActionBar.Tick();

        if (!GearActionBar.IsGearMenuOpen())
            return;

        if (ConfigManager.EnableClearGrid == null || !ConfigManager.EnableClearGrid.Value)
        {
            if (_registered)
            {
                GearActionBar.Unregister("clear_grid");
                _registered = false;
            }

            return;
        }

        if (!_registered)
        {
            GearActionBar.Register(
                "clear_grid",
                "Clear Grid",
                GearActionBar.OrderClearGrid,
                () => UIDialog.Confirm(
                    "Clear Grid",
                    "Unequip all upgrades from this gear grid?",
                    GridClearLogic.TryClearFromOpenWindow),
                UIButtonStyle.Danger);
            _registered = true;
        }
    }

    public static void Cleanup()
    {
        GearActionBar.Unregister("clear_grid");
        _registered = false;
    }
}