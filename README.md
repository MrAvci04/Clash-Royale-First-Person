# Clash-Royale-First-Person

Week 1 : 10 hours

	- comparing between projects and choosing unity game.
	- seeking ideas which game to do.
	
________________________________________________________________________________________________

Week 2 : 9 hours

	- Learning C# from : https://youtube.com/playlist?list=PLltZRmsFXWnIfLM0BKgJNZYVnvCDZNAh_

________________________________________________________________________________________________

Week 3 : 10 hours including leetcode questions

	- Practicing C# in Visual Studio

________________________________________________________________________________________________

Week 4 : 10 hours

	- Fast unity 2D Basics , from : https://youtube.com/playlist?list=PLltZRmsFXWnLp98IIM1CISQYWowq87YSp

________________________________________________________________________________________________

Week 5 : 8 hours

	-5 hours : Learning Basics of 3D Unity from : https://youtube.com/playlist?list=PLltZRmsFXWnKk5F3_ltKWKq6lZLveotIF
	
	-3 hours : Downloading Unity and Start Practice the tools and how to use it
	
			Ctrl + shift + E => camera

			Ctrl + d => duplicate object

			F => focus the camera

			Plane 3d object => floor or ground

			Press ctrl + p to play the game

			Rigibody => physics properties

			rigidbody : Mass : the weight of the object Drag : used to slow down an object

			Colliders تحديد نقاط التصادم Default : Mesh collider.

			Layers and collision matrix

			Animations :

			Animator component Key frames

________________________________________________________________________________________________

Week 6 : 6 hours

	-3 hours : Building the Basic of My Game , Plane , Casttles , Capsules and Skiliton , With Basic Movements ( forward , right , left , backward )
	
	-2 hours : Importing , Setting Up The InputSystem (was an error).
	
	-30 minutes : Importing the two buttles.

	-30 minutes : Adding the basic colliders.

________________________________________________________________________________________________

Week 7 : 5 hours

	-2 hours:  Learn new things :

			UI: Canvas => show the ui all time.
			Lightining: Sky box => sky Light map.
			Audio: Audio Lestener => mostly on the main camera.
			How to Pause the game (story …. ->now multiplayer): Time scale = 0 and connect it to canvas.
	
	-3 hours : practicing thing that i learned from week 1 - 7

________________________________________________________________________________________________

Week 8 : 7 hours

	-3 hours: Unity Math: Vectors Overview Operations On Vectors Normalization Linear Interpolation Dot Product Cross Product Angles Between Vectors Sine Waves Rotations

	-2 hours: Connecting Visual studio to unity as an external editor (after a lot of searching, At the beginning I thought that I Am writing wrong codes ).

	-1 hour: Linking the cameras to Players.

	-30 minutes: Change Player Movement script.


________________________________________________________________________________________________

Week 9 : 7.25 hours

	-4 hours: Restoring Files After my Computer Crashed , downloading unity , visual studio , github desktop , path changing ...

	-1.5 hour: Adding Two Players , With Controllers , rigidbody + freezing position , colliders (Red Player , Blue Player).

	-1 hour: Updating the plane , new corners with appropriate position , rotations , scaling , colliders.

	-30 minutes: Splitting the screen to 3 Cameras (RPlayer , Main cam , BPlayer) after watching some videos.

	-15 minutes: fixing Movement bugs.

________________________________________________________________________________________________

Week 10 : 5 hours

	-1 hour: Adding 1 Coin , delete on collision.

	-45 minutes: Colliding Event , print the player name on collision (after watching some videos).

	-45 minutes: learn how to spawn objects, (for coins and cards).

	-45 minutes: 2 types of coins , if blue player touches red coin he will lose health (and the samething for red player).

	-30 minutes: adding health feature for players with damage functions.
	
	-20 minutes: every player have wallet ( coins | with related functions : add , lose).

	-20 minutes: adding heart(to increase health).
	
	-30 minutes: random spawn coins and health in random positions.

________________________________________________________________________________________________

Week 11 : 8 hours

	-30 minutes: change cameras according to characters.
	
	-30 minutes: spawn cards and collect (add them to static list).

	-30 minutes: characters movement after putting the card.
	
	-45 minutes: download new assets.
	
	-2 hours: Restricting the Walking area.

	-1 hour: stop spawning coins after # second (after watching some videos).
	
	-2 hours: health text canvas (after some problems , i discovered that i have to import text asset)
	
	-30 minutes: adding font asset and make canvas for the middle camera(center).

________________________________________________________________________________________________

Week 12 : 8 hours
	
	-1 hour: connect canvas with health , coins (for the two players).

	-30 minutes: health damage when player touches the center line. 

	-15 minutes: hide the lines after spawning all the coins.

	-1.5 hour: adding sword , code it. (show , hide , hit and rotate ). 

	-15 minutes: use tags.

	-30 minutes: Fix Sword Damage.

	-45 minutes: adding fireball gun with comparing the best way to do.

	-2 hours shoot bullets , and explostion on colliding.

	-30 minutes looking for explostion asset.

	-30 minutes bullet damage.

________________________________________________________________________________________________

Week 13 : 9.5 hours
	
	-20 minutes: Fix explosion position.
	-17 minutes: Add PayCoin() function for the players , and updating the shooting function so if you don't have enough coins you can't shoot.
	-18 minutes: Lose Coin After Shoot.
	-25 minutes: fix damage bug in the shooting function (when bullet touches the enemie's bullet).
	-25 minuets: switch weapons (click : 1,2 ,q or 7,8,u).
 	-45 minutes: adding cannons
	-35 minutes: shooting with cannon
	-15 minuets: add cannons to switchable weapons (click 3 or 9)
	-25 minutes: adding fence , with new asset every player can rebuild his fence by paying 5 coins and clicking 4 or 0.
	-35 minutes: enhancing materials.
	-1 hour: testing and rendereing the game.
	-1 hour: adding hours report.
	-35 minutes: Damage Casttle from bullets and Destroy all items for the player when it casstle health <=0.
	-15 minutes: Same thing but from Sword instead of bullets.
	-15 minutes: Fix Colliding bugs.
	-35 minutes: Show Casstle health on Canvas.
	-30 minutes: enhancing the MidCam Canvas.
	-1 hour: watching videos about health canvas (like the bar).

________________________________________________________________________________________________

Week 14: 8.5 hours

	-1 hour: trying to make health bar for red player , the problem was in the image (i dont know what) but the solution was to change the textture type to 2D and UI instead of Default.
	-1 hour: making healthbar for RPlayer and BPlayer.
	-1 hour: building RPlayer controlsCanvas.
	-1 hour: Building it for BPlayer , and Coding the script -> 'buttons' : will see where you press {W,A,S,D,I,J,K,L}.
	-20 minutes: adding {Q,E,U,O} to the buttons and Canvas (BPLayer shoots with E , RPlayr with O .. BPlayer hidesthe weapons with Q , RPlayer with U}.
	-2 hours : adding cards to canvas like Clash Royale : {Skeleton , Wizard , Cannon , Fence(new)}.
	- 30 minutes: looking for and importing hand assets (for the wizard , insread of the current capsule).
	- 10 minutes: Swords new material
	- 30 minutes: Swithcing between the new Hand with the old FireballGun , now we have a Wizard Card.
	-30 minutes: FireExplosion(new) for the fireBall that Wizards shoots.

________________________________________________________________________________________________

Next Missions :
	- adding health feature for the casstle , and it increases with the time (like real clash royal) .

	- choose cards and switch between them.
	- search for more ideas.
	- sword : animate instead of rotate
