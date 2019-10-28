using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaultsFound : MonoBehaviour
{
    public bool[] faultFound;
    Text label;

    public void AddFaultIdentified(int index)
    {
        faultFound[index] = true;
        int totalFound = 0;
        for (int i = 0; i < faultFound.Length; i++)
        {
            totalFound += (faultFound[i]) ? 1 : 0;
        }


        if (totalFound == faultFound.Length)
        {
            FindObjectOfType<CostCount>().CompleteGame();
            label.text = "Inspection complete, good job!";
        }
        else
        {
            label.text = "Tap on and identify " + (faultFound.Length - totalFound).ToString() + " more faults";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        label = GetComponent<Text>();
        label.text = "Tap on and identify " + faultFound.Length.ToString() + " faults";
    }
}
