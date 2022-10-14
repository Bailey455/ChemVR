using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class raycast : MonoBehaviour
{
    public TextMeshProUGUI test;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, out hit, 1000))
        {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, Color.yellow);
            //Debug.Log("Did Hit");

            if (hit.collider.gameObject.CompareTag("Element"))
            {
                //Debug.Log("Hit Element");

                if (OVRInput.Get(OVRInput.Button.One))
                {
                    //Debug.Log("Pressed A");
                    test.gameObject.SetActive(true);
                }
                //test.enabled = true;
            }
            /*else
            {
                Debug.Log("Hit something");
            }
            */
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, Color.white);
            //Debug.Log("Did not Hit");
        }
    }
}
