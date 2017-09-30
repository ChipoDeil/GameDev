using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СollisionChecker : MonoBehaviour {

    void OnCollisionEnter() {
        Debug.Log("Я взорвалась!");
        Destroy(gameObject);
    }
}
