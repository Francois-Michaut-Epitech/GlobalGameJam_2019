using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class travellingCamera : MonoBehaviour
{
    public GameObject target;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

        transform.position = targetPosition;
    }
}
