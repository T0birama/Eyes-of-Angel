using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaAudio : MonoBehaviour
{
    public GameObject audio1;
    bool PuedeActivar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedeActivar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                audio1.SetActive(true);
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeActivar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeActivar = false;
        }
    }




}
