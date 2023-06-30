using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    static Action<bool> Teste;

    private void OnEnable()
    {
        Teste += PauseSystem.Pause;
        Teste += DialogSystem.SkipDialog;
    }


    private void OnDisable() 
    {
        Teste -= PauseSystem.Pause;
        Teste -= DialogSystem.SkipDialog;
    }

    private void Update() 
    {
        Teste?.Invoke(Input.GetKeyDown(KeyCode.Escape));
    }
}
