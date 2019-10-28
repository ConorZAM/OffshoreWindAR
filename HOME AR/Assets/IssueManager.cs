using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IssueManager : MonoBehaviour
{
    public Text[] issueCounts = new Text[3];    // indicies: 0 green, 1 amber, 2 red

    bool[] issues = new bool[5];
    int numGreen = 1;
    int numAmber = 1;
    int numRed = 3;

    public void UpdateIssue(int index)
    {
        issues[index] = true;
        int totalSolved = 0;
        int grandTotal = 0;
        // greens
        for (int i = 0; i < numGreen; i++)
        {
            totalSolved += (issues[i]) ? 1 : 0;
        }

        if (totalSolved == numGreen)
        {
            issueCounts[0].text = "No Issues";
        }
        else
        {
            issueCounts[0].text = "Issues: " + (numGreen - totalSolved).ToString();
        }

        grandTotal += totalSolved;
        totalSolved = 0;
        for (int i = numGreen; i < numGreen + numAmber; i++)
        {
            totalSolved += (issues[i]) ? 1 : 0;
        }

        if (totalSolved == numAmber)
        {
            issueCounts[1].text = "No Issues";
        }
        else
        {
            issueCounts[1].text = "Issues: " + (numAmber - totalSolved).ToString();
        }

        grandTotal += totalSolved;
        totalSolved = 0;
        for (int i = numGreen + numAmber; i < numGreen + numAmber + numRed; i++)
        {
            totalSolved += (issues[i]) ? 1 : 0;
        }

        if (totalSolved == numRed)
        {
            issueCounts[2].text = "No Issues";
        }
        else
        {
            issueCounts[2].text = "Issues: " + (numRed - totalSolved).ToString();
        }

        grandTotal += totalSolved;
        if (grandTotal == (numGreen + numAmber + numRed))
        {
            FindObjectOfType<CostCount>().CompleteGame();
        }
    }

    private void OnEnable()
    {
        int totalSolved = 0;
        // greens
        for (int i = 0; i < numGreen; i++)
        {
            totalSolved += (issues[i]) ? 1 : 0;
        }

        if (totalSolved == numGreen)
        {
            issueCounts[0].text = "No Issues";
        }
        else
        {
            issueCounts[0].text = "Issues: " + (numGreen - totalSolved).ToString();
        }


        totalSolved = 0;
        for (int i = numGreen; i < numGreen + numAmber; i++)
        {
            totalSolved += (issues[i]) ? 1 : 0;
        }

        if (totalSolved == numAmber)
        {
            issueCounts[1].text = "No Issues";
        }
        else
        {
            issueCounts[1].text = "Issues: " + (numAmber - totalSolved).ToString();
        }


        totalSolved = 0;
        for (int i = numGreen + numAmber; i < numGreen + numAmber + numRed; i++)
        {
            totalSolved += (issues[i]) ? 1 : 0;
        }

        if (totalSolved == numRed)
        {
            issueCounts[2].text = "No Issues";
        }
        else
        {
            issueCounts[2].text = "Issues: " + (numRed - totalSolved).ToString();
        }
    }

}
