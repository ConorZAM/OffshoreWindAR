using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCost : MonoBehaviour
{
    public CostCount cost;

    private void OnEnable()
    {
        cost.IncreaseCost();
    }
}
