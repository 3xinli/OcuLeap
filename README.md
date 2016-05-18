# OcuLeap

Project:
The goal of our project is to realize a game that we can see it using the oculus (virtual reality) and using leap motion to control the games.
http://devpost.com/software/oculeap-a-new-way-to-explore

Instructions:

1. Download Oculus Runtime for OS X      
https://developer.oculus.com/downloads/pc/0.5.0.1-beta/Oculus_Runtime_for_OS_X/
If we come across some errors, please visit 
https://www.reddit.com/r/oculus/comments/2dbxve/041_with_dk2_on_a_mac_incompatible_resolution/
to check how to configure mac resolution.

2. Make leap work in mac
https://developer.leapmotion.com/v2

3. Combination of both: briefly, put leap motion assets (downloaded from official website directly) in the project environment edited in unity. In unity, edit -> project settings -> player -> other settings to enable “VR supported”.
For validation, try this example first
https://github.com/leapmotion/VRIntro/blob/master/Executables/VRIntro-osx.zip and see if the environment works.

4. Unity manual: http://docs.unity3d.com/Manual/UnityManual.html
Opensource angry bird game built in Unity game engine: https://github.com/dgkanatsios/AngryBirdsClone

Contributions:
Interactive, gesture-controlled 3D game using Leap and Oculus
a. Integrated Leap and Oculus environments setting and made interactive, gesture-controlled 3D project work. (in mac, version matching is a difficulty!)
b. Modified GameManager.cs and Slingshot.cs with leap gestures. Created text3d.cs with 3D text game instructions shown in Oculus

Others:
Example: https://www.youtube.com/watch?v=Pdnik0gA09g
Leap quick setup manual: https://developer.leapmotion.com/unity#quick-setup
Different versions of assets: https://github.com/leapmotion/LeapMotionCoreAssets/releases?after=prerelease-v2.4.0


