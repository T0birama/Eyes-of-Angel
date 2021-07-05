using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Ventanal : MonoBehaviour
{
    public PlayableDirector abrirT;
    public GameObject canvasVentanal;
    public GameObject otroColliderVentanal;
    public bool abrir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(abrir == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                abrirT.Play();
                gameObject.SetActive(false);
                otroColliderVentanal.SetActive(true);
                canvasVentanal.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            canvasVentanal.SetActive(true);
            abrir = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            canvasVentanal.SetActive(false);
            abrir = false;
        }
    }
}
