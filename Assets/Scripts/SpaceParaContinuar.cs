using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SpaceParaContinuar : MonoBehaviour
{
    public GameObject HistoriaTimeline;
    public PlayableDirector TimeLineCamaras;
    public GameObject CamarasyCanvas;
    public GameObject Texto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TiempodeEspacio());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HistoriaTimeline.SetActive(false);
            CamarasyCanvas.SetActive(true);
            TimeLineCamaras.Play();
            Destroy(gameObject);
        }
    }


    IEnumerator TiempodeEspacio()
    {
        yield return new WaitForSeconds(5);
        Texto.SetActive(true);

    }
}
