:: Version 1.0 ::

2D Sprite - Witch Girl is a free to use sprite of a little witch girl that can run and jump.

OVERVIEW:
	-"Animations" Folder
		-Where the .anim files (Idle.anim, Run.anim, Jump.anim) are placed.
		-The Character Controller for the sprite (WitchGirl.controller) is located here.
	-"Documentation" Folder
		-Where the Readme file is located. You are currently reading this.
	-"Prefab" Folder
		-Where the Witch Girl prefab is placed.
	-"Scene" Folder
		-You can find the demo scene in this folder.
		-Here, you can see the animations of the sprite loop when you hit 'play'.
	-"Sprites" Folder
		-Subfolders: Idle, Run, Jump
		-Images for the sprite are located here. Idle images are in the Idle folder, and so on.
		-Images are named starting at 00. For example, the first image for the Idle animation
			is called 'WitchGirl_Idle_00'

***PLEASE NOTE: 
There is no script on the sprite. This will need to be scripted by you, the user, for the sprite to move. 

PROCESS OF CREATING THE SPRITE AND THE .ANIMS:
1. In the Hierachy, create a 2D Object > Sprite
2. Rename this sprite to what you want ('WitchGirl' for these instructions)
3. So far the sprite image empty. Go to Idle folder (Assets > Sprites > Idle). Drag the WitchGirl_Idle_00 to the sprite section in the Sprite Renderer. 
4. With the WitchGirl selected, go to the Animation Window (Window > Animation).
5. Click 'Create' in the Animation window.
6. Name the Idle animation what you want (For these instructions, it will be 'Idle' or Idle.anim).
7. Go to Assets > Sprites > Idle. 
8. Select all of the sprites in the folder. 
9. Drag these onto the timeline in the animation window.
10. Change the 'samples' property from 60 to 30.
11. 'Idle' should be completed.
12. In the Animation Window, click on the Idle title underneath the play and record button.
13. Click "Create New Clip..."
14. Follow steps 7-11 again to create the 'Run' and 'Jump' animations.