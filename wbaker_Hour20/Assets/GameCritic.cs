/*

RESPONSES:

1. The game feels too easy. Sometimes the powerups spawn on the complete opposite side of the screen making it impossible to grab them even if you react right away, but otherwise it's trivial to collect powerups to the point where I had a surplus of 45 seconds left at one point which would only get increasingly bigger and make it impossible to lose with optimal play.

2. I would ramp up the difficulty over time so that the powerups get faster and faster, and making the obstacles bigger as well because they're so easy to dodge I'd never think of using the phase ability.

3. It would be more appealing if the graphics were a bit more refined, because watching the same run animation looks a little bit cheap, and there's not really a background either which makes it look a bit boring.

4. It's fun to run around and collect power-ups and watch the timer tick up.

5. Since the difficulty never changes or ramps up, and since there's nothing new other than the two existing prefabs, it starts to get dull after a while because it's just the same thing over and over with no innovations.

CHANGES:

I changed the obstacle prefab to look like a lightning cloud by taking 5 spheres and mashing them together, then adding two lightning bolts below it (each composed of two boxes), then I added textures to both the clouds and lightning, with the sources for them listed below.

Storm Cloud Texture: https://www.dreamstime.com/dramatic-storm-clouds-background-texture-dramatic-storm-clouds-background-texture-image152348980
Lightning Bolt Texture: https://www.dreamstime.com/fiery-lightning-bolts-background-texture-fiery-lightning-bolts-background-texture-image364835171

I also changed the shape of the powerup prefab to be a capsule, and added an animation to it so it changes between different colors, and for the particles I changed it to look grean and changed the shape and rotation of the particles to go up and down in a collumn so they confined within the bounds of the capusle.

 */