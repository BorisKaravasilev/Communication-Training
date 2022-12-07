using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");

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
