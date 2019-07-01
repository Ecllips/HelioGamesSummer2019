using UnityEngine;
using UnityEngine.Events;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;
   

    void Start()
    {
        quiz1 = Random.Range(1, 101);
        quiz2 = Random.Range(1, 101);
        quiz3 = Random.Range(1, 101);
        quiz4 = Random.Range(1, 101);
        quiz5 = Random.Range(1, 101);

        average = (quiz1 + quiz2 + quiz3 + quiz4 +quiz5) / 5;

        if (average >= 90)
        {
            Debug.Log("You have an A");
        }
        else if (average >= 80 && average < 90)
        {
            Debug.Log("You have a B");
        }
        else if (average >= 70 && average < 80)
        {
            Debug.Log("You have a C");
        }
        else if (average >= 60 && average < 70)
        {
            Debug.Log("You have a D");
        }
        else if (average >= 50 && average < 60)
        {
            Debug.Log("You have a F");
        }
      
    }

}
