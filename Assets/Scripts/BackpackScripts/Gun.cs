using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Item.WeaponsAndArmor
{

    private void SetUpItem()
    {
        IsWeapon = true;
        IsArmor = false;
        IsMelee = false;
        IsRanged = true;
        Damage = 10;
    }


	void Start ()
    {
        SetUpItem();	
	}
	
}
