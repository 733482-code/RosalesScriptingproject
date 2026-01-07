using UnityEngine;
using System.Collections;
using System.ComponentModel;

public class AnotherClass : MonoBehaviour
{
    public int aplles;
    public int bananas;



    private int stapler;
    private int sellotape;


    public void FruitMachine(int a, int b);
    {
        int answer;
    answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }