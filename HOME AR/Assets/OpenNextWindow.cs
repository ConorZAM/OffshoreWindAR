using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenNextWindow : MonoBehaviour
{
    public GameObject nextWindow;
    public float cost;
    public Text costLabel;
    public int issueIndex;

    private void OnEnable()
    {
        costLabel.text = "\n" + cost.ToString("C", new System.Globalization.CultureInfo("en-GB"));
    }

    public void GoToNext()
    {
        nextWindow.SetActive(true);
        transform.parent.gameObject.SetActive(false);
        FindObjectOfType<IssueManager>().UpdateIssue(issueIndex);
    }
}
