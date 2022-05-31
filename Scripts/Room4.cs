using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4 : Room
{
	public Lift lift;
	public GameObject InteractiveBOX;
	public Transform Tpos;
	private void Start()
	{
		sufficient_Power_Value = 3;
		lift.sufficientPower = 2;
	}
	public override void HolesAction(int id)
	{
		if(id <= 2)
				SetPower(hole[id].value);
		if (id == 3)
				lift.SetPower(hole[id].value);
	}

	public override void SwitchesAction(int id)
	{
		if (id == 0) lift.SetPower(switch_[id].value);
	}

	public override void ButtonsAction(int id)
	{
		if(id==0)
		{
			Instantiate(InteractiveBOX, new Vector3(Tpos.position.x, Tpos.position.y, Tpos.position.z),Quaternion.identity);
		}
	}
}
