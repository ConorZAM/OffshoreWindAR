using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifySuccess : MonoBehaviour
{
    GameObject correct;
    GameObject wrong;

    private void Start()
    {
        correct = GameObject.Find("Correct Graphic");
        wrong = GameObject.Find("Wrong Graphic");

        correct.SetActive(false);
        wrong.SetActive(false);
    }

    public bool correctAnswer;
    public int myFaultIndex;

    public void ShowGraphic()
    {
        FindObjectOfType<IdentifySuccessManager>().ShowGraphic(correctAnswer, transform);
        if (correctAnswer)
        {
            FindObjectOfType<FaultsFound>().AddFaultIdentified(myFaultIndex);
        }
    }
}
