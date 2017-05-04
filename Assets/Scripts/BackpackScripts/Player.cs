using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{


    private void SetUpCharacter(string name, int ID, int health, bool poison)
    {
        name = "Opponent";
        ID = (CharIDCounter += 5);
        health = 100;
        poison = false;
    }

    void Start()
    {
        SetUpCharacter(CharName, CharID, Health, Poisoned);
        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Player.transform.position = new Vector3(-10, 0, 0);
        Player.transform.localScale = new Vector3(0.75f, 0.75f, 0);
        
    }


}
