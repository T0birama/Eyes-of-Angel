using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CambioDeDia : MonoBehaviour
{
    public PlayableDirector timeline;   
    public GameObject ActivaoDesactivaObj;
    public GameObject desactivarObj;
    public GameObject Canvas;




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
            StartCoroutine(desactivarCanvas());
           
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
        }
    }

    IEnumerator desactivarCanvas()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
        Destroy(Canvas);
    }
}
