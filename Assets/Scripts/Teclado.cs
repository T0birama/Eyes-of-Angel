using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclado : MonoBehaviour
{
    public GameObject PantallaDiscord;
    public GameObject PuedeApretar;
    public GameObject Pantalla1;
    private bool Activar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Activar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PantallaDiscord.SetActive(true);
                Pantalla1.SetActive(false);
                PuedeApretar.SetActive(false);
                gameObject.SetActive(false);
                
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
