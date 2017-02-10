using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Life life = collision.gameObject.GetComponent<Life>();
        if (life != null) life.Damage(10);
        Destroy(this.gameObject);
    }
}
