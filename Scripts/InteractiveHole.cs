using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveHole : MonoBehaviour
{
    public Material red, green;
	public Room room;
	public bool active;
	public int id;
	public int value;
	public int objectsCount;
	private void OnTriggerEnter(Collider other)
	{
		if (objectsCount<1 && other.transform.GetComponent(typeof(Interactable)))
		{
			gameObject.GetComponent<MeshRenderer>().material = green;
			active = true;
			value = 1;
			room.HolesAction(id);
		}
			if(other.transform.GetComponent(typeof(Interactable))) objectsCount++;
	}

	private void OnTriggerExit(Collider other)
	{
		if (objectsCount==1 && other.transform.GetComponent(typeof(Interactable)))
		{
			gameObject.GetComponent<MeshRenderer>().material = red;
			active = false;
			value = -1;
			room.HolesAction(id);
		}
		if(other.transform.GetComponent(typeof(Interactable))) objectsCount--;
	}


}
