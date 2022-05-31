using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour,Interactable
{
	public Room room;
	public Animator anim;
	public Material[] mat = new Material[2];
	public int id,value;

	public enum State
	{
		OFF,ON
	}
	public State state;
	public void Action()
	{
		switch_();
	}


	public void switch_()
	{
		if(state == State.OFF)
		{
			anim.SetTrigger("ON");
		}
		else
		{
			anim.SetTrigger("OFF");
		}
	}

	public void ChooseAction()
	{
		if (state == State.OFF)
		{
			value = 1;
			state = State.ON;
			room.SwitchesAction(id);
			gameObject.GetComponent<MeshRenderer>().material = mat[1];
		}
		else
		{
			value = -1;
			state = State.OFF;
			room.SwitchesAction(id);
			gameObject.GetComponent<MeshRenderer>().material = mat[0];
		}
	}

}
