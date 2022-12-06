using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class formulas : MonoBehaviour
{
    public GameObject chem1; 
    public GameObject chem2;
    public GameObject chem3;
    public GameObject chem4;

    private int correctNum1;
    private int correctNum2;
    private int correctNum3;
    private int correctNum4;

    //private int problemNum;
    public static bool isCorrect;


    public void Start()
    {
        isCorrect = false;

        setText(chem1, "C<sub>6</sub>H<sub>12</sub>O<sub>6</sub>");
        setText(chem2, "O<sub>2</sub>");
        setText(chem3, "CO<sub>2</sub>");
        setText(chem4, "H<sub>2</sub>O");

        correctNum1 = 0;
        correctNum2 = 6;
        correctNum3 = 6;
        correctNum4 = 6;


    }

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(raycast.num1);
        if(raycast.num1 == correctNum1 && raycast.num2 == correctNum2 && raycast.num3 == correctNum3 && raycast.num4 == correctNum4)
        {
            isCorrect = true;
        }
    }

    public void setText(GameObject obj, string text)
    {
        obj.GetComponent<TMP_Text>().text = text;
    }
}