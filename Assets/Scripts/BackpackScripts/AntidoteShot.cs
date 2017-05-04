using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntidoteShot : Item.WeaponsAndArmor
{

    private void SetUpItem()
    {
        IsWeapon = true;
        IsArmor = false;
        IsMelee = false;
        IsRanged = true;
        Damage = 0;
    }


	void Start ()
    {
        SetUpItem();
	}
	
	
}
