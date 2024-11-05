using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1=new Player();
        Player player2=new Player();
        player1.InitializePlayer("Aya",100);
        player1.InitializePlayer("SOssy",100);
        player1.Heal(40);
        player1.Heal(true);
        Player.ShowPlayerCount();
        Debug.Log(player1.health);
        Debug.Log(player2.health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
