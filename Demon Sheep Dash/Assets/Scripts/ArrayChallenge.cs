using UnityEngine;
using UnityEngine.Events;

public class ArrayChallenge : MonoBehaviour
{
    public string[] names;
    public string[] ages;
    public string[] cars;

    void Start()
    {
        Debug.Log(names[4]);
        Debug.Log(ages[4]);
        Debug.Log(cars[4]);
    }

}
