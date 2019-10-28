using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class DamageDetecting : MonoBehaviour
{
    [System.Serializable]
    public class Detectable
    {
        public GameObject infoGraphic;
        public string tag;
    }

    RaycastHit hitObject;
    public Detectable[] detectables;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began
            && (EventSystem.current.IsPointerOverGameObject(0) == false))
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            if(Physics.Raycast(ray, out hitObject))
            {
                for (int i = 0; i < detectables.Length; i++)
                {
                    if (detectables[i].tag == hitObject.transform.tag)
                    {
                        detectables[i].infoGraphic.SetActive(true);
                        break;
                    }
                }
            }
        }
    }
}
