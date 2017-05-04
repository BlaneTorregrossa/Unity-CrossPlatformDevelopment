using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public GameObject Player;
    
    private Vector3 PlayerPos;
    private Vector3 PreviousPosition;

    void Movement()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerPos.z += 1;
            Player.transform.position = PlayerPos;
            if (Player.transform.position.z == 5)
            {
                PlayerPos.z -= 1;
                Player.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerPos.z -= 1;
            Player.transform.position = PlayerPos;
            if (Player.transform.position.z == -5)
            {
                PlayerPos.z += 1;
                Player.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPos.x -= 1;
            Player.transform.position = PlayerPos;
            if(Player.transform.position.x == 5)
            {
                PlayerPos.x += 1;
                Player.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPos.x += 1f;
            Player.transform.position = PlayerPos;
            if(Player.transform.position.x == -5)
            {
                PlayerPos.x -= 1;
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
