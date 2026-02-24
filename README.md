# AxMSample

Unreal Engine 5.7 sample project demonstrating the [AnimusExMachina](https://github.com/ArconicLabs/AnimusExMachina) AI StateTree plugin.

Includes three game variants:

- **Combat** — melee combat with AI enemies using StateTree behaviors
- **Platforming** — platformer with movement mechanics
- **SideScrolling** — side-scrolling gameplay with NPC interactions

## Setup

```
git clone --recurse-submodules https://github.com/ArconicLabs/AxMSample.git
```

Open `AxMSample.uproject` with Unreal Engine 5.7.

## Project Structure

```
Source/
├── AxMSample/              # Shared base classes
├── Variant_Combat/         # Combat variant (AI, animation, gameplay, UI)
├── Variant_Platforming/    # Platforming variant
└── Variant_SideScrolling/  # Side-scrolling variant (AI, gameplay, UI)
Plugins/
└── AnimusExMachina/        # AI StateTree plugin (submodule)
```

## License

Apache 2.0 — see [LICENSE](LICENSE) for details.
