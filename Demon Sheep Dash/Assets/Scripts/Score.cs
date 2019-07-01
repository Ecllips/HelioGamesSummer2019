using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public GameObject cube;
    public int score;

    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && score <= 50)
        {
            score += 25;
        }
        if (score > 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}