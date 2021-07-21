using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloPensamientos1 : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject OtroCollider;
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

            Canvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            StartCoroutine(Destroy());

        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1);
        Canvas.SetActive(false);
        gameObject.SetActive(false);
        OtroCollider.SetActive(true);

    }
}
