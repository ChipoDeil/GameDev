using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingGrenade : MonoBehaviour
{
    public GameObject grenade;
    public GameObject camera;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) { 
            if(GameObject.Find("Grenade") != null) { 
                Debug.Log("Pressed right click.");
                grenade = GameObject.Find("Grenade");
                camera = GameObject.Find("Main Camera");
                Debug.Log(grenade.name);
                grenade.AddComponent<SphereCollider>();
                grenade.AddComponent<Rigidbody>();
                grenade.transform.parent = null;
                Vector3 lookDir = camera.transform.forward;
                grenade.GetComponent<Rigidbody>().AddForce(lookDir * 500);
                grenade.AddComponent<СollisionChecker>();
            }
        }
    }
}
