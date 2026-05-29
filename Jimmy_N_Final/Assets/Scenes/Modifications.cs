public class Modifications

{/*
    ░▒▓████████▓▒░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓██████▓▒░ ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ */




    /*  ================================================================
        CHAOS BALL
        ================================================================
        1 - directional light (colour, intensity, etc)
        modifications: Changed it to be lighter and changed the color to light blue to match the sky box.

        2 - fog
        modifications: 
    Added fog in this case as the sky box I used is a cube map there for the clouds do not exist. But I changed the density to 0.06 and the color to a grayish blue. I also changed the mode to be exponential

        3 - create & apply skybox and customise it (atmosphere thickness, sky tint, exposure, etc)
        modifications: I added a custom sky image, Changed the tint color to a dark green blue color, Lowered the exposure to 0.78.

    Image URL: https://opengameart.org/content/clear-sky-panoramic-texture

        CHAOS BALLS
        4 - convert a chaos ball into a prefab, and replace all of them in the scene with instances of that prefab
        [no record necessary]

        5 - add particle system to the chaos ball prefab and customise at least 3 parameters
        -All instances will update to include the particle system
        coloured balls
        parameter 1: Changed life time to 0.21
        parameter 2: Changed speed to 25.5
        parameter 3: Added a custom texture
    Ball Textures URLs: 
    1: https://freepbr.com/product/ice-field-pbr/
    2:https://freepbr.com/product/ice-field-pbr/
    3:https://freepbr.com/product/alien-slime-pbr/
    4:https://freepbr.com/product/yoga-mat-wavy/

        6 - convert a coloured ball into a prefab, create variants for each of the colours, and replace them in the scene
        -Don't forget to update the tags so that the game works
        [no record necessary]

        7 - apply at least 1 new texture while retaining the different colours
        (add source url or package name)
        texture source: https://freepbr.com/product/preschool-tile/
       
        GOALS
        8 - modify light components (colour, range, intensity, etc)
        modifications: I changed the color to a light blue to match the sky box and I just changed the light direction.

        WALL
        9 - convert each to complex objects comprised of 3 or more shapes
        -Try recreating them to be more interesting! castle walls, fences, pillars, etc
        [no record necessary]

        10 - use gameobject hierarchy to keep the wall prefab organised & apply at least 1 new texture
        (add source url or package name)
        texture source(Bumper): https://freepbr.com/product/old-worn-framed-wood-pbr-material/
         texture source(Wall):https://freepbr.com/product/muddy-scattered-brickwork1/
       
    - Little note: I theres 2 textures because I remade my bumpers on top of the walls.
    */
}
