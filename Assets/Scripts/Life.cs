using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Life : NetworkBehaviour {
    public const int maxLife = 100;

    [SyncVar(hook = "OnChangeLife")]
    public int life = maxLife;

    public bool destroyOnDeath;

    public RectTransform lifeBar;

    public void Damage(int damage)
    {
        if (!isServer) return;

        life -= damage;
        if (life <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            } else
            {
                life = maxLife;
                RpcRespawn();
            }
        }
    }
    void OnChangeLife(int life)
    {
        lifeBar.localScale = new Vector3(life / 100f, 1f, 1f);
    }

    [ClientRpc]
    void RpcRespawn()
    {
        if (isLocalPlayer) transform.position = Vector3.zero;
    }
}
