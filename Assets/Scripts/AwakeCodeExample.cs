using UnityEngine;

public class AwakeCodeExample : MonoBehaviour
{
    public EnemyData[] enemyData; // array olarak enemyleri yazdýrdýk
    public int enemyCount;  //burada enemy sayýsýný yazdýrdýk

    private void Start()
    {
        enemyData = new EnemyData[enemyCount];

        for (int i = 0; i < enemyCount; i++) // burada girdiðimiz bilgileri inspectorda yazdýrdýk
        {
            enemyData[i] = new EnemyData("A",1,100,50,EnemyType.Goblin);
        }
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