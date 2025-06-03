using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE
    }

    [Header("Impostazioni Danno")]
    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;
    public int baseDamage;

    void Start()
    {
        Debug.Log("Danno base iniziale: " + baseDamage);

        // Controlla resistenza
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log("Il nemico è resistente a questo tipo di attacco. Danno dimezzato.");
            Debug.Log("Nuovo danno: " + baseDamage);
        }

        // Controlla debolezza
        else if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole contro questo tipo di attacco. Danno raddoppiato.");
            Debug.Log("Nuovo danno: " + baseDamage);
        }

        // Stampa danno finale
        Debug.Log("Danno finale applicato: " + baseDamage);
    }
}
