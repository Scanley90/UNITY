using UnityEngine;

public class Tabellina3 : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int risultato = 3 * i;
            Debug.Log("3 x " + i + " = " + risultato);
        }
    }
}