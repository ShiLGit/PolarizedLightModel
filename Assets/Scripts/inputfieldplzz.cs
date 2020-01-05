using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class inputfieldplzz : MonoBehaviour {
    public InputField input1;
    public float angle1;

    public GameObject lense1;
    public GameObject O1;
    public Text L1;
    private inputL2 in2;

    private float reduceA1;
    public void Start()
    {
        input1.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        angle1 = 0;
    }


    public void ValueChangeCheck()  
    {
        //errorcheck for no input
        if (input1.text == "")
        {
            angle1 = 0;
        }
        //so error doesn't show when it tries converting "-" to float
        else if (input1.text == "-")
        { }
        else
        { angle1 = float.Parse(input1.text); }


        //reduce angle so L1<360
        reduceA1 = angle1 / 360;

        if (reduceA1 >= 1)
        {
            reduceA1 = Mathf.Floor(reduceA1);
            angle1 = angle1 - 360 * reduceA1;
        }
        L1.text = "L1: " + angle1 + "°";
        lense1.transform.eulerAngles = new Vector3(0, 0, -angle1);
        O1.transform.eulerAngles = new Vector3(0, 0, -angle1);


    }
}
