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

        public void Init()
        {
            curHealth = maxHealth;
        }
    }

    public PlayerStats stats = new PlayerStats();
    public int fallBoundary = -20;

    [SerializeField]
    private StatusIndicator statusIndicator;

   void Start()
   {
      stats.Init();

        if (statusIndicator == null)
       {
         Debug.LogError("No Status Indicator reference on Player");
        }
        else
       {
          statusIndicator.SetHealth(stats.curHealth, stats.maxHealth);
      }
   }
    public void EndGame()
    {
        Debug.Log("Game Over");
        gameOver.SetActive(true);
    }

    public void WinGame()
    {
        Debug.Log("WinGame");
        winGame.SetActive(true);
    }

    [SerializeField]
    private GameObject gameOver;

    [SerializeField]
    private GameObject winGame;

    void Update()
    {
        if(transform.position.y <= fallBoundary)
        {
            DamagePlayer(9999999);
        }
    }

    public void DamagePlayer (int damage)
    {
        stats.curHealth -= damage;
        if(stats.curHealth <= 0)
        {
            GameMaster.KillPlayer(this);
            EndGame();
        }

        statusIndicator.SetHealth(stats.curHealth, stats.maxHealth);

    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("win"))
        {
            WinGame();

        }
    }

}
