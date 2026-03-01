using UnityEngine;

public class GameMenü : MonoBehaviour
{
    public string selectedOption;

    public void Start()
    {
        switch(selectedOption)
            {
            case "Start":
                Debug.Log("Game Started");
                break;

        }
    }
}
