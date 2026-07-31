# GridClear

A BepInEx mod for Mycopunk that adds a **Clear Grid** button to the gear upgrade menu, letting you unequip every upgrade
from the hex grid in one click.

## Features

- **Clear Grid button** — Appears on the gear action bar when a gear details or Ouro gear window is open
- **Confirmation dialog** — Asks before unequipping so you don't clear by accident
- **Boundary Incursion safe order** — Unequips Boundary Incursion upgrades last for better compatibility with grid
  expansion
- **Configurable** — Toggle the button on/off via BepInEx config

## Getting Started

### Dependencies

- Mycopunk (base game)
- [BepInEx](https://github.com/BepInEx/BepInEx) — Version 5.4.2403 or compatible
- [SparrohUILib](https://thunderstore.io/c/mycopunk/p/Sparroh/SparrohUILib/) — Required for the gear action bar and
  dialogs

### Installing

**Via Thunderstore (Recommended)**

1. Download and install via a Thunderstore mod manager
2. Dependencies (including SparrohUILib) are installed automatically

**Manual Installation**

1. Install SparrohUILib if it is not already present
2. Place `GridClear.dll` in your `<Mycopunk Directory>/BepInEx/plugins/` folder

### Usage

1. Open a gear's upgrade/details window
2. Click the **Clear Grid** button on the gear action bar
3. Confirm in the dialog
4. All equipped upgrades are unequipped from the hex grid

### Configuration

Edit `BepInEx/config/sparroh.gridclear.cfg` (created on first launch), or change settings in-game if you use a config
menu. Changes on disk are picked up automatically.

| Section | Key               | Default | Description                                       |
|---------|-------------------|---------|---------------------------------------------------|
| General | Enable Clear Grid | `true`  | Show the Clear Grid button on the gear action bar |

## Building

```bash
dotnet build --configuration Release
```

## Authors

- Sparroh

## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.
