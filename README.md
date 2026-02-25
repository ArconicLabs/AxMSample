# AxMSample

Unreal Engine 5.7 sample project demonstrating the [AnimusExMachina](https://github.com/ArconicLabs/AnimusExMachina) AI StateTree plugin.

## Setup

```bash
git clone --recurse-submodules https://github.com/ArconicLabs/AxMSample.git
```

Open `AxMSample.uproject` with Unreal Engine 5.7.

## AxM Integration

The `Content/AxMSample/` directory contains a test level and NPC blueprint demonstrating the plugin's core loop:

- **Lvl_AxMSample** — Test level with NavMesh for AI navigation
- **BP_AxM_SampleNPC** — NPC character using the AxM AI Controller

Press Play and walk toward the NPC to see the full Patrol → Pursue → Engage → Patrol cycle.

## Game Variants

The project also includes three standalone game variants for reference:

- **Combat** — Melee combat with AI enemies using StateTree behaviors
- **Platforming** — Platformer with movement mechanics
- **SideScrolling** — Side-scrolling gameplay with NPC interactions

## Project Structure

```
Source/
├── AxMSample/                # Shared base classes (character, input)
├── Variant_Combat/           # Combat variant (AI, animation, gameplay, UI)
├── Variant_Platforming/      # Platforming variant
└── Variant_SideScrolling/    # Side-scrolling variant (AI, gameplay, UI)
Content/
├── AxMSample/                # AxM test level and NPC blueprints
├── Characters/               # Shared character assets (mannequin, anims)
└── ThirdPerson/              # Third person template content
Plugins/
└── AnimusExMachina/          # AI StateTree plugin (submodule)
```

## License

Apache 2.0 — see [LICENSE](LICENSE) for details.
