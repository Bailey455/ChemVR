using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class raycast : MonoBehaviour
{ 
    public GameObject test;
    public GameObject elements;

    public GameObject num1Box;
    public GameObject num2Box;
    public GameObject num3Box;
    public GameObject num4Box;
    public GameObject try_again;
    public GameObject good_job;

    public GameObject equation; 

    public static int num1;
    public static int num2;
    public static int num3;
    public static int num4;

    public void Start()
    {
        num1 = 0;
        num2 = 0;
        num3 = 0;
        num4 = 0;

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; 

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, out hit, 1000))
        {
            Debug.DrawRay(this.transform.position, this.transform.TransformDirection(Vector3.forward) * 500 * Time.deltaTime, Color.yellow);
            //Debug.Log("Did Hit");

            //checking for first 20 elements
            if (hit.collider.gameObject.CompareTag("Element"))
            {
                //Debug.Log("Hit Element");
 
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    Debug.Log("Pressed A");
                    test.SetActive(true);
                    elements.SetActive(false);
                }
            }

            //checking for continue buttons
            else if (hit.collider.gameObject.CompareTag("continueButton"))
                    {
                        if(OVRInput.GetDown(OVRInput.Button.One))
                        {
                            test.SetActive(false);
                            elements.SetActive(true);
                        }
                    }

            //check for ending
            else if (hit.collider.gameObject.CompareTag("exit") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Application.Quit();
                //Debug.Log("hit exit button");
            }

            //going to the respectives scenes for the groups of elements
            else if (hit.collider.gameObject.CompareTag("nonmetal") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (hit.collider.gameObject.CompareTag("halogen") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
            else if (hit.collider.gameObject.CompareTag("noblegas") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }

            else if (hit.collider.gameObject.CompareTag("lanthanide") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            }
            else if (hit.collider.gameObject.CompareTag("actinide") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
            }
            else if (hit.collider.gameObject.CompareTag("alkalimetal") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
            }
            else if (hit.collider.gameObject.CompareTag("alkaliearth") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
            }
            else if (hit.collider.gameObject.CompareTag("transitionmetal") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
            }
            else if (hit.collider.gameObject.CompareTag("basicmetal") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
            }
            else if (hit.collider.gameObject.CompareTag("semimetal") && OVRInput.GetDown(OVRInput.Button.One))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
            }

            //returning to the home scene when the player presses back
            else if (hit.collider.gameObject.CompareTag("back") && OVRInput.GetDown(OVRInput.Button.One))
            {
                    if(SceneManager.GetActiveScene().buildIndex == 1)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 3)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 4)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
                    } 
                    else if(SceneManager.GetActiveScene().buildIndex == 5)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
                    } 
                    else if(SceneManager.GetActiveScene().buildIndex == 6)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 7)
                    { 
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 8)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 9)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
                    }
                    else if(SceneManager.GetActiveScene().buildIndex == 10)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
                    }
            }


            //checking up arrows for calculating chemical equations
            else if (hit.collider.gameObject.CompareTag("up1") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num1");
                num1 += 1;
                setText(num1Box, num1);
            }
            else if (hit.collider.gameObject.CompareTag("up2") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num2");
                num2 += 1;
                setText(num2Box, num2);
            }
            else if (hit.collider.gameObject.CompareTag("up3") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num3");
                num3 += 1;
                setText(num3Box, num3);
            }
            else if (hit.collider.gameObject.CompareTag("up4") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num4");
                num4 += 1;
                setText(num4Box, num4);
            }

            //checking down arrows for calculating chemical equations
            else if (hit.collider.gameObject.CompareTag("down1") && OVRInput.GetDown(OVRInput.Button.One))
            {
                if (num1 > 0)
                    num1 -= 1;
                else
                    num1 = 0;
                setText(num1Box, num1);
            }
            else if (hit.collider.gameObject.CompareTag("down2") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num2");
                if (num2 > 0)
                    num2 -= 1;
                else
                    num2 = 0; 
                setText(num2Box, num2);
                
            }
            else if (hit.collider.gameObject.CompareTag("down3") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num3");
                if (num3 > 0)
                    num3 -= 1;
                else
                    num3 = 0;
                setText(num3Box, num3);
            }
            else if (hit.collider.gameObject.CompareTag("down4") && OVRInput.GetDown(OVRInput.Button.One))
            {
                Debug.Log("found num4");
                if(num4 > 0)
                    num4 -= 1;
                else
                    num4 = 0;
                setText(num4Box, num4);
            }

            else if (formulas.isCorrect == true && OVRInput.GetDown(OVRInput.Button.One) && hit.collider.gameObject.CompareTag("next_button"))
            {
                equation.SetActive(false);
                good_job.SetActive(true);

            }
            

            else if(formulas.isCorrect == false && OVRInput.GetDown(OVRInput.Button.One) && hit.collider.gameObject.CompareTag("next_button"))
            {
                equation.SetActive(false);
                try_again.SetActive(true);
            }

            else if (hit.collider.gameObject.CompareTag("keep_trying") && OVRInput.GetDown(OVRInput.Button.One))
            {
                equation.SetActive(true);
                good_job.SetActive(false);
                try_again.SetActive(false);
            }
            else if(hit.collider.gameObject.CompareTag("next_question") && OVRInput.GetDown(OVRInput.Button.One))
            {
                equation.SetActive(true);
                try_again.SetActive(false);
                good_job.SetActive(false);

                num1 = 0;
                num2 = 0; 
                num3 = 0;
                num4 = 0;
                setText(num1Box, num1);
                setText(num2Box, num2);
                setText(num3Box, num3);
                setText(num4Box, num4);
            }
        }
    }

    void setText(GameObject obj, int num)
    {
        obj.GetComponent<TMP_Text>().text = num.ToString();
    }
}
