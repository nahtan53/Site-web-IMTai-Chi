using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTrailLegs : MonoBehaviour
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
        GameObject leftLeg = GameObject.Find("mixamorig:LeftLeg");
        GameObject rightLeg = GameObject.Find("mixamorig:RightLeg");

        if ((leftLeg.GetComponent<TrailRenderer>().enabled == true) && (rightLeg.GetComponent<TrailRenderer>().enabled == true))
        {
            leftLeg.GetComponent<TrailRenderer>().enabled = false;
            rightLeg.GetComponent<TrailRenderer>().enabled = false;
        }
        else
        {
            leftLeg.GetComponent<TrailRenderer>().enabled = true;
            rightLeg.GetComponent<TrailRenderer>().enabled = true;
        }

        GameObject leftLeg1 = GameObject.Find("mixamorig1:LeftLeg");
        GameObject rightLeg1 = GameObject.Find("mixamorig1:RightLeg");

        if ((leftLeg1.GetComponent<TrailRenderer>().enabled == true) && (rightLeg1.GetComponent<TrailRenderer>().enabled == true))
        {
            leftLeg1.GetComponent<TrailRenderer>().enabled = false;
            rightLeg1.GetComponent<TrailRenderer>().enabled = false;
        }
        else
        {
            leftLeg1.GetComponent<TrailRenderer>().enabled = true;
            rightLeg1.GetComponent<TrailRenderer>().enabled = true;
        }


    }
}
