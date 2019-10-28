using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostCount : MonoBehaviour
{
    public float rate = 1.5f;
    public bool running = false;
    float totalCost = 0f;
    Text costText;
    public Text labelText;
    public bool operations = false;

    // Start is called before the first frame update
    void Start()
    {
        costText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            totalCost += rate * Time.deltaTime;
        }
        costText.text = totalCost.ToString("C", new System.Globalization.CultureInfo("en-GB"));
    }

    public void IncreaseCost()
    {
        totalCost += 10000;
    }

    public void IncreaseCost(float cost)
    {
        totalCost += cost;
    }

    public void CompleteGame()
    {
        running = false;
        costText.color = Color.green;
        if (operations)
        {
            labelText.text = "Final Cost of Operations:";
        }
        else
        {
            labelText.text = "Final Cost of Maintenance:";
        }
        labelText.color = Color.green;
    }
}
