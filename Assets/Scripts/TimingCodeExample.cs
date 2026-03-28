using UnityEngine;
using UnityEngine.Rendering;

public class TimingCodeExample : MonoBehaviour
{
    //public int cubeSpeed;
    //public float timer;

    private void Start()
    {
        Invoke("ShowMessage", 3); // invokeda fonksyionu string deðerde çaðýrabilriz
    }
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime *cubeSpeed);
        //Debug.Log("Time : " + Time.time);
        //timer += Time.deltaTime;
        //if(timer >= 2) 
        //{
        //    Debug.Log("2 saniye geçti");
        //    timer = 0;
        //}
    }

    private void ShowMessage()
    {
        Debug.Log("3 saniye sonra çalýþtý");
    }
}
