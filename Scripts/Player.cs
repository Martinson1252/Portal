using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    public float money;
    public TextMeshProUGUI moneyUI;
    public TextMeshProUGUI data;
    // Start is called before the first frame update
    void Start()
    {
        data.text = System.DateTime.Now.Day+"."+System.DateTime.Now.Month+"."+System.DateTime.Now.Year;
    }

    public void ChangeMoney(float m)
	{
        money += m;
        moneyUI.text = (money).ToString();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
