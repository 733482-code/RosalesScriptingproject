using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
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
    {
        // ... do this.
        print("coffee is Too hot.");
    }
    // if isn't, but the coffee temperture is less than the coldest drinking temerpture...
    else if(coffeeTemperture < coldLimitTemperture)
    {
        // ... do this.
        print("Coffee is too cold");
        )
        // if it is neither of those then...
        else
        { 
            // ... do this.
            fsJsonPrinter()

