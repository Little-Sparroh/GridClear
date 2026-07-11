# GridClear

A BepInEx mod for MycoPunk that adds a **Clear Grid** button to the gear upgrade menu, letting you unequip every upgrade from the hex grid in one click.

## Features

- **Clear Grid button** — Appears in the bottom-left of the screen when a gear details or Ouro gear window is open
- **Boundary Incursion safe order** — Unequips Boundary Incursion upgrades last for better compatibility with grid expansion

## Getting Started

### Dependencies

* MycoPunk (base game)
* [BepInEx](https://github.com/BepInEx/BepInEx) - Version 5.4.2403 or compatible

### Installing

**Via Thunderstore (Recommended)**:
1. Download and install via Thunderstore Mod Manager
2. The mod will be automatically installed to the correct directory

**Manual Installation**:
1. Place `GridClear.dll` in your `<MycoPunk Directory>/BepInEx/plugins/` folder

### Usage

1. Open a gear's upgrade/details window
2. Click the **Clear Grid** button in the bottom-left corner
3. All equipped upgrades are unequipped from the hex grid

No configuration is required.

## Building

```bash
dotnet build --configuration Release
```

## Authors

- Sparroh

## License

This project is licensed under the MIT License - see the LICENSE file for details
