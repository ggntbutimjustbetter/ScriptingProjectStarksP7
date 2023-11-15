using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Scripting;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTempereature = 40.0f;
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            TemperatureTest(); 

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        //If the coffee's temperature is greater than the hottest drinking tempurature...
        if(coffeeTemperature < hotLimitTemperature)
        {
            //...do this.
            print("Coffe is too hot.");
        }

    // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
    else if(coffeeTemperature < coldLimitTempereature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        //If it is neeither of thosee then...
        else
        {
            // ... do this
            print("Coffeee is just right.");
        }
    }
}
