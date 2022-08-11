# Nova UI Controls Sample

A set of standalone UI controls (scripts and prefabs) similar to Unity's default/built-in UI controls, including a button, toggle, slider, and dropdown.

https://user-images.githubusercontent.com/8591310/184214061-152f026f-6604-4fa3-b49f-454f7e8de72a.mp4

While the UI controls in this project serve as simple and basic controls which can easily be dropped into a project as a fast/no-code path for getting up and running, they are not meant to be all-encompassing solutions for every project out-of-the-box. However, they can be easily re-styled, extended, or modified to better suit specific scenarios.

For a more dynamic, scalable, and data-bound implementation of similar UI controls, see the [MobileSettingsSample](https://github.com/NovaUI-Unity/MobileSettingsSample).

## Setup

This sample does not include Nova, which must be imported before the sample can be used. After cloning the repo:

1. Open the project in Unity. The project will have errors due to the missing Nova assets, so when prompted by Unity either open the project in Safe Mode or select `Ignore`.
1. Import the Nova asset into the project via the Package Manager.
    - When selecting the files to import, be sure to deselect the Nova settings (`Nova/Resources/NovaSettings.asset`) as they are already included and configured for the sample.

## Script Highlights

Each control type has two scripts associated with it:
- A class inheriting from [ItemVisuals](https://novaui.io/manual/ItemView.html#itemvisuals) in the [Visuals](Assets/Scripts/Controls/Visuals) folder
- A component providing configuration options and Unity Events in the [Components](Assets/Scripts/Controls/Components) folder

## Scenes

- `Scenes/UIControls`
