using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassCenter1 : MonoBehaviour
{
    public Vector3 posBoule;
    public Vector3 posMassCenter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Find the GameObject named "Sofia"
        GameObject player = GameObject.Find("Fosco");

        // Find the GameObject named "MassCenterSofia"
        GameObject boule = GameObject.Find("MassCenterFosco");

        // Find the member of "Sofia"
        GameObject head = GameObject.Find("mixamorig1:Head");
        GameObject neck = GameObject.Find("mixamorig1:Neck");

        GameObject leftUpLeg = GameObject.Find("mixamorig1:LeftUpLeg");
        GameObject leftLeg = GameObject.Find("mixamorig1:LeftLeg");
        GameObject leftFoot = GameObject.Find("mixamorig1:LeftFoot");
        GameObject leftToeBase = GameObject.Find("mixamorig1:LeftToeBase");

        GameObject spine = GameObject.Find("mixamorig1:Spine");

        GameObject rightUpLeg = GameObject.Find("mixamorig1:RightUpLeg");
        GameObject rightLeg = GameObject.Find("mixamorig1:RightLeg");
        GameObject rightFoot = GameObject.Find("mixamorig1:RightFoot");
        GameObject rightToeBase = GameObject.Find("mixamorig1:RightToeBase");

        GameObject leftShoulder = GameObject.Find("mixamorig1:LeftShoulder");
        GameObject leftArm = GameObject.Find("mixamorig1:LeftArm");
        GameObject leftForeArm = GameObject.Find("mixamorig1:LeftForeArm");
        GameObject leftHand = GameObject.Find("mixamorig1:LeftHand");

        GameObject rightShoulder = GameObject.Find("mixamorig1:RightShoulder");
        GameObject rightArm = GameObject.Find("mixamorig1:RightArm");
        GameObject rightForeArm = GameObject.Find("mixamorig1:RightForeArm");
        GameObject rightHand = GameObject.Find("mixamorig1:RightHand");

        // Get the center of mass

        Vector3 massCenterPosition = (46      * head.transform.position + 
                                      34      * neck.transform.position +
                                      500     * spine.transform.position + 
                                      101     * leftUpLeg.transform.position + 
                                      44      * leftLeg.transform.position + 
                                      101     * rightUpLeg.transform.position +
                                      44      * rightLeg.transform.position +
                                     (15/2)   * (leftFoot.transform.position + leftToeBase.transform.position) +
                                     (15/2)   * (rightFoot.transform.position + rightToeBase.transform.position) +
                                     (27/2)   * (leftShoulder.transform.position + leftArm.transform.position) +
                                     16       * leftForeArm.transform.position + 
                                     7        * leftHand.transform.position +
                                     (27/2)   * (rightShoulder.transform.position + rightArm.transform.position) + 
                                     16       * rightForeArm.transform.position +
                                     7        * rightHand.transform.position) / 1000;
        
        // Get the Transform component of the player
        Transform playerTransform = player.transform;
        Transform bouleTransform = boule.transform;

        // Get player boule position
        Vector3 boulePosition = bouleTransform.position;
        // Set boule's position to the mass center
        bouleTransform.position = massCenterPosition;

        posBoule = boulePosition;
        posMassCenter = massCenterPosition;
    }
}
