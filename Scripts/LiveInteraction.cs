using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LiveInteraction : MonoBehaviour
{
	Action Do;
    public ParticleSystem sparks;
	public Animator garageDoorAnim;
	public void Action()
	{
		StartSparks();
	}

	void StartSparks()
	{
		Do += () => sparks.Play();
		sparks.Play();
		StartCoroutine(Wait(Do));
		Do = null;
		Do += () => garageDoorAnim.SetTrigger("up");
		StartCoroutine(Wait(Do));
	}

	IEnumerator Wait(Action DO)
	{
	yield return new WaitForSecondsRealtime(1.5f);
		DO();
	}
}



