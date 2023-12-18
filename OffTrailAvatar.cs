using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OffTrailAvatar : MonoBehaviour
{
    public bool boolean = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OffTrail()
    {
        GameObject avatar = GameObject.Find("Renping");

        
        if (boolean == true)
        {
            boolean = false;
            avatar.SetActive(boolean);
        }

        if (boolean == false)
        {
            boolean = true;
            avatar.SetActive(boolean);
        }

    }
}
