using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    //every item has a name
    //every item has a description
    //every item has a image icon
    //every item has an attack strength
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrength;
    void Start()
    {
        Debug.Log("Name; " + itemName);
        Debug.Log("Description" + itemDescription);
        Debug.Log("Attack: " + attackStrength);
    }

}
