using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -h * 180 * Time.deltaTime);
        transform.Translate(0, v * 4 * Time.deltaTime, 0f);
    }
}
