# Tank-Game
A survival tank game created in the Unity game engine using the C# programming language. Developed as part of the Westminster University Games Development Academy in April 2018

# Notable algorithms and Learnings:
## Object Pooling:
- I have learned how to implement Object pooling in Unity. A way to reduce the burden on the CPU when having to rapidly create and destroy GameObjects. A useful design pattern when dealing with projectile style bullets in games.
- Object Pooling works by pre-instantiating all object that you will need at a specific moment before gameplay. This removes the overhead of having to create new objects and destroy old objects at runtime.
- In Unity this is done by creating a set number of GameObjects before the game's runtime and simply activate or deactivate them when required. This can significantly improve performance especially when you require many copies of the same object active at a time. An example would be a turret that shoots 2 or more bullets a second and these bullets are actual physical objects in the world and not just tracers from a hitscan gun.

Link to Pool Manager: https://github.com/PatrykOwczarz/Tank-Game/blob/main/Tank%20game/Assets/Scripts/PoolManager.cs
Link to Pool class for interacting with manager: https://github.com/PatrykOwczarz/Tank-Game/blob/main/Tank%20game/Assets/Scripts/Pool.cs 

## Health Bar of tanks
- I was pleased how the health representation turned out in the end.
- The health bar was represented as an oval slider which was an overlay attached to the bottom of the tank facing upwards.
- The health value was updated in real time and the slider was adjusted based on a percentage based on 0 and the max health value set at the start of the game.
- The colour of health was based on current health value going from green at full health to red at low health.

Link to TankHealth.cs: https://github.com/PatrykOwczarz/Tank-Game/blob/main/Tank%20game/Assets/Scripts/TankHealth.cs
Link to Script for orientation of Health bar: https://github.com/PatrykOwczarz/Tank-Game/blob/main/Tank%20game/Assets/Scripts/UIDirectionControl.cs

# Areas of Improvement:
- Level design: The level design was an oversight as we wanted to make sure the game was functional before the end of the academy event. Having a more interesting level would lead to a more interesting gameplay loop.
- Animations: Currently the tank just instantly changes its facing direction which does not represetn how a tank would move in the real world. A huge improvement would be to smooth out the movement by actually making the tank rotate.
- AI: The AI was incredibly simple and hence the game does not really have any challenge. The AI follows the player and when it reaches a certain distance away it just stands still and shoots at the player. Making the tanks have some sort of random movements and predicting where the player is moving to shoot in front of them with a bit of variance would make this game more fun and challenging to play.
- Bullet Collision: Currently the enemy and player bullets can collide mid air, making it frustrating to try and defeat the enemy tanks given the current AI. I considered it a feature as you can "deflect" bullets mid air but implementing other ammo that would ignore collisions could be a good solution.

# Demo Video:
Demo: https://www.youtube.com/watch?v=-8v2ylwdyPk
