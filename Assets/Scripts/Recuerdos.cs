using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Recuerdos : MonoBehaviour
{
    public PlayableDirector TimelineParaSalir;
    private bool PuedeAbrir;
    public GameObject CanvasPuedeSalir;
    public GameObject ColliderDePuertaSalir;
    public static bool Tomada = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedeAbrir == true && Tomada == true)
        {
          ColliderDePuertaSalir.SetActive(true);
          if (Input.GetKeyDown(KeyCode.E))
          { 
            TimelineParaSalir.Play();
            Debug.Log("ya estoy saliendoo");
                    

          }
        }  
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeAbrir = true;
            CanvasPuedeSalir.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeAbrir = false;
            CanvasPuedeSalir.SetActive(false);
        }
    }
}
