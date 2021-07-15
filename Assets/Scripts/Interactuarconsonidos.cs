using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Interactuarconsonidos : MonoBehaviour
{
    public PlayableDirector Timeline;
    public GameObject Canvas; 
    public bool PuedeInteractuar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedeInteractuar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Timeline.Play();
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeInteractuar = true;
            Canvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            PuedeInteractuar = true;
            Canvas.SetActive(false);
        }
    }
}
