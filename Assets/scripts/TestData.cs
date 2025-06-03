using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestData : MonoBehaviour
{
    public M1ProjectTest tester;

    void Start()
    {
        // Stats: atk, def, res, spd, crt, aim, eva, element
        Stats baseStatsA = new Stats(15, 5, 2, 8, 20, 85, 10, Element.FIRE);
        Stats baseStatsB = new Stats(13, 3, 4, 7, 15, 80, 12, Element.ICE);
        Stats bonusStatsA = new Stats(5, 0, 0, 2, 10, 5, 3, Element.FIRE);
        Stats bonusStatsB = new Stats(3, 0, 2, 1, 8, 7, 4, Element.ICE);

        // Weapons
        Weapon weaponA = new Weapon("Glamdring", Weapon.DAMAGE_TYPE.PHYSICAL, Element.FIRE, bonusStatsA);
        Weapon weaponB = new Weapon("Zanna D'argento", Weapon.DAMAGE_TYPE.MAGICAL, Element.ICE, bonusStatsB);

        // Heroes
        Hero heroA = new Hero("Sheldon Cooper", 100, baseStatsA, Element.ICE, Element.LIGHTNING, weaponA);
        Hero heroB = new Hero("Leonard Hofstadter", 100, baseStatsB, Element.FIRE, Element.NONE, weaponB);

        // Assegna al tester
        tester.a = heroA;
        tester.b = heroB;
    }
}
