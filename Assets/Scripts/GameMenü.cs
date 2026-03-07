using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameMenü : MonoBehaviour
{
    public string selectedOption;
    int playerHealth = 100;

    string[] weapons = { "Sword", "Bow", "Axe" };

    public void Start()
    {
        //switch-case
        switch (selectedOption)
        {
            case "Start":
                Debug.Log("Game Started");
                break;
            case "Options":
                Debug.Log("Settings Opened");
                break;
            case "Quit":
                Debug.Log("Game Closed");
                break;
            default:
                Debug.Log("Unknown Option");
                break;
        }


        //TERNARY OPERATOR
        string playerStatus = playerHealth > 0 ? "Alive" : "Dead";
        Debug.Log(playerStatus);

        //For döngüsü
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Enemy Spawned: " + i);
        }

        //while döngüsü
        int count = 0;
        while (count < 3)
        {
            Debug.Log("Loading...");
            count++;
        }

        //array diziler
        foreach (string weapon in weapons)
        {
            Debug.Log("Weapon: " + weapon);
        }



        int[] scores = { 50, 120, 80, 200, 95 };

        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("Score: " + scores[i]);

            if (scores[i] > 100)
            {
                Debug.Log("High Score!");
            }
        }

    }
}
