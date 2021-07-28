using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class AngelPresencia : MonoBehaviour
{
    public GameObject PostAngel;
    public GameObject Timelinegameover;
    public GameObject PostGameover;
    public PlayableDirector timelineAngel;
    public PlayableDirector TimelineGameOver;
    public GameObject canvaActive;
    public float TiempoDeCambio;
    public float TiempoDependeDeGameover;
    
        
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
        if (other.CompareTag("Mira"))
        {
            timelineAngel.Play();
            canvaActive.SetActive(true);
            PostAngel.SetActive(true);

            StartCoroutine("CambioDeEscena");
        }
            

            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            timelineAngel.Stop();
            canvaActive.SetActive(false);
            PostAngel.SetActive(false);

            StopCoroutine("CambioDeEscena");
        }
    }
 

    IEnumerator CambioDeEscena()
    {
        yield return new WaitForSeconds(TiempoDeCambio);
        Timelinegameover.SetActive(true);
        PostGameover.SetActive(true); 
        TimelineGameOver.Play();
        StartCoroutine(GameOverTiempo());
        
            
    }

    IEnumerator GameOverTiempo()
    {
        yield return new WaitForSeconds(TiempoDependeDeGameover);
        SceneManager.LoadScene("GameOver");
    }

 
}
