using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, Interactable
{
    public Animator anim;


    public void DoorAnimation()
	{
        anim.SetTrigger("action");
	}

    public void Action()
	{
        DoorAnimation();
	}
}
