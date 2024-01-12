using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTrailGravityCenter : MonoBehaviour
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
        GameObject centreGravite = GameObject.Find("MassCenterRenping");

        if ((centreGravite.GetComponent<TrailRenderer>().enabled == true))
        {
            centreGravite.GetComponent<TrailRenderer>().enabled = false;
        }
        else
        {
            centreGravite.GetComponent<TrailRenderer>().enabled = true;
        }

        GameObject centreGravite1 = GameObject.Find("MassCenterFosco");

        if ((centreGravite1.GetComponent<TrailRenderer>().enabled == true))
        {
            centreGravite1.GetComponent<TrailRenderer>().enabled = false;
        }
        else
        {
            centreGravite1.GetComponent<TrailRenderer>().enabled = true;
        }
    }
}
