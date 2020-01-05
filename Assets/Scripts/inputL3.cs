using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class inputL3 : MonoBehaviour
{
    public InputField input3;
    public float angle3;
    
    public GameObject lense3;
    public GameObject O3;
    public Text L3;

    private float reduceA3;


    public void Start()
    {
        input3.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck()
    {

        //errorcheck for no input
        if (input3.text == "")
        {
            angle3 = 0;
        }
        else if (input3.text == "-")
        { }
        else
        {
            angle3 = float.Parse(input3.text);
        }

        reduceA3 = angle3 / 360;

        if (reduceA3 >= 1)
        {
            reduceA3 = Mathf.Floor(reduceA3);
            angle3 = angle3 - 360 * reduceA3;
        }

        L3.text = "L3: " + angle3 + "°";
        lense3.transform.eulerAngles = new Vector3(0, 0, -angle3);
        O3.transform.eulerAngles = new Vector3(0, 0, -angle3);

    }
}
