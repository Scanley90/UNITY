using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Element
{
    NONE,
    FIRE,
    ICE,
    LIGHTNING
}

[System.Serializable]
public struct Stats
{
    public int atk, def, res, spd, crt, aim, eva;
    public Element element;

    public Stats(int atk, int def, int res, int spd, int crt, int aim, int eva, Element element = Element.NONE)
    {
        this.atk = atk;
        this.def = def;
        this.res = res;
        this.spd = spd;
        this.crt = crt;
        this.aim = aim;
        this.eva = eva;
        this.element = element;
    }

    public static Stats Sum(Stats a, Stats b)
    {
        Element elem = a.element == b.element ? a.element : Element.NONE;
        return new Stats(
            a.atk + b.atk,
            a.def + b.def,
            a.res + b.res,
            a.spd + b.spd,
            a.crt + b.crt,
            a.aim + b.aim,
            a.eva + b.eva,
            elem
        );
    }
}

