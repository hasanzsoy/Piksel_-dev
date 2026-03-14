using UnityEngine;

public class AwakeCodeExample : MonoBehaviour
{
    public EnemyData enemyData;

    private void Start()
    {
        enemyData = new EnemyData("Test", 1, 5, 10, EnemyType.Orc);
    }
}

[System.Serializable]
public class EnemyData 
{
    public string enemyName;
    public int enemyID;
    public int enemyHealth;
    public int enemySpeed;
    public EnemyType enemyType;

    public EnemyData(string name, int id, int health, int speed, EnemyType type)
    {
        enemyName = name;
        enemyID = id;
        enemyHealth = health;
        enemySpeed = speed;
        enemyType = type;
    }

}

public enum EnemyType
{
    Goblin,
    Orc,
}