using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Variables will go first
    [SerializeField] private int attack = 10;
    [SerializeField] private int health = 100;
    [SerializeField] private int level = 1;

    // Methods will go underneath here

    // Start is called before the first frame update
    private void Start()
    {
        attack = 10;
        health = 100;
        level = 1;
        StartTheGameAgainFromLevelOne();
    }

    private void StartTheGameAgainFromLevelOne()
    {
        attack = 10;
        health = 100;
        level = 1;
    }
}
