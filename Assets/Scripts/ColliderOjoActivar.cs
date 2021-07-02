using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ColliderOjoActivar : MonoBehaviour
{
    public GameObject activar;
    public PlayableDirector Timeline;
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
            activar.SetActive(true);
            Timeline.Play();        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activar.SetActive(false);
            Timeline.Stop();
            gameObject.SetActive(false);
        }
    }
}
