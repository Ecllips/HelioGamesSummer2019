using UnityEngine;
using UnityEngine.Events;

public class WeaponSelector : MonoBehaviour
{
    public int WeaponID;

   private void Start()
    {
       
    }
    private void Update()
    {
        /* if you want ot have it set to keys
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponID = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponID = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            WeaponID = 2;
        }
        */

        switch (WeaponID)
        {
            case 1:
                Debug.Log("Gun");
                break;
            case 2:
                Debug.Log("Knife");
                break;
            case 3:
                Debug.Log("Machine Gun");
                break;
            default:
                Debug.Log(" Invalid Weapon");
                break;

        }
    }

}
