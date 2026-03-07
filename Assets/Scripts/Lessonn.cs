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
        //EnemySpawner(5);
        
        CharacterName("Hero");
        GunBullet(20);
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

    private void EnemySpawner(int amount) 
    {
        for (int i = 0; i < amount; i++)
        {
            Debug.Log("Enemy Spawned");
        }
    }
    #endregion

    private void GunBullet(int bullet)
    {
        for (int i = 0; i < bullet; i++)
        {
            Debug.Log("Bullet Fired");
        }
    }

    private void CharacterName(string Name) 
    {
    Debug.Log("Character Name: " + Name);
    }
}
