using Unity.VisualScripting;
using UnityEngine;

public class LifecycleCode : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
        //atama yaparken kullanýlýrýz genelde
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void Update()
    {
        Debug.Log("Update");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        // fizik kontrollü iþler yapýnca kullanýlýrýz genelde 
        //iþin içine ne zaman rigibody girirse fizik olur
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
        // genelde kamerada yumuþak bir þekilde kullanmak için kullanýýrýz
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");

        //obje açýldýktan sonra çalýþtýrýlacak kod
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
        //obje kapandýktan sonra çalýþtýrýlacak kod

    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
        //obje sahneden yok olduktan sonra çalýþacak kod
    }


}
