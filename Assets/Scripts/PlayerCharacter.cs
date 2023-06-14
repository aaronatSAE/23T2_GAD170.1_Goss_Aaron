using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first
    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;

    // We need our player character to attack when we press the spacebar...
    // but let’s simply get it to add a level for now.


    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        StartTheGameAgainFromLevelOne();
    }

    private void Update()
    {
        // if the player presses the spacebar...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ...add a level!
            Debug.Log("Aaron has hit the spacebar on his computer at the front of the room!");
            level++;
        }

        // The game should tell the player they have won
        // when the player character’s level reaches 5.
        if(level == 5)
        {
            Debug.Log("YOU WIN");
        }
    }

    private void StartTheGameAgainFromLevelOne()
    {
        attack = 10;
        health = 100;
        level = 1;
    }
}
