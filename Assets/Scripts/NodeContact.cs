using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeContact : MonoBehaviour
{

    public GameObject Node;
    public GameObject Player;

    private float Reaction;
    


    void ChangeReaction()
    {
        
    }




	void Start ()
    {
        Reaction = 0;
	}
	
	void Update ()
    {
        ChangeReaction();
	}
}
