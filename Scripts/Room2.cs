using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2 : Room
{

	private void Start()
	{
		sufficient_Power_Value = 1;
	}

	public override void HolesAction(int id)
	{
		SetPower(hole[0].value);
		
		//if (hole[0].active)
		//	OpenDoors();
		//else
		//	CloseDoors();
	}

}
