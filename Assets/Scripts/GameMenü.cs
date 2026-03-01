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
                case "Options":
                    Debug.Log("Settings Opened");
                    break;
                case "Quit":
                    Debug.Log("Game Closed");
                    break;
                default:
                    Debug.Log("Unknown Option");
                    break;
        }
    }
}
