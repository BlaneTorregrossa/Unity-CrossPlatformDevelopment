using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    protected string ItemName;
    protected int ItemID;
    protected int ItemIDCounter;


	void Start ()
    {
		
	}

    public class WeaponsAndArmor : ScriptableObject
    {

        public bool IsWeapon;
        public bool IsArmor;
        public bool IsRanged;
        public bool IsMelee;
        public int Damage;
        public float DamageReduction;
        
        

    }

}

