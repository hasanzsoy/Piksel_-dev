using UnityEngine;

public class TimingCodeExample : MonoBehaviour
{
    //public int cubeSpeed;
    //public float timer;
    //public float timeLeft;
    public float coolDown;
    public float timer;

    private void Start()
    {
        #region Invoke Kod Örneði
        //Invoke("ShowMessage", 3); // invokeda fonksyionu string deðerde çaðýrabilriz
        //InvokeRepeating("ShowMessage",2,3);
        #endregion
    }
    void Update()
    {
        #region kod örneði
        //transform.Translate(Vector3.forward * Time.deltaTime *cubeSpeed);
        //Debug.Log("Time : " + Time.time);
        //timer += Time.deltaTime;
        //if(timer >= 2) 
        //{
        //    Debug.Log("2 saniye geçti");
        //    timer = 0;
        //}
        #endregion
        #region Süre Sýfýra Ýnince Durdu
        //timeLeft -= Time.deltaTime;
        //if (timeLeft <= 0) 
        //{
        //    Debug.Log("Time is up");
        //    timeLeft = 0;
        //}
        #endregion
        #region
        //imer += Time.deltaTime;
        //f(timer > coolDown) 
        //
        //   Debug.Log("Süre artýyor");
        //   coolDown = timer;
        //
        #endregion
    }

    private void ShowMessage()
    {
        Debug.Log("3 saniye sonra çalýþtý");
    }
}
