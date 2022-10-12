using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, out hit))
        {
            //Debug.Log(hit);
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, Color.yellow);

            if (hit.collider.CompareTag("Element"))
            {
                Debug.Log("Hit Element");
            }

            else if (hit.collider.CompareTag("Wall"))
            {
                Debug.Log("Did Wall");
            }

        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, Color.white, 1000);
            //Debug.Log("Did not Hit");
        }
    }
}
