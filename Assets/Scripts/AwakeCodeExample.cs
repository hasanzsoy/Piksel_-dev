using UnityEngine;

public class AwakeCodeExample : MonoBehaviour
{
    public EnemyType enemyType;

    public CharacterClass characterClass;

    private void Start()
    {
        //enemyType = EnemyType.Orc;
        //Debug.Log("Enemy Type: " + enemyType);

        //gameState = GameState.Playing;
        //Debug.Log("Game State: " + gameState);

        switch (characterClass)
        {
            case CharacterClass.Warrior:
                Debug.Log("Savaþcýyý seçtiniz!");
                break;
            case CharacterClass.Mage:
                Debug.Log("Büyücüyü seçtiniz!");
                break;
            case CharacterClass.Archer:
                Debug.Log("Okuçuyu seçtiniz!");
                break;
        }
    }

    public enum EnemyType
    {
        Goblin,
        Orc,
        Troll
    }

    public enum CharacterClass
    {
        Warrior,
        Mage,
        Archer
    }
}
