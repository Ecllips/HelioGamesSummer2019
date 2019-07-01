using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class HowFast : MonoBehaviour
{
    public int speed;
    public int maxSpeed;

    private void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(speedRoutine());
    }

    private void upstate()
    {

    }

    IEnumerator speedRoutine()
    {
       
        do
        {
            speed += 5;
            yield return new WaitForSeconds(1.0f);

        } while (speed < maxSpeed);
    }
}


// or you can use
/* while (true)
        {
            yield return new WaitForSeconds(1.0f);
speed += 5;

            //if speed is greater than max speed
            //then break out of loop

            if (speed > maxSpeed)
            {
                break;
            }
        }
        */