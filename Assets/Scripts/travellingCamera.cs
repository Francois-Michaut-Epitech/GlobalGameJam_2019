using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class travellingCamera : MonoBehaviour
{
    GameObject target;

    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Ethan");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

        transform.position = targetPosition;
    }
}
