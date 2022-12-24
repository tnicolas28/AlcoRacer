using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    float offset_x;
    float offset_y;


    void Start()
    {
        // on récupère l'écart initial entre  la cam et le player
        offset_x = transform.position.x - player.position.x;
        offset_y = transform.position.y - player.position.y;

    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = player.position.x + offset_x;
        pos.y = player.position.y + offset_y;

        transform.position = pos;
    }
}
