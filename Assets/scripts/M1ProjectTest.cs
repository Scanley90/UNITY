using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1ProjectTest : MonoBehaviour
{
    public Hero a;
    public Hero b;

    void Update()
    {
        if (!a.IsAlive() || !b.IsAlive()) return;

        Hero first = Stats.Sum(a.BaseStats, a.Weapon.BonusStats).spd >= Stats.Sum(b.BaseStats, b.Weapon.BonusStats).spd ? a : b;
        Hero second = first == a ? b : a;

        PerformAttack(first, second);

        if (second.IsAlive())
        {
            PerformAttack(second, first);
        }
    }

    void PerformAttack(Hero attacker, Hero defender)
    {
        Debug.Log(attacker.Name + " attacca " + defender.Name);

        if (!GameFormulas.HasHit(Stats.Sum(attacker.BaseStats, attacker.Weapon.BonusStats), defender.BaseStats)) return;

        if (GameFormulas.HasElementAdvantage(attacker.Weapon.Elem, defender)) Debug.Log("WEAKNESS");
        if (GameFormulas.HasElementDisadvantage(attacker.Weapon.Elem, defender)) Debug.Log("RESIST");

        int damage = GameFormulas.CalculateDamage(attacker, defender);
        Debug.Log("Danno inflitto: " + damage);

        defender.TakeDamage(damage);

        if (!defender.IsAlive())
        {
            Debug.Log(attacker.Name + " ha vinto!");
        }
    }
}

