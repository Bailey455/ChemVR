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

            if (hit.collider.gameObject.CompareTag("nonmetal") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            /*
            if (hit.collider.gameObject.CompareTag("halogen") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }

             if (hit.collider.gameObject.CompareTag("noblegas") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }

             if (hit.collider.gameObject.CompareTag("lanthanide") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            }
             if (hit.collider.gameObject.CompareTag("actinide") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
            }
             if (hit.collider.gameObject.CompareTag("alkalimetal") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
            }
             if (hit.collider.gameObject.CompareTag("alkaliearth") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            }
             if (hit.collider.gameObject.CompareTag("transitionmetal") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
            }
             if (hit.collider.gameObject.CompareTag("basicmetal") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
            }
             if (hit.collider.gameObject.CompareTag("semimetal") && OVRInput.Get(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
            }
            */

            if (hit.collider.gameObject.CompareTag("back") && OVRInput.Get(OVRInput.Button.One))
            {
                /*
                    if(SceneManager.GetActiveScene().buildIndex == 1)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    }
                     if(SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                    }
                     if(SceneManager.GetActiveScene().buildIndex == 3)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
                    }
                     if(SceneManager.GetActiveScene().buildIndex == 4)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
                    } if(SceneManager.GetActiveScene().buildIndex == 5)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
                    } 
                    if(SceneManager.GetActiveScene().buildIndex == 6)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                    }
                     if(SceneManager.GetActiveScene().buildIndex == 7)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
                    }
                     if(SceneManager.GetActiveScene().buildIndex == 8)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
                    }
                     if(SceneManager.GetActiveScene().buildIndex == 9)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
                    }
                */

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }
}
