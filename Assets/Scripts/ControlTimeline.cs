using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ControlTimeline : MonoBehaviour
{
    public PlayableDirector TimelineCamaras;
    public int SEG = 10;
    public GameObject TimelineYCanvas;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TiempoDeEspera());
    }

    IEnumerator TiempoDeEspera()
    {
        yield return new WaitForSeconds(SEG);
      
        TimelineYCanvas.SetActive(true);
        TimelineCamaras.Play();

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
