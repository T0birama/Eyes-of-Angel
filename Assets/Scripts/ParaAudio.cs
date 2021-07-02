using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaAudio : MonoBehaviour
{
    public GameObject audio1;
    public GameObject audio2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("casa"))
        {
            audio1.SetActive(true);
            audio2.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Terreno"))
        {
            audio1.SetActive(false);
            audio2.SetActive(true);
        }
    }
   
}
