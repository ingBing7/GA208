# GA208
## Devlogs

### Minigame 1 Devlog!

Sjofn Quist, They/Them or He/Him

Initially, my plan for this minigame was actually a little too complex for what it actually turned out being. I tend to get in my head and overdo the plan in my head, as I wanted to have 2 different scripts that reference each other, one to handle the player movement and inputs, and one to handle updating the UI and instantiating the plants prefabs. While I could do that, and in a seperate project I have, for the scale of this project, that was a little unnecessary. I only needed one script. I acknowledge this probably isn't the most optimized way to handle it, but for this project I figured it would work. I used the New Unity Input system, and I call the specific inputs I need, move and plant in my case, within this script. When the player presses any of the Move Keys, AKA WASD, the players pushed in the direction of their input by multiplying it by 5 and applying that force/velocity to their rigidbody. As for Planting, when the plant input is called, in my case space, the code checks if their seed float is bigger than 0. If it is, it instantiates a plant prefab I have set up in the unity editor at the players transform. Then, it subtracts 1 from my seedsLeft float and adds 1 to my plantsPlanted float. After this, it updates the UI to the new value of the respective floats.

rewrite.

In another project, which is a convieniently very similar game to this one, I handled the spawning of the plants in a different script attached to a plant pot prefab. This would set a seed gameobject to active within the prefab. I did this as I needed multiple pots that all spawn their own individual seeds that can be grown at different rates. 
The link to that game is here: https://ingbing.itch.io/the-plants-are-on-steroids

### W1 activity
#### W1 Exercise

Q1
10

Q2
2

i is our counter, we start at 0. We add by one each time - 'x += 1;' - and we add  until i is equivelent to 2.

Q3
Prints "hello world" in the debug log in the unity editor every frame since it's in the update function. 
Very very fast "hello's" to the world.

Q4
MonoBehavior 

Q5
At the start of the script, it converts 10 into a parameter and replaces any instance of 'x' with it. The debug log will read "x = 10"

Q6
10 is "int x" within the 'private void PrintMessage (int x)' line. It is a parameter, and will be subbed into any instance of x in the function. '(x = " + x);' is the debug log string, the line of text the debug log will display in the unity editor. 

Q7
Transform with a capital T is the class "transform", not the actual objects transform. This line of code isn't referencing a specific objects transform, and will then give an error. 

Q8
_playerTransform.Translate

Map!
<img width="1936" height="1262" alt="W1_DiagramForGame" src="https://github.com/user-attachments/assets/9c871467-2327-48ef-b4b9-89bf8d116710" />


### W2
#### Lecture Notes

Make sure to fork the correct repository every week for the minigames lol oopsies. Main repo - this repo - cannot be built, which is why it resulted in the weird build error I experienced. ,:P 
Make sure to rewrite Devlog 1 so it's more accurate to the prompt. Lay out how the map I drew in class on week 1 connects to the code I wrote. 

W2 preparation quiz review

Prefabs exist so we can make copies of them before they're in the scene. Transform.x just. Isn't a thing. Transform.position.x is!

If I'm ever confused on a function/method, go the MonoBehavior documentation page. To receive collision messages, both of the GameObjects must have colliders AND at least one of the GameObjects must have a Rigidbody component.

Static methods and variables

Random.Range will select a random number from a specific range, like 30-40 or 1-100. It does not require a specific object. 

Diagram For Game

<img width="2169" height="1436" alt="W2_DiagramForGame" src="https://github.com/user-attachments/assets/08a1df5a-e56c-40e0-9f6b-edb1a6cfec26" />
