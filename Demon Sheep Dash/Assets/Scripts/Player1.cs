using UnityEngine;
using UnityEngine.Events;

public class Player1 : MonoBehaviour
{
    public int myAge = 26;
    private int _legalAgeToDrive = 16;

    void Start()
    {
        //if condition
        //then run code
        //EXAPMLE
        //if myAgeis greater than or equal to 16 (legal age to drive)
        //then print out you can drive
        //else
        //print out you can't drive

       if (myAge >= 16)
        {
            Debug.Log("You can drive");
        }
        else
        {
            Debug.Log("You Can't Drive");
        }
    }

}
