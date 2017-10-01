using UnityEngine;

public class ThrowingGrenade : MonoBehaviour
{
    public GameObject grenadeObject;
    public GameObject cameraObject;
    public int speed = 500;

    // Update is called once per frame
    void Update()
    {
        if (isItPossibleToThrowGrenade()) { 
            Debug.Log("Pressed right click.");
            Debug.Log(grenadeObject.name);
            ThrowGrenade();
        }
    }

    bool isItPossibleToThrowGrenade()
    {
        if (Input.GetMouseButtonDown(1) && grenadeObject != null)
            return true;
        else
            return false;
    }

    void ThrowGrenade() {
        grenadeObject.AddComponent<SphereCollider>();
        grenadeObject.AddComponent<Rigidbody>();
        grenadeObject.transform.parent = null;
        Vector3 lookDir = cameraObject.transform.forward;
        grenadeObject.GetComponent<Rigidbody>().AddForce(lookDir * speed);
        grenadeObject.AddComponent<СollisionChecker>();
    }
}
