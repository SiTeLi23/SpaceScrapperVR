using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{
    public Animator animator;
    public string boolName = "Open";

    private void Start()
    {
        
    }
    public void OpenDoor() 
    {
        if (enabled == true)
        {
            bool isOpen = animator.GetBool(boolName);
            animator.SetBool(boolName, !isOpen);

            AudioManager.instance.Play("Door");
        }
    }
}
