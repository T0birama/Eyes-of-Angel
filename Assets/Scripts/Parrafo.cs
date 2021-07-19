using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parrafo : MonoBehaviour
{
    public TextMeshProUGUI TextP;

    [TextArea (3,30)] 
    public string[] parrafos;
    int index;
    public float velParrafos;

    public GameObject imagen1;
    public GameObject imagen2;

    public GameObject BotonContinue;
    public GameObject BotonLeer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextP.text == parrafos[index] )
        {
            
            BotonContinue.SetActive(true);
            BotonLeer.SetActive(false);
        }
    }

    IEnumerator TextParrafo()
    {
        foreach(char letra in parrafos[index].ToCharArray())
        {
            TextP.text += letra;

            yield return new WaitForSeconds(velParrafos);
        }
    }

    public void SiguienteParrafo()
    {
        if(index < parrafos.Length - 1)
        {
            index++;
            TextP.text = "";
            StartCoroutine(TextParrafo());
        }

        else
        {
            TextP.text = "";
            BotonContinue.SetActive(false);
        }
        if(index == 4)
        {
            Debug.Log("cambiar fondo");
            imagen1.SetActive(false);
            imagen2.SetActive(true);
        }
        if(index == 8)
        {
            imagen2.SetActive(false);
        }
    }

    public void ActivarTexto()
    {
        StartCoroutine(TextParrafo());
    }
}
