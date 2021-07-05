using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public GameObject Luz;
    public GameObject PuedeApretar;
    public GameObject OtroInterruptor;
    bool Activar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Activar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Luz.SetActive(true);
                gameObject.SetActive(false);
                OtroInterruptor.SetActive(true);
                PuedeApretar.SetActive(false);
            }
          
        }
        
       
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            Activar = true;
            PuedeApretar.SetActive(true);
        }
  
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            Activar = false;
            PuedeApretar.SetActive(false);
        }
    }

}
