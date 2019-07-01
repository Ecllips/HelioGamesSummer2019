using UnityEngine;
using UnityEngine.Events;

public class LevelSelector : MonoBehaviour
{
    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    void Start()
    {
        currentDifficulty = mediumDifficulty;
    }

    void Update()
    {
        if (currentDifficulty == easyDifficulty)
        {
            Debug.Log("You selected easy");
        }
        else if (currentDifficulty == mediumDifficulty)
        {
            Debug.Log("You selected medium");
        }
        else if (currentDifficulty == hardDifficulty)
        {
            Debug.Log("You selectd Hard");
        }
        else
        {
            Debug.Log("Invalid level selected");
        }
    }

}



