using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild : Item.WeaponsAndArmor
{

    private void SetUpItem()
    {
        IsWeapon = false;
        IsArmor = true;
        IsMelee = false;
        IsRanged = false;
        DamageReduction = 0.25f;
    }

    void Start()
    {
        SetUpItem();
    }

}
