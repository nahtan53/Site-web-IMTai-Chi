using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTrailHands : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void offTrail()
    {
        GameObject leftHand = GameObject.Find("mixamorig:LeftHand");
        GameObject rightHand = GameObject.Find("mixamorig:RightHand");

        if ((leftHand.GetComponent<TrailRenderer>().enabled == true) && (rightHand.GetComponent<TrailRenderer>().enabled == true))
        {
            leftHand.GetComponent<TrailRenderer>().enabled = false;
            rightHand.GetComponent<TrailRenderer>().enabled = false;
        }
        else
        {
            leftHand.GetComponent<TrailRenderer>().enabled = true;
            rightHand.GetComponent<TrailRenderer>().enabled = true;
        }

        GameObject leftHand1 = GameObject.Find("mixamorig1:LeftHand");
        GameObject rightHand1 = GameObject.Find("mixamorig1:RightHand");

        if ((leftHand1.GetComponent<TrailRenderer>().enabled == true) && (rightHand1.GetComponent<TrailRenderer>().enabled == true))
        {
            leftHand1.GetComponent<TrailRenderer>().enabled = false;
            rightHand1.GetComponent<TrailRenderer>().enabled = false;
        }
        else
        {
            leftHand1.GetComponent<TrailRenderer>().enabled = true;
            rightHand1.GetComponent<TrailRenderer>().enabled = true;
        }
    }
}
