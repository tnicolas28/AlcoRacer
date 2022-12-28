using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("Car params")]
    public float speed;
    public float speedIncrementationDebuff;

    public float rotationSpeed;
    public Steering SteeringWheel;

    void Update()
    {

        if (GameManager.Instance.gameState != GameState.playing) return;
        float horizontalInput = SteeringWheel.GetClampedValue();


        transform.Translate(0, speed * Time.deltaTime, 0);


        Vector2 movementDirection = new Vector2(horizontalInput, 0);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();


        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

    }


    public void IncrementSpeed()
    {
        speed += speedIncrementationDebuff;
    }
}
