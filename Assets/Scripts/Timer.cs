using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public GameObject GameOver;
    public GameObject PostGameOver;
    public PlayableDirector TimelineGameOver;
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

        if(tiempo <= 0)
        {
            timer.text = "0";
            GameOver.SetActive(true);
            PostGameOver.SetActive(true);
            TimelineGameOver.Play();
            StartCoroutine("Gameover");
        }
    }

    IEnumerator Gameover()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }
}
