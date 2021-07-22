using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCAP : MonoBehaviour
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
        if (Activarse == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                v1E.SetActive(false);
                v2E.SetActive(false);
                v3E.SetActive(false);
                v1A.SetActive(true);
                v2A.SetActive(true);
                v3A.SetActive(true);

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
        Pantalla1.SetActive(false);
        gameObject.SetActive(false);
        Otrocollider.SetActive(true);

    }
}