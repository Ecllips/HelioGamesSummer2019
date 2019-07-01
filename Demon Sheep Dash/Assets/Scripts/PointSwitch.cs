using UnityEngine;
using UnityEngine.Events;

public class PointSwitch : MonoBehaviour
{
    public int points;

    private void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        switch (points)
        {
            case 50: //q
                Debug.Log("Points are 50!");
                break;
            case 100: //w
                Debug.Log("Points are 100!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to recieve a message");
                break;  
        }

    }
}
