using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{






    public int maxHealth = 100;
    public int currentHealth;

    public Slider healthBar;

    public Slider diffHealth;

    private float value;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.maxValue = maxHealth;

        diffHealth.maxValue = maxHealth;
        diffHealth.value = currentHealth;
       
    }

   


    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
            
            Debug.Log("키가 눌렸습니다.");

        }
    }



    IEnumerator UpdateSlider(Slider slider)
    {
        float healthDecreasePerSec = maxHealth / 10f*3;
        
        while(slider.value > currentHealth)
        {


           
            slider.value -= healthDecreasePerSec * Time.deltaTime;
            Debug.Log("줄어듬");
            yield return null;

        }

       
    }




    IEnumerator WaitAndDiff()
    {
       
        yield return new WaitForSeconds(1.5f);

        if (healthBar.value <= currentHealth)
        {
            StopCoroutine(WaitAndDiff());
            WaitAndDiff();
        }


        StartCoroutine(UpdateSlider(diffHealth));
        Debug.Log("1초 지났습니다.");

    }





    void TakeDamage(int damage) {
        currentHealth -= damage;


        //healthBar.value = currentHealth;

        //corutine = WaitAndDiff(1.0f);
        //sliderUpdate = UpdateSlider(healthBar);


        StartCoroutine(UpdateSlider(healthBar));
        StartCoroutine(WaitAndDiff());
    }

}
