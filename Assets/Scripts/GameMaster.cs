using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    void Start()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    public Transform playerPrefabs;
    public Transform spawnPoint;
    
    public void RespawnPlayer()
    {
        Instantiate(playerPrefabs, spawnPoint.position, spawnPoint.rotation);
        Debug.Log("TODO: Add Spawn Particles");
    }


    public static void KillPlayer (Player player)
    {
        Destroy(player.gameObject);
    }
}
