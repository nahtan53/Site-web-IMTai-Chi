using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class PhysicsData : MonoBehaviour
{
    private string path_vitesse_massCenter = "Assets/vitesse_Renping_massCenter.txt";
    private string path_acceleration_massCenter = "Assets/acceleration_Renping_massCenter.txt";

    private string data_vitesse_massCenter = "";
    private string data_acceleration_massCenter = "";

    public GravityLola gravityLola;

    private float g = 98/100;

    public float Speed;
    public float Acceleration;
    public float Mass = 1000;

    public Vector3 pos;
    public Vector3 lastPosition = Vector3.zero;

    float lastSpeed = 0;
    public float PotentialEnergy;
    public float derivPotentialEnergy;
    float LastPotentialEnergy = 0;
    float LastDerivPotentialEnergy = 0;
    public float Stability = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject named "Renping"
        GameObject player = GameObject.Find("Renping");
        gravityLola = player.GetComponent<GravityLola>();

        
    }

    // Update is called once per frame
    void Update()
    {
        pos = gravityLola.posMassCenter;

        Speed = (pos - lastPosition).magnitude / Time.deltaTime;
        
        Acceleration = (Speed - lastSpeed) / Time.deltaTime;
        lastSpeed = Speed;

        PotentialEnergy = Mass * g * pos[2]; // Ep = mgz
        derivPotentialEnergy = (PotentialEnergy - LastPotentialEnergy) / (pos[2] - lastPosition[2]);
        Stability = (derivPotentialEnergy - LastDerivPotentialEnergy) / (pos[2] - lastPosition[2]);


        LastPotentialEnergy = PotentialEnergy;
        LastDerivPotentialEnergy = derivPotentialEnergy;
        lastSpeed = Speed;
        lastPosition = pos;

        data_vitesse_massCenter += Speed + "\n";
        System.IO.File.WriteAllText(path_vitesse_massCenter, data_vitesse_massCenter);

        data_acceleration_massCenter += Acceleration + "\n";
        System.IO.File.WriteAllText(path_acceleration_massCenter, data_acceleration_massCenter);
    }
}

