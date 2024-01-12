using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityLola : MonoBehaviour
{   
    public Vector3 posBoule ;
    public Vector3 posMassCenter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Find the GameObject named "Sofia"
        GameObject player = GameObject.Find("Renping");

        // Find the GameObject named "MassCenterSofia"
        GameObject boule = GameObject.Find("MassCenterRenping");

        // Find the member of "Sofia"
        GameObject head = GameObject.Find("mixamorig:Head");
        GameObject neck = GameObject.Find("mixamorig:Neck");

        GameObject leftUpLeg = GameObject.Find("mixamorig:LeftUpLeg");
        GameObject leftLeg = GameObject.Find("mixamorig:LeftLeg");
        GameObject leftFoot = GameObject.Find("mixamorig:LeftFoot");
        GameObject leftToeBase = GameObject.Find("mixamorig:LeftToeBase");

        GameObject spine = GameObject.Find("mixamorig:Spine");

        GameObject rightUpLeg = GameObject.Find("mixamorig:RightUpLeg");
        GameObject rightLeg = GameObject.Find("mixamorig:RightLeg");
        GameObject rightFoot = GameObject.Find("mixamorig:RightFoot");
        GameObject rightToeBase = GameObject.Find("mixamorig:RightToeBase");

        GameObject leftShoulder = GameObject.Find("mixamorig:LeftShoulder");
        GameObject leftArm = GameObject.Find("mixamorig:LeftArm");
        GameObject leftForeArm = GameObject.Find("mixamorig:LeftForeArm");
        GameObject leftHand = GameObject.Find("mixamorig:LeftHand");

        GameObject rightShoulder = GameObject.Find("mixamorig:RightShoulder");
        GameObject rightArm = GameObject.Find("mixamorig:RightArm");
        GameObject rightForeArm = GameObject.Find("mixamorig:RightForeArm");
        GameObject rightHand = GameObject.Find("mixamorig:RightHand");

        // Get the center of mass

        Vector3 massCenterPosition = (46 * head.transform.position +
                                      34 * neck.transform.position +
                                      500 * spine.transform.position +
                                      101 * leftUpLeg.transform.position +
                                      44 * leftLeg.transform.position +
                                      101 * rightUpLeg.transform.position +
                                      44 * rightLeg.transform.position +
                                     (15 / 2) * (leftFoot.transform.position + leftToeBase.transform.position) +
                                     (15 / 2) * (rightFoot.transform.position + rightToeBase.transform.position) +
                                     (27 / 2) * (leftShoulder.transform.position + leftArm.transform.position) +
                                     16 * leftForeArm.transform.position +
                                     7 * leftHand.transform.position +
                                     (27 / 2) * (rightShoulder.transform.position + rightArm.transform.position) +
                                     16 * rightForeArm.transform.position +
                                     7 * rightHand.transform.position) / 1000;

        /*(head.transform.position + neck.transform.position + leftUpLeg.transform.position +
                                  leftLeg.transform.position + leftFoot.transform.position + leftToeBase.transform.position +
                                  spine.transform.position + rightUpLeg.transform.position + rightLeg.transform.position +
                                  rightFoot.transform.position + rightToeBase.transform.position + leftShoulder.transform.position +
                                  leftArm.transform.position + leftForeArm.transform.position + leftHand.transform.position +
                                  rightShoulder.transform.position + rightArm.transform.position + rightForeArm.transform.position +
                                  rightHand.transform.position) / 19;*/

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
