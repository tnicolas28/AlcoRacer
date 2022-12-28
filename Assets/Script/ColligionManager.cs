using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColligionManager : MonoBehaviour
{
    public AudioSource turnSound;
    public AudioSource beerSound;

    public Car car;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Road"))
        {
            turnSound.Play();
            GameManager.Instance.StopGame();
        }else if (collision.gameObject.CompareTag("Beer"))
        {
            beerSound.Play();
            car.IncrementSpeed();
        }
    }
}
