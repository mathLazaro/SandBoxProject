using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    private CapsuleCollider2D trigger;

    private void Start() {
        trigger = GetComponent<CapsuleCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collider2D) 
    {
        if(collider2D.gameObject.tag=="Player")
        {
            //Debug.Log("Trigger ativo");
            DialogSystem.ActiveDialogUI();
        }
    }

    /*
    private void OnTriggerExit2D(Collider2D collider2D) 
    {
        DialogSystem.
        //trigger.isTrigger = false;
    }
    */
}
