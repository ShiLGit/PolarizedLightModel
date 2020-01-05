using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpacityChange : MonoBehaviour {

    public GameObject Lo1;
    public GameObject Lo2;
    public GameObject Lo3;

    public Text Int2;
    public Text Int3;
    public float opacity;
    private float intOpacity;

    private inputfieldplzz in1;
    private inputL2 in2;
    private inputL3 in3;

    public float a1;
    public float a2;
    public float a3;

    public GameObject Amp2;
    public GameObject Amp1;
    public GameObject Amp3;

    private float size1;
    private float size2;


	// Use this for initialization
	void Start () {
        in1 = Lo1.GetComponent<inputfieldplzz>();
        in2 = Lo2.GetComponent<inputL2>();
        in3 = Lo3.GetComponent<inputL3>();

        opacity = 0;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, opacity);

        newScale(Amp1, 1);
        newScale(Amp2, 1);
        newScale(Amp3, 1);
    }
	
	// Update is called once per frame
	void Update () {

        a1 = in1.angle1;
        a2 = in2.angle2;
        a3 = in3.angle3;

       opacity = Mathf.Cos((Mathf.PI/180)*(a3 - a2));
       opacity = opacity * opacity;

        //THIS IS INTENSITY AFTER FIRST POLARIZATION
        Int2.text = "";
        Int3.text = "";

        intOpacity = opacity; //I=cos^2(x)
      
        opacity =  Mathf.Cos((Mathf.PI / 180) * (a1 - a2)); //cos^2(x1)
        opacity = intOpacity * opacity * opacity; //I'=Icos^2(x1)
        Int3.text = 0.5 * (Mathf.Round(opacity*100))  + "%";
        opacity = 1 - Mathf.Abs(opacity);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, opacity);

 
        Int2.text = 0.5 * (Mathf.Round(intOpacity*100))  + "%";

        //RESIZE AMPLITUDES
        size2 = Mathf.Abs(Mathf.Cos((Mathf.PI / 180) * (a3 - a2)));
        if (size2 < 0.01f) { size2 = 0.01f; }
        newScale(Amp2, size2);

        size1 = size2 * Mathf.Abs(Mathf.Cos((Mathf.PI / 180) * (a2 - a1)));
        if (size1 < 0.01f) { size1 = 0.01f; }
        newScale(Amp1, size1);


    }


    //RESIZING
    public void newScale(GameObject theGameObject, float newSize)
    {

        float size = theGameObject.GetComponent<Renderer>().bounds.size.y;

        Vector3 rescale = theGameObject.transform.localScale;

        rescale.y = newSize * rescale.y / size;

        theGameObject.transform.localScale = rescale;

    }


}

