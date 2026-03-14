using UnityEngine;

public class EnumExample : MonoBehaviour
{
    public CharacterName characterName;
    public Weapon weaponSelected;
    void Update()
    {
        switch (characterName)
        {
            case CharacterName.ali:
                Debug.Log("aliyi seçtin");
                break;
            case CharacterName.veli:
                Debug.Log("veliyi seçtin");
                break;
            case CharacterName.hasan:
                Debug.Log("hasaný seçtin");
                break;
        }

        switch (weaponSelected)
        {
            case Weapon.Riffle:
                Debug.Log("Riflle Selected");
                break;
            case Weapon.Rocket:
                Debug.Log("Rocket Selected");
                break;
            case Weapon.Gun:
                Debug.Log("Gun Selected");
                break;
        }

    }

}

public enum CharacterName
{
    ali,
    veli,
    hasan
}

public enum Weapon
{
    Riffle,
    Rocket,
    Gun
}
