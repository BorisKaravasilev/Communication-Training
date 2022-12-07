using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public string playerTag = "Player";
    private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        var players = GameObject.FindGameObjectsWithTag(playerTag);

        if (players.Length > 0)
        {
            player = players[0].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform);
    }
}
