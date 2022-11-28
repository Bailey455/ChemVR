using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formulas : MonoBehaviour
{
    public GameObject chem1;
    public GameObject chem2;
    public GameObject chem3;
    public GameObject cem4;

    public int correctNum1;
    public int correctNum2;
    public int correctNum3;
    public int correctNum4;

    public int problemNum;
    public static bool isCorrect;


    void Start()
    {
        isCorrect = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(raycast.num1 == correctNum1 && raycast.num2 == correctNum2 && raycast.num3 == correctNum3 && raycast.num4 == correctNum4)
        {
            isCorrect = true;
        }

        else
        {
            isCorrect = false;
        }

    }

    void setText(GameObject obj, int num)
    {
        obj.GetComponent<TMP_Text>().text = num.ToString();
    }
}
