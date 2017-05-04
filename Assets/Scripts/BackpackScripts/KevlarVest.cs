using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KevlarVest : Item.WeaponsAndArmor
{

    private void SetUpItem()
    {
        IsWeapon = false;
        IsArmor = true;
        IsMelee = false;
        IsRanged = false;
        DamageReduction = 0.5f;
    }


    void Start()
    {
        SetUpItem();
    }
}
