using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Item : MonoBehaviour,Interactable
{
	Action Do;
	interaction parentObj;
	float distance;
    public bool isTaken;
	Vector3 hit,dir;
	public void Action()
	{
		if (isTaken) Drop(); else Take();
	}

	void Take()
	{
		isTaken = true;
		GameObject Player = FindObjectOfType<FirstPersonController>().transform.gameObject;
		parentObj = Player.GetComponent<interaction>();
		gameObject.transform.parent = Player.transform.GetChild(1);
		distance = parentObj.keepDistance;
		Do += KeepVector;
	}

	void Drop()
	{
		isTaken = false;
		GameObject Player = FindObjectOfType<FirstPersonController>().transform.gameObject;
		gameObject.transform.parent = null;
		Do -= KeepVector;
		Player.transform.GetChild(1).transform.DetachChildren();
		gameObject.GetComponent<Rigidbody>().velocity *= 0.2f;
	}

    // Update is called once per frame
    void Update()
    {
		Do?.Invoke();
    }

	void KeepVector()
	{
		transform.position = Camera.main.transform.position + (Camera.main.transform.forward*parentObj.keepDistance);
		transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
		transform.Rotate( Vector3.up* Input.mouseScrollDelta.y * 5);
	}


	private void OnDrawGizmos()
	{
		Debug.DrawLine(Camera.main.transform.position, 
			Camera.main.transform.position+ (Camera.main.transform.forward * distance), Color.magenta);
	}

}
