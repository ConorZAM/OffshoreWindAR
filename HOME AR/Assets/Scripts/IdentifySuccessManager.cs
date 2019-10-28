using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifySuccessManager : MonoBehaviour
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

    public void ShowGraphic(bool correctAnswer, Transform sender)
    {
        if (correctAnswer)
        {
            correct.SetActive(true);
        }
        else
        {
            wrong.SetActive(true);
        }
        // Hide the root of the current panel
        sender.parent.parent.gameObject.SetActive(false);
    }
}
