using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public CharacterData[] characterDatas;
    public int characterCount;

    void Start()
    {
        characterDatas = new CharacterData[5];

        for (int i = 0; i < characterCount; i++)
        {
            int id = i + 1;
            string name = "Character: " + id;

            CharacterClass randomClass = (CharacterClass)Random.Range(0, System.Enum.GetValues(typeof(CharacterClass)).Length);

            int health = Random.Range(80, 151);
            float damage = Random.Range(10f, 50f);
            float speed = Random.Range(3f, 10f);

            characterDatas[i] = new CharacterData(id, name, randomClass, health, damage, speed);
        }

        PrintCharacters();

        Debug.Log("Warrior Count: " + CountWarriors());

        CharacterData strongest = GetStrongestCharacter();
        Debug.Log("Strongest Character: " + strongest.characterName + " Damage: " + strongest.characterDamage);
    }


    //BURAYI YAPAY ZEKAYA YAPTIRDIM
    void PrintCharacters()
    {
        for (int i = 0; i < characterDatas.Length; i++)
        {
            Debug.Log("ID: " + characterDatas[i].characterID);
            Debug.Log("Name: " + characterDatas[i].characterName);
            Debug.Log("Class: " + characterDatas[i].characterClass);
            Debug.Log("Health: " + characterDatas[i].characterHealth);
            Debug.Log("Damage: " + characterDatas[i].characterDamage);
            Debug.Log("Speed: " + characterDatas[i].characterSpeed);
        }
    }

    int CountWarriors()
    {
        int warriorCount = 0;

        for (int i = 0; i < characterDatas.Length; i++)
        {
            if (characterDatas[i].characterClass == CharacterClass.Warrior)
            {
                warriorCount++;
            }
        }

        return warriorCount;
    }

    CharacterData GetStrongestCharacter()
    {
        CharacterData strongest = characterDatas[0];

        for (int i = 1; i < characterDatas.Length; i++)
        {
            if (characterDatas[i].characterDamage > strongest.characterDamage)
            {
                strongest = characterDatas[i];
            }
        }

        return strongest;
    }
}

[System.Serializable]
public struct CharacterData
{
    public int characterID;
    public string characterName;
    public CharacterClass characterClass;
    public int characterHealth;
    public float characterDamage;
    public float characterSpeed;

    public CharacterData(int id, string name, CharacterClass charClass, int health, float damage, float speed)
    {
        characterID = id;
        characterName = name;
        characterClass = charClass;
        characterHealth = health;
        characterDamage = damage;
        characterSpeed = speed;
    }
}

public enum CharacterClass
{
    Warrior,
    Mage,
    Archer,
    Tank
}