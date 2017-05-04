using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatKnife : Item.WeaponsAndArmor
{

    private void SetUpItem()
    {
        IsWeapon= true;
        IsArmor = false;
        IsMelee = true;
        IsRanged = false;
        Damage = 3;
    }


	void Start ()
    {
        SetUpItem();
	}
	

}
