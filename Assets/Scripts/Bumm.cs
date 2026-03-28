using UnityEngine;

public class Bumm : MonoBehaviour
{
    private void Start()
    {
        Invoke("Bum",3);
    }

    void Bum()
    {
        Debug.Log("Bum!!");
        Destroy(gameObject);
    }
}
