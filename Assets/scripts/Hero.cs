using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero
{
    [SerializeField] private string name;
    [SerializeField] private int hp;
    [SerializeField] private Stats baseStats;
    [SerializeField] private Element resistance;
    [SerializeField] private Element weakness;
    [SerializeField] private Weapon weapon;

    public Hero(string name, int hp, Stats baseStats, Element resistance, Element weakness, Weapon weapon)
    {
        this.name = name;
        this.hp = hp;
        this.baseStats = baseStats;
        this.resistance = resistance;
        this.weakness = weakness;
        this.weapon = weapon;
    }

    public string Name { get => name; set => name = value; }
    public int Hp { get => hp; private set => hp = value; }
    public Stats BaseStats { get => baseStats; set => baseStats = value; }
    public Element Resistance { get => resistance; set => resistance = value; }
    public Element Weakness { get => weakness; set => weakness = value; }
    public Weapon Weapon { get => weapon; set => weapon = value; }

    public void SetHp(int newHp) => hp = Mathf.Max(0, newHp);
    public void AddHp(int amount) => SetHp(hp + amount);
    public void TakeDamage(int damage) => AddHp(-damage);
    public bool IsAlive() => hp > 0;
}

