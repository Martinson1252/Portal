using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    public Slider lightSlide;
    public Slider rotatSlide;
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame()
	{
        SceneManager.LoadScene(0);
	}

    public void ChangeLight()
	{
        light.shadowStrength = lightSlide.value; 
	}

    public void ChangeLightRotation()
	{
        light.transform.localEulerAngles =  new Vector3(light.transform.localEulerAngles.x, rotatSlide.value, light.transform.localEulerAngles.z);
	}
}
