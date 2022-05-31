using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
	public List <InteractiveHole> hole;
	public List <Switch> switch_;
	public List<Button> button;
	public Animator doors;
	public int power;
	public int sufficient_Power_Value;
	public void SetPower(int value)
	{
		power += value;
		if (power >= sufficient_Power_Value) 
			OpenDoors();
		else
			CloseDoors();
	}


	public void OpenDoors()
	{
		Debug.Log("DOORS OPENED!");
		doors.SetBool("opened",true);
		doors.SetBool("closed", false);
	}

	public void CloseDoors()
	{
		Debug.Log("DOORS CLOSED!");
		doors.SetBool("closed",true);
		doors.SetBool("opened", false);
	}

	public virtual void HolesAction(int id){}
	public virtual void SwitchesAction(int id){}
	public virtual void ButtonsAction(int id){}

	
}
