using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    public int a = 10;


    public void SetMaxValue(int health)
    {
        slider.maxValue = health;
    }


    public void SetHealth(int health)
    {
        slider.value = health;
    }
    
}
