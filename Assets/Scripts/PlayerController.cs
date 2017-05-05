﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public GameObject Player;
    public Rigidbody rb;

    private Vector3 PlayerPos;
    private Vector3 PreviousPosition;

    void Movement()
    {

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {
            PlayerPos.z += 0.1f;
            Player.transform.position = PlayerPos;
            if (Player.transform.position.z >= 4.3f)
            {
                PlayerPos.z -= 0.1f;
                Player.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {
            PlayerPos.z -= 0.1f;
            Player.transform.position = PlayerPos;
            if (Player.transform.position.z <= -4.3f)
            {
                PlayerPos.z += 0.1f;
                Player.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            PlayerPos.x -= 0.1f;
            Player.transform.position = PlayerPos;
            if(Player.transform.position.x <= -4.3f)
            {
                PlayerPos.x += 0.1f;
                Player.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            PlayerPos.x += 0.1f;
            Player.transform.position = PlayerPos;
            if(Player.transform.position.x >= 4.3f)
            {
                PlayerPos.x -= 0.1f;
                Player.transform.position = PlayerPos;
            }
        }
    }


	void Start ()
    {
        PlayerPos = Player.transform.position;
    }
	
	void Update ()
    {
        Movement();
        PreviousPosition = Player.transform.position;
	}
}
