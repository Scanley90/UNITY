using UnityEngine;

public class TutteLeOperazioni : MonoBehaviour
{
    void Start()
    {
        // 1. Ciclo while con incremento num e decremento index
        Debug.Log("▶ Incremento num con while:");
        int num = 0;
        int index = 5;

        while (index > 0)
        {
            num++;
            Debug.Log("Num attuale: " + num);
            index--;
        }
        Debug.Log("Ciclo while completato.");

        // 2. Array, somma e prodotto (interrotti dopo secondo ciclo)
        Debug.Log("▶ Operazioni su array (fermate al secondo ciclo):");
        int[] numeri = { 2, 4, 6, 8 };
        int somma = 0;
        int prodotto = 1;

        for (int i = 0; i < numeri.Length; i++)
        {
            somma += numeri[i];
            prodotto *= numeri[i];

            Debug.Log("Indice " + i + " → Somma: " + somma + ", Prodotto: " + prodotto);

            if (i == 1)
            {
                Debug.Log("Interruzione: ciclo fermato dopo il secondo elemento.");
                break;
            }
        }

        // 3. FizzBuzz da 1 a 30
        Debug.Log("▶ FizzBuzz da 1 a 30:");
        for (int numero = 1; numero <= 30; numero++)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (numero % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (numero % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(numero);
            }
        }

        // 4. Somma di un array di 4 numeri
        Debug.Log("▶ Somma di array di 4 numeri:");
        int[] arrayNumeri = { 10, 20, 30, 40 };
        int sommaTotale = 0;

        for (int i = 0; i < arrayNumeri.Length; i++)
        {
            sommaTotale += arrayNumeri[i];
        }
        Debug.Log("Somma totale: " + sommaTotale);

        // 5. Stampa numeri da start a start + amount
        Debug.Log("▶ Stampa numeri da start a start + amount:");
        int start = 5;
        int amount = 3;

        for (int i = 0; i <= amount; i++)
        {
            Debug.Log(start + i);
        }

        // 6. Ricerca del valore 'find' in array casuale
        Debug.Log("▶ Ricerca del valore 'find' in un array casuale:");
        int find = 7;
        int x = 10;
        int[] randomArray = new int[x];

        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = Random.Range(0, find + 1);
            if (randomArray[i] == find)
            {
                Debug.Log("Elemento " + i + ": found (" + randomArray[i] + ")");
            }
            else
            {
                Debug.Log("Elemento " + i + ": not found (" + randomArray[i] + ")");
            }
        }
        Debug.Log("iterations finished");

        // 7. Uso di GeneraArray(min, max), StampaArray, SommaArray
        Debug.Log("▶ Generazione, stampa e somma di un array di 20 elementi:");
        int[] mioArray = new int[20];
        GeneraArray(mioArray, 1, 100);           // genera valori da 1 a 100
        StampaArray(mioArray);                   // stampa tutti gli elementi
        int sommaFinale = SommaArray(mioArray);  // calcola somma
        Debug.Log("Somma finale: " + sommaFinale);
    }

    // --------------------
    // FUNZIONI AGGIUNTIVE
    // --------------------

    // Popola un array con numeri casuali nel range [min, max]
    void GeneraArray(int[] arr, int min, int max)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(min, max + 1); // +1 perché max è escluso
        }
    }

    // Calcola la somma di tutti gli elementi di un array
    int SommaArray(int[] arr)
    {
        int somma = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            somma += arr[i];
        }
        return somma;
    }

    // Stampa tutti gli elementi di un array
    void StampaArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log("Elemento " + i + ": " + arr[i]);
        }
    }
}