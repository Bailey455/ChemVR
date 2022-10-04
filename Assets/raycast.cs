using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right) * 250 * Time.deltaTime, out hit, 1000))
        {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.right) * 250 * Time.deltaTime, Color.yellow);
            Debug.Log("Did Hit");
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 250 * Time.deltaTime, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
