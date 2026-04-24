/*
Improving The Game Questions:

1. The game feels too easy. If you just stand still it feels like most of the time the balls will just go into the goals by themselves with no input needed.

2. What might make the game harder is if the balls eventually lost momentum and slowed down so you would be forced to interact with them to make them bounce again.

3.

4. It is fun watching the balls bounce around, but moving around feels a little bit sluggish.


Enhancements:

1. I added a timer and added some GUI elements to show the current time as the game is running and the final run time once the game is beaten.

2. I added a yellow Chaos goal to knock all of the chaos balls into. I updated the GameManager to check that the chaos goal is solved before ending the game, and I also added a "numLeft" variable to the GoalScript that decreases whenever a ball hits the goal and that deletes the goal when it reaches zero, which was neccesary since there are 5 chaos balls and I didn't want the goal to dissapear too early after clearing just one ball

3. I changed the bumper to be a long stretched-out capsule, and I also changed the default Capsule Collider with a Box Collider to prevents the balls from phasing through the capsule and not collide at all.

4. I changed the footsteps sound effects to "footsteps_water_light_005.wav" and "footsteps_water_light_004.wav" to give them a more wet/watery sound to fit with the water floor.
*/