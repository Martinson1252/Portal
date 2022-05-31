using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Lift : MonoBehaviour,Interactable
{
    public Material red, green;
    public GameObject winda_Button, cala_Winda;
    public MeshRenderer lightIndicator;
    Action action;
    Vector3 temp_Poz;
    public Animator anim,switch_button;
    public int power, sufficientPower;
    public enum Pietro 
	{
        pierwsze,drugie
	}
    public Pietro pietro;
	public void Action()
	{
        
        switch_button.SetTrigger("on");
	}

    public void CallLift()
	{
        if (power < sufficientPower) return;
        switch (pietro)
        {
            case Pietro.pierwsze:
                {
                    anim.SetTrigger("na_drugie");

                    pietro = Pietro.drugie;

                    break;
                }
            case Pietro.drugie:
                {
                    anim.SetTrigger("na_pierwsze");

                    pietro = Pietro.pierwsze;
                    break;
                }
        }
    }

    public void SetPower(int value)
	{
        power += value;
        if (power >= sufficientPower) lightIndicator.material = green;
        else lightIndicator.material = red;
	}

	
		

}
