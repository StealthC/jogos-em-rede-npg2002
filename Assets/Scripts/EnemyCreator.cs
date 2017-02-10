using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemyCreator : NetworkBehaviour {

    public GameObject enemyPrefab;
    public int numberOfEnemies = 4;
    public override void OnStartServer()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 pos = new Vector3(0, 0, 0);
            pos.x = Random.Range(-6f, 6f);
            pos.y = Random.Range(-5f, 5f);
            Quaternion rot = Quaternion.Euler(0, 0, Random.Range(0f, 360f));
            GameObject copy = (GameObject)Instantiate(enemyPrefab, pos, rot);
            NetworkServer.Spawn(copy);
        }
    }
}
