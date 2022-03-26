# **New-Game-Template**

**Basic starting template for skipping the first hour of a new unity project**
- Unity Version 2021.1.22f1
- Platform: PC, Mac & Linux Standalone
- 3D

**What isn't included**
- No player character or controller
- No prefabs, sprites/textuers, animations, shaders or audio files
- No mechanics or gameplay

## **Scripts**

Public instance game manager, with public reference to minor common managers

**Audio** - Volume pref

**Progress** - Level

**SaveLoad** - Basic Xml serialization and a save data delete

**Scene** - Scene loader

## Scenes

All scenes contain scaling canvases, a main camera (Solid Colour Clear Flags) and no light source

**Scenes**

- Startup: contains the DontDestroyOnLoad gameManager, loads Prefs then Title screen
- TitleScreen: empty
- Ending: empty
- GameOver: empty
- Level_01: empty
- Secret_01: empty

## Packages
- Addressables                    1.18.19
- Core RP Library                 11.0.0
- Input System                    1.0.2
- JetBrains Rider Editor          3.0.13
- Scriptable Build Pipeline       1.19.2
- Shader Graph                    11.0.0
- Test Framework                  1.1.31
- TextMeshPro                     3.0.6
- Timeline                        1.5.7
- Unity UI                        1.0.0
- Version Control                 1.9.0
- Visual Scripting                1.6.1
- Visual Studio Core Editor       1.2.5
- Visual Studio Editor            2.0.14
