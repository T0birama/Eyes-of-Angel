using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float tiempo = 75f;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        timer.text = " " + tiempo.ToString("f0");
    }
}
