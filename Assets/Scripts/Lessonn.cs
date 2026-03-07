using System.Threading;
using UnityEngine;

public class Lessonn : MonoBehaviour
{
    public float playerSpeed, enemySpeed;

    void Start()
    {
        //ShowGameStart();
        //ShowPlayerName("John Doe");
        //ShowPlayerStats(100, 50);
        //EnemySpawner(5,100,true,"Hasan",28);
        //CharacterName("Hero");
        GunBullet();
    }
    public void Update()
    {
       
    }
    #region Kod Örnekleri
    private void ShowGameStart()
    {
        Debug.Log("Game Start"); //metot çaðýrma start veya 
    }

    private void ShowPlayerName(string playerName)
    {
        Debug.Log("Player Name: " + playerName);
    }

    public void ShowPlayerStats(int health, int score)
    {
        Debug.Log("Player Health: " + health);
        Debug.Log("Player Score: " + score);
    }

    private void EnemySpawner(int amount, int health, bool check, string name, int age)
    {
        for (int i = 0; i < amount; i++)
        {
            Debug.Log("Enemy Spawned");
        }
        Debug.Log("Enemy Health: " + health);
        if (check)
        {
            Debug.Log("Check is true");
        }
        else
        {
            Debug.Log("Check is false");
        }
        Debug.Log("Enemy Name: " + name);
        Debug.Log("Enemy Age: " + age);
    }


    private void GunBullet(int bullet = 10)
    {
        for (int i = 0; i <= bullet; i++)
        {
            Debug.Log("Bullet Fired "+ i);
        }
    }

    private void CharacterName(string Name) 
    {
    Debug.Log("Character Name: " + Name);
    }
    #endregion

   
}
