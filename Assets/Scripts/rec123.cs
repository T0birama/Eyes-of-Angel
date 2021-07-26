using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rec123 : MonoBehaviour
{
    public GameObject recuerdos;
    public GameObject Jaulas;
    public GameObject x;
    public GameObject objetoCanvas;
    public GameObject OtroobjetoCanvas;
    public GameObject canvasPuedoAgarrarlo;
    private bool PuedoAgarrarlo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedoAgarrarlo == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                recuerdos.SetActive(false);
                canvasPuedoAgarrarlo.SetActive(false);
                Jaulas.SetActive(false);
                x.SetActive(true);
                objetoCanvas.SetActive(false);
                OtroobjetoCanvas.SetActive(true);

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedoAgarrarlo = true;
            canvasPuedoAgarrarlo.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedoAgarrarlo = false;
            canvasPuedoAgarrarlo.SetActive(false);
        }
    }

}
