using UnityEngine;
using UnityEngine.Events;

public class SpeedController : MonoBehaviour
{
    public int speed = 0;

    private void Start()
    {
        // or you can put speed = 0;  here to set the speed at 0
    }


   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 5;
        }

      if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
        }
        if (speed > 20)
        {
            Debug.Log("Slow down!");
        }
        else if (speed == 0)
        {
            Debug.Log("Speed up!");
        }
        if (speed < 0)
        {
            speed = 0;
        }
    }
}
