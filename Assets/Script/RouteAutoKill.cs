using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteAutoKill : MonoBehaviour
{

    private float killDistance = 5;


    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        float distanceActuelle = player.transform.position.y - transform.position.y;

        if (distanceActuelle > killDistance)
        {
            Destroy(gameObject);
        }
    }
}
