using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideMyParent : MonoBehaviour
{
    public void HideParent()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
