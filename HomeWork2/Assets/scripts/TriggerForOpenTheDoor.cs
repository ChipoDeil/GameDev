using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForOpenTheDoor : MonoBehaviour {
    private bool _isOpen = false;
    void OnTriggerEnter(Collider other) {
        GameObject light = GameObject.Find("DoorLight");
        Debug.Log("EnteredTriggerForOpenTheDoor");
        light.GetComponent<Light>().enabled = true;
        
    }

    void OnTriggerStay(Collider other) {
        if (!_isOpen) { 
            GameObject camera = GameObject.Find("Main Camera");
            string nameOfObject = camera.GetComponent<LookDirection>().getNameOfObject();
            if (nameOfObject.Equals("DoorCube") && Input.GetKeyDown(KeyCode.F))
            {
                GameObject doorCube = GameObject.Find("Door");
                doorCube.transform.Rotate(0, 90, 0);
                _isOpen = true;
            }
        }
    }

    void OnTriggerExit(Collider other) {
        GameObject light = GameObject.Find("DoorLight");
        Debug.Log("ExitedTriggerForOpenTheDoor");
        light.GetComponent<Light>().enabled = false;
        if (_isOpen) {
            GameObject doorCube = GameObject.Find("Door");
            doorCube.transform.Rotate(0, -90, 0);
            _isOpen = false;
        }
    }
}
