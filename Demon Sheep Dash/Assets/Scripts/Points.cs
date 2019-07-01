using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Points : MonoBehaviour
{
    //variable to store points
    [SerializeField]
    private int _points;

    [SerializeField]
    private bool _hasSaidMessageBeenSent;


    void Start()
    {

    }

    void Update()
    {
        //if we hit the space key
        //add 10 points

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }

        //if points is greather than or equal to 50 AND && OR hasSaidMessage is false
        //then print you are awesome!
        if (_points >= 50 && _hasSaidMessageBeenSent == false)
        {
            Debug.Log("You are awesome!");
            _hasSaidMessageBeenSent = true;
        }
    }
}

