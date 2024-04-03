using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseKontrol : MonoBehaviour
{
    public GameObject pause_kontrol, ingame_kontrol;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pause_button()
    {
        pause_kontrol.SetActive(true);
        ingame_kontrol.SetActive(false);
        Time.timeScale = 0;
    }

    public void play_button()
    {
        pause_kontrol.SetActive(false);
        ingame_kontrol.SetActive(true);
        Time.timeScale = 1;
    }

    public void restart_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void mainmenu_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
