using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Spawner spawnie;
    public Vector3 targetPosition;
    // public RectTransform pointerRectTransform;
    // public GameObject driver;
    // public Transform Target;
    // public GameObject currentlocation;
    // Start is called before the first frame update
    // public void Awake()
    // {
    //     spawnie.spawn();
    //     Debug.Log("itsme");
    //     targetPosition = Camera.main.transform.position;
    //     pointerRectTransform = GameObject.Find("Pointer");
    //     Debug.Log(targetPosition);
    //     Debug.Log("HEYEE");
        
    // }

    // Update is called once per frame
    void Update()
    {
        // Vector3 toPosition = targetPosition;
        // Vector3 fromPosition = driver.transform.position;
        // fromPosition.z = 0f;
        // Vector3 dir = (toPosition - fromPosition).normalized;
        // float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        // if (angle < 0)
        // {
        //     angle += 360;
        // }
        // pointerRectTransform.localEulerAngles= new Vector3(0,0,angle);
        if (spawnie == null)
        {
            return; 
        }
        var dir = spawnie.currentlocation.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
