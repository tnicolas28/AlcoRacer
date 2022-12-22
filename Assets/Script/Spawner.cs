using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using static GenerateNextRoute;

public class Spawner : MonoBehaviour
{
    public float distanceBetweenRoads;

    [Header("Roads List")]
    [Space]
    public GameObject[] roads;

    public GenerateNextRoute curentRoad;

    public int maxRoutes;

    private Orientation previous;


    private void Start()
    {

        for(int i = 0; i < maxRoutes; i++)
        {
            CreateRoad();
        }
    }

    public void CreateRoad()
    {
        int idx = Random.Range(0, curentRoad.roads.Length);
        if (curentRoad.isLine)
        {
            if (previous == Orientation.left)
                curentRoad.orientation = Orientation.left;
            else
                curentRoad.orientation = Orientation.right;

            idx = previous == Orientation.left ? 0 : 1;
        }
        Vector3 pos = transform.position;
        switch (curentRoad.orientation)
        {
            case Orientation.left:
                if (curentRoad.coordonate == Coordonate.x)
                {
                    pos.x -= distanceBetweenRoads;
                    pos.y = transform.position.y;
                }
                else if (curentRoad.coordonate == Coordonate.y)
                {
                    pos.y -= distanceBetweenRoads;
                    pos.x = transform.position.x;

                }
                break;
            case Orientation.right:
                if (curentRoad.coordonate == Coordonate.x)
                {
                    pos.x += distanceBetweenRoads;
                    pos.y = transform.position.y;
                }
                else if (curentRoad.coordonate == Coordonate.y)
                {
                    pos.y += distanceBetweenRoads;
                    pos.x = transform.position.x;
                }
                break;
            case Orientation.up:
                pos.y += distanceBetweenRoads;
                pos.x = transform.position.x;
                break;
            default:
                break;
        }
        transform.position = pos;
        previous = curentRoad.orientation;

        Instantiate(curentRoad.roads[idx], transform.position, Quaternion.identity);
        curentRoad = curentRoad.roads[idx].GetComponent<GenerateNextRoute>();
        curentRoad.previousRoad = previous;
    }
}
