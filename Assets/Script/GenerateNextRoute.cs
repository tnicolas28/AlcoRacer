using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNextRoute : MonoBehaviour
{
    [Header("Possible Roads List")]
    [Space]
    public GameObject[] roads;
    public bool isLine;


    public enum Coordonate
    {
        x,
        y
    };
    public Coordonate coordonate;


     
    public enum Orientation
    {
        left,
        right,
        up
    };
    public Orientation orientation;
    public Orientation previousRoad;

    
}
