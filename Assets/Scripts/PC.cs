using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    public GameObject v1E;
    public GameObject v2E;
    public GameObject v3E;
    public GameObject v1A;
    public GameObject v2A;
    public GameObject v3A;
    public GameObject PuedeApretar;
    public GameObject Pantalla1;
    public GameObject Otrocollider;
    
    private bool Activarse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Activarse == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                v1E.SetActive(true);
                v2E.SetActive(true);
                v3E.SetActive(true);
                v1A.SetActive(false);
                v2A.SetActive(false);
                v3A.SetActive(false);
                
                StartCoroutine(Pantallas());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            Activarse = true;
            PuedeApretar.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            Activarse = false;
            PuedeApretar.SetActive(false);
        }
    }

    IEnumerator Pantallas()
    {
        yield return new WaitForSeconds(2);
        Pantalla1.SetActive(true);
        gameObject.SetActive(false);
        Otrocollider.SetActive(true);

    }
}
