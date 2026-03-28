using UnityEngine;

public class TimingCodeExample : MonoBehaviour
{
    public int cubeSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *cubeSpeed);
        Debug.Log("Time : " + Time.time);
    }
}
