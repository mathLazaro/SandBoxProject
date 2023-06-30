using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private GameObject dialogUI;
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;
    public static bool dialogActived;
    private static bool text1Actived,text2Actived;

    private void Start() {
        dialogActived = false;
        text1Actived = true;
    }

    private void Update() {
        if(dialogActived) dialogUI.SetActive(true);
        if(!dialogActived) dialogUI.SetActive(false);

        if(text1Actived && dialogActived) text1.SetActive(true);
        else text1.SetActive(false);

        if(text2Actived && dialogActived) text2.SetActive(true);
        else text2.SetActive(false);
    }

    static public void ActiveDialogUI()
    {
        Time.timeScale = 0f;
        dialogActived = true;
    }

    static public void SkipDialog(bool esc)
    {
        if(esc && dialogActived && !PauseSystem.isPaused && text1Actived)
        {
            text1Actived = false;
            text2Actived = true;
        }
        else if(esc && dialogActived && text2Actived)
        {
            text1Actived = true;
            text2Actived = false;
            dialogActived = false;
            Time.timeScale = 1f;
        }
    }
    
    
}
