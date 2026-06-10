\# Valve-Style Lighting System for Unity URP



A lightweight, high-performance lighting system for Unity's Universal Render Pipeline (URP). It brings the classic, cinematic \*\*Valve-style string-based light patterns\*\* into modern projects while maintaining strict performance optimizations and frame-rate independence.



\---



\## 🚀 Features



\* \*\*Valve Light Styles\*\*: Easily control light behaviors using simple text strings (`a` = pitch black, `z` = max brightness).

\* \*\*Smart Separation\*\*: Automatically isolates custom blinking lights from regular environmental lights.



\---



\## 🛠️ How It Works



The system consists of two main components working together:



\### 1. `LightSwitcher`

Acts as a room-level or global light controller. It scans all child objects upon game start.

\* Dynamically filters out any object that contains a `BlinkingLight` component.

\* Directs the baseline brightness of all \*\*regular\*\* lights without overriding the animated ones.



\### 2. `BlinkingLight`

Attached to specific light sources that require customized behaviors (flickering, pulsing, Morse code, etc.).

\* Syncs with the `LightSwitcher` to read the current maximum allowed intensity.

\* Animates its own `Light` component locally based on a customizable text string pattern.



\---



\## 📋 Installation



1\. Copy the scripts into your Unity project (e.g., inside an `Assets/LightScripts/` folder).

2\. Ensure your project is using the \*\*Universal Render Pipeline (URP)\*\*.



\---



\## 🎨 Preset Patterns Cheat Sheet



Paste these strings into the `Blink Pattern` field in the Unity Inspector to instantly achieve classic horror and sci-fi tropes:



| Name | Pattern String | Recommended Speed | Atmosphere |

| :--- | :--- | :--- | :--- |

| \*\*Classic Flicker\*\* | `mmnnmmehfeoomm` | `15` | Default broken bulb (Half-Life style) |

| \*\*Matrix Glitch\*\* | `zzzzzzzzzzzyzyzyzyzaazzzzzzzzzz` | `20` | Digital or magical sci-fi error |

| \*\*Heartbeat\*\* | `zaazaaaaaaaazaazaaaaaaaa` | `15` | Tense horror pacing |

| \*\*Ignition Failure\*\* | `azaazzaaaazzzaaaaaazzzzzzzzzzzz` | `15` | Neon sign/generator startup struggles |

| \*\*S.O.S Morse Code\*\* | `zazazaaazzzazzzazzzaaazazazaaaaaaa` | `10` | Emergency distress signal |

| \*\*Strobe light\*\* | `az` | `25` | Panic rooms or high-alert warnings |



\---



\## ⚙️ Configuration Setup



1\. Create an empty GameObject on your scene and name it `LightingController`.

2\. Attach the `LightSwitcher` component to it.

3\. Place all your room lights as \*\*children objects\*\* underneath this `LightingController`.

4\. On any specific child light that you want to animate, attach the `BlinkingLight` component.

5\. In the Unity Inspector, drag and drop the parent `LightingController` into the \*\*Switcher\*\* reference field of the child's `BlinkingLight` component.



