using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuovoscripts : MonoBehaviour
{
    
    public int num1 = 5;
    
    public int num2 = 1;
    
    public int num3 = 5;
    
    public int num4 = 3;

    public int partenza = 4;

    private int somma = 0;
    private int prodotto = 1;
    private int media;
    
    // Start is called before the first frame update
    void Start()
    {
        Stampa2Successivi();
        if (num1 % 2 == 0)
        {
            Debug.Log("il numero è pari");
        }
        else
            Debug.Log("il numero è dispari");


            somma = num1 + num2 + num3 + num4;
        prodotto = num1 * num2 * num3 * num4;
        media = (num1 + num2 + num3 + num4)/ 4;

        Debug.Log("somma-->" + somma);
        Debug.Log("prodotto-->"  + prodotto);
        Debug.Log("media-->" + media);

        Debug.Log("Hello World!");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Stampa2Successivi ()
    {
        Debug.Log("partenza-->" + partenza + "successivo-->" + (partenza + 1).ToString() + "successivo-->" + (partenza + 2).ToString());
    }
}