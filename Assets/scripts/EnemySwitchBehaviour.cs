using UnityEngine;


public class EnemySwitchBehaviour : MonoBehaviour
{
    public enum STATE
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED
    }

    [SerializeField]
    private STATE currentState;

    void Update()
    {
        // Controlla input da tastiera per test
        if (Input.GetKeyDown(KeyCode.I))
        {
            currentState = STATE.IDLE;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = STATE.AGGROED;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            currentState = STATE.ATTACKING;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            currentState = STATE.DEFEATED;
        }

        // Esegui azione in base allo stato
        switch (currentState)
        {
            case STATE.IDLE:
                Debug.Log("Il nemico è fermo.");
                break;
            case STATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore.");
                break;
            case STATE.ATTACKING:
                Debug.Log("Il nemico sta attaccando il giocatore.");
                break;
            case STATE.DEFEATED:
                Debug.Log("Il nemico è sconfitto.");
                break;
        }
    }
}