# pgCandyMaize
10/26 Halloween themed workshop Unity project file for Chapman University's Panther Games Club. Simple maze game that is used to teach Unity to beginners. Project file contains a Demo Scene (used to show how the project works) and a Dev Scene (used to allow those participating to create their own maze).

# Setup
1. Download and extract the project folder into the directory of your choice.
2. Launch Unity and use the Open button to navigate to the project folder.
3. Change the resolution to "Standalone 1024x768"
4. Double click the DemoScene under the Scenes folder for a preview of the mechanics of the maze.
5. Double click the DevScene to design your own maze by dragging in GameObjects from the "PREFABS" folder.
6. In the CollectibleFlashlight object, you must assign the flashlight object that is childed under the FPScontroller to FlashLightGO
7. Make sure to drag in a StartGate, an EndGate, and Collectibles

This project was developed in Unity 2017.1.1f1

# Building the Project
To build the project, navigate to File -> Build Settings. If a new scene is created, make sure to add it to the build settings. Make sure that only the scene that you wish to have built is checkmarked. Finally, press build and enjoy! The game allows for a spacebar press to restart the level during the Win/Loss screens, and Escape can be pressed at any time to exit the project.

# Credits
Scripts written by Nick Lai (lai137@mail.chapman.edu)

3D Art assets created by Kevin Horii (horii100@mail.chapman.edu)

Sound FX taken from the Unity Asset Store (https://assetstore.unity.com/packages/audio/sound-fx/horror-sfx-32834)
