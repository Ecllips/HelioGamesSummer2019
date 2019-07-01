using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NumberPrinter : MonoBehaviour
{
    //Create a program that prints out 0-10 and then prints only even numbers to 20 and ony odd numbers to 30
    private void Start()
    {
       for (int i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                Debug.Log(i);
            }

            //only print out evens
            if (i > 9 && i < 21)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
            else if (i > 20)
            {
                if (i % 2 == 1)
                {
                    Debug.Log(i);
                }
            }
        }
        
    }

}
