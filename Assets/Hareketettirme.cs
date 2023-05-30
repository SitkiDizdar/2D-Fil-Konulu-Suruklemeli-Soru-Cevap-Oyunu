using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hareketettirme : MonoBehaviour
{
    
    Camera kamera;
    GameObject[] gölgeler;
    Vector2 baslangıc_pozisyon;

   

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        gölgeler = GameObject.FindGameObjectsWithTag("gölge");
        baslangıc_pozisyon = transform.position;
    }

    private void OnMouseDrag()
{
   Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
    pozisyon.z = 0;
    transform.position = pozisyon;
}

   
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
      {
         foreach( GameObject gölge in gölgeler)
{
         
            if(gameObject.name == gölge.name)
              {
                  float mesafe = Vector3.Distance(gölge.transform.position, transform.position);
                  if(mesafe <= 50)
                  {
                      transform.position = gölge.transform.position;
                      Destroy(this);   
                      SceneManager.LoadScene(2);
                  }

                  else
                  {
                      transform.position = baslangıc_pozisyon;         
                  }
              }
           }       
      }
    }
}
