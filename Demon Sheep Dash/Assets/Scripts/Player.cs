using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public string myName = "Lee";
    public int myAge = 30;
    public string myLocation = "Salt Lake City";
    public float mySpeed = 10.5f;
    public int health = 100;
    public int score = 120;
    public bool hasAllKeys;
    public int ammoCount = 66;


    public GameObject player;
    public Animator anim;
    public Transform myTransform;

    void Start()
    {
        Debug.Log("My name is: " + myName + " and I am " + myAge + "years old");
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("Has All Keys;" + hasAllKeys);
        Debug.Log("Ammo Count: " + ammoCount);

    }

}
