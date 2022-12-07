using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public string playerTag = "Player";
    private Transform player;
    private float speed = 5f;
    
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
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
