using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPanel : MonoBehaviour
{
    public float costOfStory;
    bool awarded = false;

    private void OnEnable()
    {
        if (!awarded)
        {
            FindObjectOfType<CostCount>().IncreaseCost(costOfStory);
            awarded = true;
        }
    }
}
