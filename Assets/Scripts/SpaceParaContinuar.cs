using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SpaceParaContinuar : MonoBehaviour
{
    public GameObject Musica1;
    public GameObject Musica2;
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
            Musica1.SetActive(false);
            Musica2.SetActive(true);
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
