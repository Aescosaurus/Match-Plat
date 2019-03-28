# Match Plat Design
## Intro
- **Project Overview:** Match Plat is a different kind of puzzle platformer game.  The main gimmick is a mix between a match 3 and platformer game, where the player will play through a match 3 game in tandem with the platformer aspect.  The game's levels will be constructed in the match 3 phase where tiles such as sky, coin, grass, stone, or enemy will be matched together to construct the level.
- **Example Gameplay:** Player boots up the game and goes into endless mode.  In this mode, the player must quickly make matches to be able to navigate the player away from the endlessly encroaching side of the screen.  When finished the player tries campaign mode.  In this part of the game the player starts by building up the level by making matches of 3 as quickly as possible; afterwards platforming and defeating enemies and collecting coins.
- **Rough Schedule Outline:**
	* End of April: Minimum viable product started, platforming works at a basic level and we have a good plan on how to tackle the match 3 component and integrate it with the platforming in a fun way.
	* End of May: Platforming and match 3 integrated, start planning out rest of the summer and finding out what to do with menus, alternate game modes (campaign/endless), and anything else we come up with.
	* Early August: Finish up plans from May, plan out the rest of the year and plan the future of the game.
## Gameplay Mechanics
- **Game Rules:**
	* Matching 3 tiles together will clear those touching tiles of the same type.
	* Empty tiles are filled with the above tile; empty tiles at the top receive a (possibly weighted) random tile type.
	* Matching four tiles in a row will apply some special effect or bonus (maybe even spawn a powerup for the player to collect ingame).
	* Matching five tiles in a row will give an even greater bonus than four.
	* The match 3 part of the game has a timer, motivating the player to make many matches as quickly as possible to maximize platformer character's energy.
	* While platforming player cannot move offscreen, this counts as losing the level.
	* Character can run left and right, and jump 1 tile high.
	* Platformer person has limited strength, and can only run so far before collapsing.
	* Performing additional matches in the match 3 will give the player more power to move around for longer.
	* The level is considered completed when the player attains sufficient points.
	* The player gains points in the level by destroying enemies or collecting coins.
- **How Objects Interact:**
	* Player is affected by gravity, and will fall until a solid platform catches them.
	* Player collides with dirt, grass, and stone tiles, while freely moving through sky and maybe cloud (we might want bouncy tiles in the future, or water, etc).
	* Player can attack enemies in some way (sword, bow, stomp on them??) and destroy them for points.
	* Player can collect coins for additional points.
	* Enemies are also affected by gravity.
	* Enemies will hop around, trying to get towards the player to hit them.
	* Coins are not affected by gravity, and stay in the spot they were in the match 3.
	* Static tile types such as grass, stone, cloud, and sky retain their position throughout the platformer level and do not move (other than during the match 3).
- **Activities the Player Performs:**
- **Game Structure:**
- **User Interface:**
