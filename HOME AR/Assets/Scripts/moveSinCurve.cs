using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSinCurve : MonoBehaviour
{
    Vector3 startPos;
    float startTime;
    float duration = 8f;
    // Start is called before the first frame update
    void Awake()
    {
        startPos = transform.localPosition;
        startTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup - startTime < duration)
        {
            transform.localPosition = new Vector3(startPos.x + 0.6f * Mathf.Sin(Time.time * 1.5f), startPos.y, transform.localPosition.z - (1f * Time.deltaTime));
        }
        else if (Time.realtimeSinceStartup - startTime < duration * 2f)
        {
            transform.localPosition = new Vector3(startPos.x + 0.6f * Mathf.Sin(Time.time * 1.5f), startPos.y, transform.localPosition.z + 1f * Time.deltaTime);
        }
        else
        {
            startTime = Time.realtimeSinceStartup;
        }
    }
}
