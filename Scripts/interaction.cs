using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class interaction : MonoBehaviour
{
    public Action DO;
    public GameObject holder;
    public RaycastHit hit;
    public float keepDistance;
    public LayerMask interactionLayerMask;
    KeyCode ButtonsCheck()
	{
        if(Input.GetKeyDown(KeyCode.E))
		{
            return KeyCode.E;
		}
        if (Input.GetMouseButtonDown(1)) return KeyCode.Mouse1;
        return KeyCode.None;
	}

    // Update is called once per frame
    void Update()
    {
        Raycast();
        DO?.Invoke();
    }


   void Raycast()
	{
       
         if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward,out hit,2,interactionLayerMask))
		{
            //Debug.Log(hit.collider.name);

            if(ButtonsCheck() == KeyCode.E)
			{
                if(hit.collider.GetComponent(typeof(Interactable))  )
			    {
                    keepDistance = hit.distance;
                    hit.collider.GetComponent<Interactable>().Action();
			    }
                
                
			}

            if(ButtonsCheck()== KeyCode.Mouse1)
			{
                if (hit.collider.GetComponent(typeof(Interactable)))
                {
                    if(holder.transform.childCount!=0)
					{
                        hit.collider.GetComponent<Interactable>().Action();
                        hit.collider.attachedRigidbody.AddForce(Camera.main.transform.forward*5,ForceMode.Impulse);
					}

                }
            }
           
		}
         
	}

	private void OnDrawGizmos()
	{
        Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.position+(Camera.main.transform.forward*2),Color.blue);
       // Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward);
       
	}

  

}
