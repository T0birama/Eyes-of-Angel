using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class controlarTimeline : MonoBehaviour
{
    public GameObject Timelinecontrol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(control());
    }

    IEnumerator control()
    {
        yield return new WaitForSeconds(2f);
        Timelinecontrol.SetActive(true);

    }
}
