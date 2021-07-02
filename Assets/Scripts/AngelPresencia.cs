using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class AngelPresencia : MonoBehaviour
{
    public PlayableDirector timelineAngel;
    public GameObject canvaActive;
    public float TiempoDeCambio;
    
        
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
            timelineAngel.Play();
            canvaActive.SetActive(true);
            Debug.Log("playyy");
        StartCoroutine(CambioDeEscena());

            
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            timelineAngel.Stop();
        canvaActive.SetActive(false);
        Debug.Log("stopppp");
        StopCoroutine(CambioDeEscena());
    }

    IEnumerator CambioDeEscena()
    {
        yield return new WaitForSeconds(TiempoDeCambio);
        SceneManager.LoadScene ("GameOver");
            
    }
 
}
