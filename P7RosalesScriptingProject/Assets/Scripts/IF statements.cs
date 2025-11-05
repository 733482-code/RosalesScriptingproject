using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFstatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperture -= Time.deltaTime * 5f;
    }
}



void TempertureTest ()
{
    // If the coffee's temperture is greater yjan the hottest drinking temperture...
    if (coffeeTemperture > hotLimitTemperture)
}