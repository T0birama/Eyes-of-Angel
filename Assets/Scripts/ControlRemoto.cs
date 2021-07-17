using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRemoto : MonoBehaviour
{
    public GameObject musica1;
    public GameObject musica2;
    public GameObject imagen1;
    public GameObject imagen2;
    public GameObject CambiarCancion;

    public bool PuedeActivar; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedeActivar == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                musica1.SetActive(false);
                musica2.SetActive(true);
                imagen1.SetActive(false);
                imagen2.SetActive(true);
            }
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeActivar = true;
            CambiarCancion.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeActivar = false;
            CambiarCancion.SetActive(false);
        }
    }
}
