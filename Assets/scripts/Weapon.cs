using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon
{
    public enum DAMAGE_TYPE { PHYSICAL, MAGICAL }

    [SerializeField] private string name;
    [SerializeField] private DAMAGE_TYPE dmgType;
    [SerializeField] private Element elem;
    [SerializeField] private Stats bonusStats;

    public Weapon(string name, DAMAGE_TYPE dmgType, Element elem, Stats bonusStats)
    {
        this.name = name;
        this.dmgType = dmgType;
        this.elem = elem;
        this.bonusStats = bonusStats;
    }

    public string Name { get => name; set => name = value; }
    public DAMAGE_TYPE DmgType { get => dmgType; set => dmgType = value; }
    public Element Elem { get => elem; set => elem = value; }
    public Stats BonusStats { get => bonusStats; set => bonusStats = value; }
}

