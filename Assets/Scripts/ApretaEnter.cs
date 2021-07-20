using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ApretaEnter : MonoBehaviour
{
    public PlayableDirector Faded;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Faded.Play();
            StartCoroutine(Escena());
        }
    }

    IEnumerator Escena()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Cinematica");
    }
}
