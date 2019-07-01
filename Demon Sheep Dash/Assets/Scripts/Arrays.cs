using UnityEngine;
using UnityEngine.Events;

public class Arrays : MonoBehaviour
{
    //deckare the size (how many element(s) through the inspector, most used method
    public string[] names;
    //public string[] names = new string[5]; if not using unity.
    //public string[] items = new string[5];

    public int[] ages = new int[] { 5, 3, 2, 55, 66 };

   private void Start()
    {
        Debug.Log(names[0]);
        Debug.Log(ages[3]);
    }

}
