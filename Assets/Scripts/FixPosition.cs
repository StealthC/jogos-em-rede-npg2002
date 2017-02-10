using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPosition : MonoBehaviour {

    private void LateUpdate()
    {
        transform.position = transform.parent.position + new Vector3(0, 1.5f, 0);
        transform.rotation = Quaternion.identity;
    }
}
