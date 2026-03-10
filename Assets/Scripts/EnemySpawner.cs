using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int totalEnemy;
    public string[] enemyNames = { "Enemy1", "Enemy2", "Enemy3", "Enemy14" };
    public int spawnedEnemy;

    void Start()
    {
        SpawnEnemies();

        int count = CountEnemies();
        Debug.Log("Total Enemy: " + count);

        HasBossEnemy();

        PrintEnemies();

        string randomEnemy = GetRandomEnemy();
        Debug.Log("Random Enemy: " + randomEnemy);
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < enemyNames.Length; i++)
        {
            Debug.Log("Enemy Spawned: " + enemyNames[i]);
            spawnedEnemy++;
        }
    }

    int CountEnemies()
    {
        return enemyNames.Length;
    }

    bool HasBossEnemy()
    {
        for (int i = 0; i < enemyNames.Length; i++)
        {
            if (enemyNames[i] == "Boss")
            {
                Debug.Log("Boss enemy detected!");
                return true;
            }
        }

        return false;
    }

    void PrintEnemies()
    {
        foreach (string enemy in enemyNames)
        {
            Debug.Log("Enemy: " + enemy);
        }
    }

    string GetRandomEnemy()
    {
        int randomIndex = Random.Range(0, enemyNames.Length);

        return enemyNames[randomIndex];
    }


}
