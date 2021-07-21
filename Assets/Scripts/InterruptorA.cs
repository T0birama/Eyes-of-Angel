using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptorA : MonoBehaviour
{
    public AudioSource Switch;
    public GameObject Luz;
    public GameObject PuedeApretar;
    bool Activar;
    public GameObject OtroInterruptor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Activar == true & Luz == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Luz.SetActive(false);
                gameObject.SetActive(false);
                OtroInterruptor.SetActive(true);
                PuedeApretar.SetActive(false);
                Switch.Play();

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
