using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour
{
    public GameObject test;
    public GameObject look;
    public GameObject elements;


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
                Debug.Log("Hit Element");

                if (OVRInput.Get(OVRInput.Button.One))
                {
                    Debug.Log("Pressed A");
                    test.SetActive(true);
                    look.SetActive(true);
                    elements.SetActive(false);
                }

                //test.enabled = true;
            }

            if (hit.collider.gameObject.CompareTag("continueButton"))
                    {
                        if(OVRInput.Get(OVRInput.Button.One))
                        {
                            look.SetActive(false);
                            test.SetActive(false);
                            elements.SetActive(true);
                        }
                    }
        }

        if (hit.collider.gameObject.CompareTag("group1") && OVRInput.Get(OVRInput.Button.One))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

         if (hit.collider.gameObject.CompareTag("back") && OVRInput.Get(OVRInput.Button.One))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
