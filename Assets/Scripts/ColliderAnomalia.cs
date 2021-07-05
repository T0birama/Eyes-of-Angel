using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAnomalia : MonoBehaviour
{
    public GameObject Anomalia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anomalia.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anomalia.SetActive(false);
        }
    }
}
