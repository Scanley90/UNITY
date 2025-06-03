using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameFormulas
{
    public static bool HasElementAdvantage(Element attackElement, Hero defender) => attackElement == defender.Weakness;
    public static bool HasElementDisadvantage(Element attackElement, Hero defender) => attackElement == defender.Resistance;

    public static float EvaluateElementalModifier(Element attackElement, Hero defender)
    {
        if (HasElementAdvantage(attackElement, defender)) return 1.5f;
        if (HasElementDisadvantage(attackElement, defender)) return 0.5f;
        return 1f;
    }

    public static bool HasHit(Stats attacker, Stats defender)
    {
        int hitChance = attacker.aim - defender.eva;
        int roll = Random.Range(0, 100);
        if (roll > hitChance)
        {
            Debug.Log("MISS");
            return false;
        }
        return true;
    }

    public static bool IsCrit(int critValue)
    {
        int roll = Random.Range(0, 100);
        if (roll < critValue)
        {
            Debug.Log("CRIT");
            return true;
        }
        return false;
    }

    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        Stats totalAtkStats = Stats.Sum(attacker.BaseStats, attacker.Weapon.BonusStats);
        Stats totalDefStats = defender.BaseStats;

        int attackValue = totalAtkStats.atk;
        int defenseValue = attacker.Weapon.DmgType == Weapon.DAMAGE_TYPE.PHYSICAL ? totalDefStats.def : totalDefStats.res;

        int damage = attackValue - defenseValue;
        damage = Mathf.Max(damage, 0);

        float modifier = EvaluateElementalModifier(attacker.Weapon.Elem, defender);
        damage = Mathf.RoundToInt(damage * modifier);

        if (IsCrit(totalAtkStats.crt)) damage *= 2;

        return Mathf.Max(damage, 0);
    }
}

