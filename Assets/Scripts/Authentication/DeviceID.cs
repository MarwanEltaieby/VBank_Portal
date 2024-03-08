using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        getDeviceID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getDeviceID()
    {
        return SystemInfo.deviceUniqueIdentifier + "";
    }
}
