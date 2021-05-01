# PhatLootLevelDesignTest - Dan's Fork
This is my fork of the level design test with my scenes implemented.

To view the environments with all particle and post processing effects active, play the scene.
In play mode, press SPACE to switch between camera points in the scene, and press SHIFT to switch scenes.
I would also recommend running play mode at 1920x1080 for proper depth of field levels.

Both of these environments have issues with scale due to the limited world space available on the blockout and the amount of content I tried to fit in each scene.
I will say that these scenes take place in a gnome inhabited world to get around this, however I do understand the importance of consistent scale in a game world, and doing this project again, I would more closely match the environment concept to the size of the available space.

![Scene 1 Image](/TestLevelDesign/Scene1.png?raw=true "Scene 1 Image")
The first scene takes place in a gloomy swamp, hosting a cursed axe that poisons the air and water around it.
This scene has been made using megascans assets and a swamp tree asset pack.
This scene uses a more realistic style, with photoscanned models and textures.
Performance in this scene could be easily increased by making use of LOD switching on Megascans models, as only the swamp trees currently use LOD switching, and megascans assets can be downloaded with multiple LOD levels.
Another simple increase in performance could come from switching out the CPU particle effect of the sun beam for an animated texture, as it is currently using an extremely unoptimised method to generate fading lines due to time constraints.

![Scene 2 Image](/TestLevelDesign/Scene2.png?raw=true "Scene 2 Image")
The second scene takes place high on a wind bitten mountain, littered with bones and sporting the corpse of an ancient dragon atop its peak.
A researcher has taken shelter in the cave below the peak to study the remains of the dragon and the magic it contains.
This scene is much simpler, and uses a modern lightweight style, similar to modern Nintendo titles. The level items scattered in the scene is kept light to emulate the constraints of creating and rendering a large number of scenes throughout an expansive game world. However as it stands, the path leading to the cave is currently too bare and could use more detail objects.
Performance and visual appeal in this scene could be greatly increased by creating or downloading a custom inverted cave model to use, rather than creating facades from multiple  rocks with a far too high polygon count.
Another increase could come from switching the CPU particle effect powering the snow for a GPU particle effect and creating a custom force area to prevent snow from entering the cave through the wall.
This scene makes heavy use of triplanar mapping to quickly blend all of the rocks in the scene together and add a coating of snow to the top faces.
