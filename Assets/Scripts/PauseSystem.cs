using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    public static bool isPaused;

    private void Start() {
        isPaused = false;
    }

    public static void Pause(bool inputPause)
    {
        if(!DialogSystem.dialogActived && inputPause && isPaused==false) // Serve para entrar no pause
        {
            isPaused = true;
            Time.timeScale=0f;
        }
        else if(inputPause && isPaused==true) // Serve para sair do pause
        {
            isPaused = false;
            Time.timeScale=1f;
        }
    }

    private void Update() 
    {
        if(isPaused) pauseUI.SetActive(true);
        else pauseUI.SetActive(false);
    }
}
