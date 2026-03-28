using Unity.VisualScripting;
using UnityEngine;

public class Codexample : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake Metodu Oyun Baþladýðýnda 1 kez çalýþýr Ama Startdan Önce Çalýþýr");
    }

    private void Start()
    {
        Debug.Log("Start Metodu Oyun Baþladýðýnda 1 kez çalýþýr");
    }

    private void Update()
    {
        Debug.Log("Update Metodu Oyun Ýçerisinde Sürekli Çalýþýr");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Metodu Update Ýle Ayný Mantýk Ama Updateden Önce Çalýþýr Daha Yavaþ Çalýþýr Fizik Kontrolleri Ýçin kullanýlýr");
    }

    private void LateUpdate()
    {
        Debug.Log("Update Metodu Olarak En Son Çalýþýr");
    }

    private void OnEnable()
    {
        Debug.Log("Sahnede Obje Açýk Ýse Çalýþýr");
    }
    private void OnDisable()
    {
        Debug.Log("Sahnede Obje Açýk Deðil Ýse Çalýþýr");
    }
    private void OnDestroy()
    {
        Debug.Log("Sahneden Obje Silinirse Çalýþýr");
    }
}
