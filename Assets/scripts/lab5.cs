using UnityEngine;
using System;

public class NumeroArrayUtility : MonoBehaviour
{
    // Variabili per controlli numerici
    public int numberToCheck;
    public int baseNumber;
    public int multipleToCheck;

    // Variabili per array
    public int arraySize = 10;
    public int arrayMin = 0;
    public int arrayMax = 100;

    void Start()
    {
        // Controllo pari/dispari
        if (IsEven(numberToCheck))
            Debug.Log($"Il numero {numberToCheck} è pari");
        else
            Debug.Log($"Il numero {numberToCheck} è dispari");

        // Controllo multiplo
        if (IsMultipleOf(baseNumber, multipleToCheck))
            Debug.Log($"Il numero {multipleToCheck} è multiplo del numero {baseNumber}");
        else
            Debug.Log($"Il numero {multipleToCheck} non è multiplo del numero {baseNumber}");

        // Generazione e gestione array
        int[] mioArray = GeneraArray(arraySize, arrayMin, arrayMax);

        Debug.Log("Contenuto iniziale dell'array:");
        StampaArray(mioArray);

        Debug.Log($"Il valore minimo è: {TrovaMinimo(mioArray)}");
        Debug.Log($"Il valore massimo è: {TrovaMassimo(mioArray)}");

        TrovaMinimi2(mioArray);
        TrovaMassimi2(mioArray);

        // TEST Cambio dimensione array
        Debug.Log("\n--- TEST CAMBIO DIMENSIONE ARRAY ---");

        int[] arrayRidotto = CambiaDimensioneArray(mioArray, mioArray.Length - 3);
        Debug.Log("Array ridotto:");
        StampaArray(arrayRidotto);

        int[] arrayIngrandito = CambiaDimensioneArray(mioArray, mioArray.Length + 5);
        Debug.Log("Array ingrandito:");
        StampaArray(arrayIngrandito);

        int[] arrayUguale = CambiaDimensioneArray(mioArray, mioArray.Length);
        Debug.Log("Array stessa dimensione (non modificato):");
        StampaArray(arrayUguale);
    }

    // Funzione per controllare se un numero è pari
    bool IsEven(int number) => number % 2 == 0;

    // Funzione per controllare se un numero è multiplo di un altro
    bool IsMultipleOf(int baseNum, int multiple)
    {
        if (baseNum == 0) return false;
        return multiple % baseNum == 0;
    }

    // Genera un array con valori casuali
    int[] GeneraArray(int dimensioni, int minimo, int massimo)
    {
        int[] array = new int[dimensioni];
        for (int i = 0; i < dimensioni; i++)
        {
            array[i] = UnityEngine.Random.Range(minimo, massimo + 1);
        }
        return array;
    }

    // Stampa il contenuto di un array
    void StampaArray(int[] array)
    {
        string output = "";
        foreach (int val in array)
        {
            output += val + " ";
        }
        Debug.Log(output.Trim());
    }

    // Trova il valore minimo in un array
    int TrovaMinimo(int[] array)
    {
        int min = array[0];
        foreach (int val in array)
        {
            if (val < min) min = val;
        }
        return min;
    }

    // Trova il valore massimo in un array
    int TrovaMassimo(int[] array)
    {
        int max = array[0];
        foreach (int val in array)
        {
            if (val > max) max = val;
        }
        return max;
    }

    // Trova i due valori minimi in un array
    void TrovaMinimi2(int[] array)
    {
        if (array.Length < 2)
        {
            Debug.Log("Array troppo corto per trovare due minimi.");
            return;
        }

        int min1 = int.MaxValue, min2 = int.MaxValue;

        foreach (int val in array)
        {
            if (val < min1)
            {
                min2 = min1;
                min1 = val;
            }
            else if (val < min2 && val != min1)
            {
                min2 = val;
            }
        }

        Debug.Log($"I due numeri più piccoli sono: {min1} e {min2}");
    }

    // Trova i due valori massimi in un array
    void TrovaMassimi2(int[] array)
    {
        if (array.Length < 2)
        {
            Debug.Log("Array troppo corto per trovare due massimi.");
            return;
        }

        int max1 = int.MinValue, max2 = int.MinValue;

        foreach (int val in array)
        {
            if (val > max1)
            {
                max2 = max1;
                max1 = val;
            }
            else if (val > max2 && val != max1)
            {
                max2 = val;
            }
        }

        Debug.Log($"I due numeri più grandi sono: {max1} e {max2}");
    }

    // Cambia la dimensione di un array
    int[] CambiaDimensioneArray(int[] array, int dim)
    {
        int originalLength = array.Length;

        if (dim < originalLength)
        {
            int[] nuovoArray = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                nuovoArray[i] = array[i];
            }
            return nuovoArray;
        }
        else if (dim > originalLength)
        {
            int[] nuovoArray = new int[dim];
            for (int i = 0; i < originalLength; i++)
            {
                nuovoArray[i] = array[i];
            }
            for (int i = originalLength; i < dim; i++)
            {
                nuovoArray[i] = 0;
            }
            return nuovoArray;
        }
        else
        {
            return array; // stessa dimensione
        }
    }
}
