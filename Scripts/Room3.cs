using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class Room3 : Room
    {
        public Lift lift;
        // Start is called before the first frame update
        void Start()
        {
            sufficient_Power_Value = 2;
            lift.sufficientPower = 1;
        }

        public override void HolesAction(int id)
        {
            if (id == 2) lift.SetPower(hole[id].value);
            else
                SetPower(hole[id].value);
            

        }
		 
	}
       

}

