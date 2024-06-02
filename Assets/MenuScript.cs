using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject Settingsbtn;

    [SerializeField]
    GameObject Soundbtn;
    [SerializeField]
    GameObject Playbtn;
    [SerializeField]
    GameObject Pausebtn;
    [SerializeField]
    GameObject PrimaryMenu;
    [SerializeField]
    GameObject SecondaryMenu;
    
    public void Settings(){
        PrimaryMenu.SetActive(true);
    }
    public void Play(){
        Pausebtn.SetActive(true);
        Playbtn.SetActive(false);

        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    public void Pause(){
        Pausebtn.SetActive(false);
        Playbtn.SetActive(true);
        Time.timeScale = 0;
        AudioListener.pause = true;
    }
    public void Sound(){
        // enable or disable sound
    }
    public void Exit(){
        Application.Quit();
    }

}