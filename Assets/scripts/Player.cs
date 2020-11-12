using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour
{
    float gravity = -20;
    Vector3 velocity;
    Controller2D controller;
    private void Start()
    {
        controller = GetComponent<Controller2D>();



    }

    private void Update()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


    }

}
