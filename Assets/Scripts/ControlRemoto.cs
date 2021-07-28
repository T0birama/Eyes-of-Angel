using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRemoto : MonoBehaviour
{
    public GameObject ControlRemoto1;
    public GameObject ControlRemoto2;
    public GameObject Musica1;
    public GameObject Musica2;
    public GameObject Imagen1;
    public GameObject Imagen2;
    public GameObject CambiarCancion;
    public GameObject NombreCancion1;
    public GameObject NombreCancion2;

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
                ControlRemoto1.SetActive(false);
                ControlRemoto2.SetActive(true);
                Musica1.SetActive(false);
                Musica2.SetActive(true);
                Imagen1.SetActive(false);
                Imagen2.SetActive(true);
                NombreCancion1.SetActive(false);
                NombreCancion2.SetActive(true);

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
