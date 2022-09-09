using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChange : MonoBehaviour
{
    public GameObject[] teleports;
    public GameObject agent;

    void OnTriggerEnter(Collider hit)
    {
        teleports = GameObject.FindGameObjectsWithTag("Teleport");
        if(teleports.Length > 0) {
            Debug.Log(teleports.Length);
            agent.transform.position = teleports[teleports.Length-1].transform.position;
            Debug.Log(teleports[teleports.Length-1]);
            teleports[teleports.Length-1].tag = "Untagged";
        }
    }
}
