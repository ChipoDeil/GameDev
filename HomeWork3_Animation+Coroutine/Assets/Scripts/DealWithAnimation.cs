using System.Collections;
using UnityEngine;

public class DealWithAnimation : MonoBehaviour {
    Animator anim;
    const float _startDelay = 0.5f;
    const float _endDelay = 5f;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        StartCoroutine(PlayAnimation());
	}

    IEnumerator PlayAnimation() {
        anim.SetBool("Ready", true);
        float delay = Random.Range(_startDelay, _endDelay);
        yield return new WaitForSeconds(delay);
        anim.SetBool("Ready", false);

    }
}
