using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealWithZoomAnimations : MonoBehaviour {

	private Animator anim;
    private string zoomIn = "ZoomIn";
    private string zoomOut = "ZoomOut";
    int counter = 0;
	void Start () {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse1) && counter > -1) {
            anim.SetTrigger(zoomOut);
            counter--;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && counter < 1) {
            anim.SetTrigger(zoomIn);
            counter++;
        }
    }
}
