using JetBrains.Annotations;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class Data1 : MonoBehaviour
{
    public PhysicsData1 physicsData1; //Fosco
    public PhysicsData physicsData; //Renping
    public Text myText1; //Text Fosco
    public Text myText; //Text Renping
    public Text comment; //Commentaire

    private int countStabilityPro = 0;
    private int countStabilityNoob = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Fosco");
        physicsData1 = player.GetComponent<PhysicsData1>();

        GameObject renping = GameObject.Find("Renping");
        physicsData = renping.GetComponent<PhysicsData>();
    }

    // Update is called once per frame
    void Update()
    {
        myText1.text = "Speed : " + physicsData1.Speed.ToString("F2") + " m/s\n" +
                      "Acceleration : " + physicsData1.Acceleration.ToString("F2") + " m/s²\n" +
                      "Stability : => "  ;
        if (physicsData1.Stability >= 0) 
        {
            myText1.text += "Stable"; 
        }
        else myText1.text += "Instable";

        myText.text = "Speed : " + physicsData.Speed.ToString("F2") + " m/s\n" +
                      "Acceleration : " + physicsData.Acceleration.ToString("F2") + " m/s²\n" +
                      "Stability : => ";
        if (physicsData.Stability >= 0)
        {
            myText.text += "Stable";
        }
        else myText.text += "Instable";

        if((physicsData.Stability < 0 && physicsData1.Stability >= 0) || 
            ((physicsData.Stability >= 0 && physicsData1.Stability >= 0) && (physicsData.Stability < physicsData1.Stability))) 
        {
            comment.text = "L'amateur est plus stable que le pro\n\n";
            countStabilityNoob += 1;
            if (countStabilityNoob < countStabilityPro) { comment.text += "Dans l'ensemble, l'amateur est plus stable !"; }
            else { comment.text += "Dans l'ensemble, l'amateur est moins stable !"; }
        }
        if ((physicsData.Stability >= 0 && physicsData1.Stability < 0) ||
            ((physicsData.Stability >= 0 && physicsData1.Stability >= 0) && (physicsData.Stability > physicsData1.Stability)))
        {
            comment.text = "L'amateur est moins stable que le pro\n\n";
            countStabilityPro += 1;
            if (countStabilityNoob < countStabilityPro) { comment.text += "Dans l'ensemble, l'amateur est plus stable !"; }
            else { comment.text += "Dans l'ensemble, l'amateur est moins stable !"; }
        }
        
    }
}
