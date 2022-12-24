using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColligionManager : MonoBehaviour
{


    //Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Road"))
        {
            GameManager.Instance.StopGame();
        }
    }
}
