using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public string[] enemyNames = { "Enemy1", "Enemy2", "Enemy3", "Enemy14" };
    public int spawnedEnemy;

    void Start()
    {
        SpawnEnemies();

        int totalEnemy = CountEnemies();
        Debug.Log("Total Enemy: " + totalEnemy);

        bool bossCheck = HasBossEnemy();
        Debug.Log("Boss Exists: " + bossCheck);

        PrintEnemies();

        string randomEnemy = GetRandomEnemy();
        Debug.Log("Random Enemy: " + randomEnemy);
    }

    
    private void SpawnEnemies()
    {
        for (int i = 0; i < enemyNames.Length; i++)
        {
            Debug.Log("Enemy Spawned: " + enemyNames[i]);
            spawnedEnemy++;
        }
    }

    
    private int CountEnemies()
    {
        return enemyNames.Length;
    }

    
    private bool HasBossEnemy()
    {
        foreach (string enemy in enemyNames)
        {
            if (enemy == "Boss")
            {
                Debug.Log("Boss enemy detected!");
                return true;
            }
        }

        return false;
    }

    
    private void PrintEnemies()
    {
        foreach (string enemy in enemyNames)
        {
            Debug.Log("Enemy: " + enemy);
        }
    }

    
    private string GetRandomEnemy()
    {
        int randomIndex = Random.Range(0, enemyNames.Length);
        return enemyNames[randomIndex];
    }
}