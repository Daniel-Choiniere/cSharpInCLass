This is a simple DnD c# console game.

Task:
Using the rules of dnd...
    - make an attack 
    - determine if a player/enemy lands a hit (including hits and misses) then determine the damage done
To determine a hit roll a d20 include any modifiers
    - if 20 is rolled consider it critical hit and always hits
    - if a 1 is rolled consider it a critical misses
    - otherwise dice result and modifier must be above ArmorClass
    
On a hit, roll the provided damage dice into and return the damage 
    - on a critical hit the damage is rolled twice
    
Constraints:
    - modifier = -100 <= x <= 100
    - armor class = 0 <= x <= 50
    - damage dice = string ex 1d4 2d8 3d100
    
Current State of Project:
    I would consider this game to be a MVP version of what the final game would look like.
    It performs all of the basic requirements, and will run without crashing. 
    
    To play game you just run the program and it will roll your initial d20 die.
    From there the game will run through deciding if there is a Critical Miss, or Critical Hit right away.
    If neither of those, than it will determine the hit points dealt.
    
    I know i need to work on writing more CLEAN Code and using OOP principals, so any input on that would be great! Thanks. 