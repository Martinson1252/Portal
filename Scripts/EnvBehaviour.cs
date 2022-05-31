using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EnvBehaviour : MonoBehaviour
{
    System.Random rand = new System.Random();
    public GameObject Coin;
    Transform cPos;
    public GameObject miniMenu;
    Action LockCamera;
    Vector3 CenterPos;
    float amount;
    // Start is called before the first frame update
    void Start()
    {
        CenterPos = cPos.transform.position;
        amount = rand.Next(0, 25);
        for(int i=0;i<amount;i++)
		{
           GameObject C = Instantiate(Coin);
            C.transform.position = new Vector3(CenterPos.x + rand.Next(-8, 8), 1.8f,CenterPos.z+rand.Next(-8,8));
		}
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
		{ 
            switch(miniMenu.activeSelf)
			{

                case false:
                    {
                        Quaternion pos = Camera.main.transform.rotation;
                        LockCamera += () => { Camera.main.transform.rotation = pos; };
                        miniMenu.SetActive(true);
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                        break;
                        //Camera.main.transform.rotation = Quaternion.identity;
                    }

                case true: 
                    {
                        LockCamera = null;
                        miniMenu.SetActive(false);
                        Cursor.visible = false;
                        Cursor.lockState = CursorLockMode.Locked;
                        break;
                    }
            }
        }
        LockCamera?.Invoke();
    }
}
