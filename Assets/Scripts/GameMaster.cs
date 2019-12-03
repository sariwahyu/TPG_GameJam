using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

   // public static int _remainingLives;

    //public static int RemainingLives
    //{
//get { return _remainingLives; }
    //}
    
   // public void EndGame()
    //{
    //    Debug.Log("Game Over");
        //gameOver.SetActive(true);
    //}

    //[SerializeField]
    //private GameObject gameOver;

    public static void KillPlayer (Player player)
    {
        Destroy(player.gameObject);
        //if (_remainingLives <= 0)
       // {
           // gm.EndGame();        
        //}
        
    }
}
