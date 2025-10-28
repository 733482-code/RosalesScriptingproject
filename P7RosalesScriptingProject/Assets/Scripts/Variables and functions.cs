using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablesandfunctions : MonoBehaviour
{
    int myint = 6;
    // Start is called before the first frame update
    void Start()
    {
        myint = MutiplyByTwo(myint);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MutiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}


