using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsData1 : MonoBehaviour
{
    private string path_vitesse_massCenter = "Assets/vitesse_Fosco_massCenter.txt";
    private string path_acceleration_massCenter = "Assets/acceleration_Fosco_massCenter.txt";

    private string data_vitesse_massCenter = "";
    private string data_acceleration_massCenter = "";

    public MassCenter1 massCenter1;

    private double g = 9.8;

    public double Speed;
    public double Acceleration;
    public double Mass = 1000;

    public Vector3 pos;
    public Vector3 lastPosition = Vector3.zero;

    public double PotentialEnergy;
    public double derivPotentialEnergy;
    double lastSpeed = 0;
    double LastPotentialEnergy = 0;
    double LastDerivPotentialEnergy = 0;
    public double Stability = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject named "Renping"
        GameObject player = GameObject.Find("Fosco");
        massCenter1 = player.GetComponent<MassCenter1>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = massCenter1.posMassCenter;

        Speed = (pos - lastPosition).magnitude / Time.deltaTime;

        Acceleration = (Speed - lastSpeed) / Time.deltaTime;

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
