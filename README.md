# CandyMaize
Simple maze game that is used to teach Unity to beginners. The project file contains a Demo Scene (used to show how the project works) and a Dev Scene (used to allow those participating to create their own maze).

## Setup
1. Install Unity version 2019.2.3f1, if not already installed.
2. Download and extract the project folder into the directory of your choice.
3. Launch Unity and use the Open button to navigate to the project folder.
4. Change the resolution to "Standalone 1024x768" in the Game display window
5. Double click the DemoScene under the Scenes folder for a preview of the mechanics of the maze.
6. Double click the DevScene to design your own maze by dragging in GameObjects from the "PREFABS" folder.
7. In the CollectibleFlashlight object, you must assign the flashlight object that is childed under the FPScontroller to FlashLightGO
8. Make sure to drag in a StartGate, an EndGate, Collectibles, some Corn Walls (acts as maze walls) and decorations!

This project runs in Unity version 2019.2.3f1

## Building the Project
To build the project, navigate to File -> Build Settings. If a new scene is created, make sure to add it to the build settings. Make sure that only the scene that you wish to have built is checkmarked. Finally, press build and enjoy! The game allows for a spacebar press to restart the level during the Win/Loss screens, and Escape can be pressed at any time to exit the project.

## Credits
Scripts written and some 3D assets created by Nick Lai (github.com/nickalai, lai137@mail.chapman.edu)

3D Art assets created by Kevin Horii (horii100@mail.chapman.edu)

Sound FX taken from the Unity Asset Store (https://assetstore.unity.com/packages/audio/sound-fx/horror-sfx-32834)
