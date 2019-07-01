using UnityEngine;
using UnityEngine.Events;

public class LevelSelector2 : MonoBehaviour
{
    public int selectedLevel;

    private int _easy = 0;
    private int _medium = 1;
    private int _hard = 2;

    void Start()
    {
        selectedLevel = Random.Range(0, 3);
    }

    void Update()
    {
        /*
        if (selectedLevel == _easy)
        {
            Debug.Log("You selected easy!");
        }
        else if (selectedLevel == _medium)
        {
            Debug.Log("You selected medium!");
        }
        else if (selectedLevel == _hard)
        {
            Debug.Log("You selectd Hard!");
        }
        else
        {
            Debug.Log("Invalid level selected");
        }
        */

        switch (selectedLevel)
        {
            case 0: //easy
                Debug.Log("Easy");
                break;
            case 1: //medium
                Debug.Log("Medium");
                break;
            case 3: //hard
                Debug.Log("Hard");
                break;
            default:
                Debug.Log("Invalid Selection");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            selectedLevel = Random.Range(0, 3);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            selectedLevel = 55;
        }
    }

}
