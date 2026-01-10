[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
### Prompt 1
Gio Solorio, he/him

### Prompt 2
Our plan outlined our usage of an update method in order to detect when the space bar would be inputted in order to determine when to instantiate the seed prefab. While the member variables for the player class 
lined up well with what was used within the actual minigame, the method "OnTriggerInput(“space”);" doesn't actually exist, and is rather written as "Input.GetKeyDown(KeyCode.Space)". Beyond that, another condition 
needed to be introduced in order to ensure the plant would only spawn as much as could be found within the player inventory, being checking within the conditional if the integer value of seeds left to the player 
was above zero. The instantiate mechanics was relatively the most complex element of the program to code, yet there were other elements that had been planned, such as in using the update values of the int _numseedsLeft 
and int _numSeeddsPlanted variables within the update functionw, as well as using that same update function to check inputs to allow for mkovement.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
