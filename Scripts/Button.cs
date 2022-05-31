using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour,Interactable
{
	public Room room;
	public Animator anim;
	public List <Material> mat;
	public int id;
	public void Action()
	{
		anim.SetTrigger("push");
	}

	public void PushButton()
	{
		room.ButtonsAction(id);
	}
}
