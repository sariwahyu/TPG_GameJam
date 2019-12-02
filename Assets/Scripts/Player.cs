using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStats
    {
        public int maxHealth = 100;

        private int _curHealth;
        public int curHealth
        {
            get { return _curHealth; }
            set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
        }
    }

    public PlayerStats playerStats = new PlayerStats();
    public int fallBoundary = -20;

    [SerializeField]
    private StatusIndicator statusIndicator;

    void Update()
    {
        if(transform.position.y <= fallBoundary)
        {
            DamagePlayer(9999999);
        }
    }

    public void DamagePlayer (int damage)
    {
        playerStats.Health -= damage;
        if(playerStats.Health <= 0)
        {
            GameMaster.KillPlayer(this);
        }

    }

}
