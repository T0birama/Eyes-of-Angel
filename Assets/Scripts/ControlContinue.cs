using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlContinue : MonoBehaviour
{
    public GameObject botonContinue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PararContinue();
    }

    public void PararContinue()
    {
        botonContinue.SetActive(false);
        StartCoroutine(Continueloco());
    }

    IEnumerator Continueloco()
    {
        yield return new WaitForSeconds(3);
        botonContinue.SetActive(true);
    }
}
