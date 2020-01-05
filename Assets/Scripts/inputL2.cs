using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class inputL2 : MonoBehaviour
{
    public Text L2;
    public InputField input2;
    public float angle2;

    public GameObject lense2;
    public GameObject O2;
    public GameObject Glass;


    private float reduceA2;

    
    public void Start()
    {
        input2.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }
    
    public void ValueChangeCheck()
    {

        //errorcheck for no input
        if (input2.text == "")
        {
            angle2 = 0; 
        }
        else if (input2.text == "-")
        { }
        else
        {
            angle2 = float.Parse(input2.text);
        }

        //reduce the angle so it's not >360
        reduceA2 =angle2 / 360;
        
        if (reduceA2 >= 1)
        { reduceA2 = Mathf.Floor(reduceA2);
            angle2 = angle2 - 360 * reduceA2;
        }
        L2.text = "L2: " + angle2 + "°";
        lense2.transform.eulerAngles = new Vector3(0, 0, -angle2);
        O2.transform.eulerAngles = new Vector3(0, 0, -angle2);




    }
}
