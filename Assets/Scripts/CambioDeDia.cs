using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;


public class CambioDeDia : MonoBehaviour
{
    public PlayableDirector timeline;   
    public GameObject ActivaoDesactivaObj;
    public GameObject desactivarObj;
    public GameObject Canvas;
    public GameObject Tiempo; 
    public GameObject Timer;
    public GameObject ouijaC;
    public GameObject ojoC;
    public GameObject oraculoC;
    public GameObject Encuentralos;
 
  




    bool activar;
    bool enCollider;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && activar)
        {
            
            desactivarObj.SetActive(false);
            ActivaoDesactivaObj.SetActive(true);
            CambiarDia();
            Destroy(Canvas);
            Encuentralos.SetActive(true);
            StartCoroutine(desactivarCanvas());

            StartCoroutine(Encuentra());
          
            


        }
      
        

            
    }


    public void CambiarDia()
    {
        print("dia cambiao");
        if (!enCollider)
        {
            timeline.Play();         
            enCollider = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            activar = true;
        Canvas.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Canvas.SetActive(false);
            activar = false;
        }
    }

    IEnumerator desactivarCanvas()
    {
        yield return new WaitForSeconds(5f);
        
        Tiempo.SetActive(true);
        Timer.SetActive(true);
        ouijaC.SetActive(true);
        ojoC.SetActive(true);
        oraculoC.SetActive(true);
        gameObject.SetActive(false);
        
       
    }

    IEnumerator Encuentra()
    {
        yield return new WaitForSeconds(3);
        Encuentralos.SetActive(false);
    }
}
