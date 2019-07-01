using UnityEngine;
using UnityEngine.Events;

public class TipCalculator : MonoBehaviour
{
    //bill is 40
    //tip is 20% or based on what the user wants
    //calculate total amount
    public int bill = 40;
    public float tip = 20.0f;
    public float totalAmount;

    void Start()
    {
        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;

        Debug.Log("Your bill is: " + bill + " and your tip amount is: " + tipAmount + " So you owe " + totalAmount);

    }

}
