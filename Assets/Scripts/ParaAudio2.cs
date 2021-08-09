using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaAudio2 : MonoBehaviour
{
    public GameObject audio2;
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
                audio2.SetActive(false);
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
