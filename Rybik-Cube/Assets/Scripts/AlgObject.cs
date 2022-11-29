using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgObject : MonoBehaviour
{

    public bool canBeTurned;

    public GameObject hitEffect, perfectEffect, missEffect;

    private float duration = 0.1f;

    public bool RTurn;
    public bool UTurn;
    public bool RpTurn;
    public bool UpTurn;
    public bool LTurn;
    public bool LpTurn;
    public bool FTurn;
    public bool FpTurn;
    public bool DTurn;
    public bool DpTurn;
    public bool BTurn;
    public bool BpTurn;

    public bool Turn = false;

    void Start()
    {
        if (RTurn == true)
        {
            AlgButtonController.onTurnR.AddListener(disappAlg);
        }
        if (UTurn == true)
        {
            AlgButtonController.onTurnU.AddListener(disappAlg);
        }
        if (RpTurn == true)
        {
            AlgButtonController.onTurnRp.AddListener(disappAlg);
        }
        if (UpTurn == true)
        {
            AlgButtonController.onTurnUp.AddListener(disappAlg);
        }
        if (LTurn == true)
        {
            AlgButtonController.onTurnL.AddListener(disappAlg);
        }
        if (LpTurn == true)
        {
            AlgButtonController.onTurnLp.AddListener(disappAlg);
        }
        if (FTurn == true)
        {
            AlgButtonController.onTurnF.AddListener(disappAlg);
        }
        if (FpTurn == true)
        {
            AlgButtonController.onTurnFp.AddListener(disappAlg);
        }
        if (DTurn == true)
        {
            AlgButtonController.onTurnD.AddListener(disappAlg);
        }
        if (DpTurn == true)
        {
            AlgButtonController.onTurnDp.AddListener(disappAlg);
        }
        if (BTurn == true)
        {
            AlgButtonController.onTurnB.AddListener(disappAlg);
        }
        if (BpTurn == true)
        {
            AlgButtonController.onTurnBp.AddListener(disappAlg);
        }

    }

    public void scorePress()
    {
        StartCoroutine(PressDissapCorout());
    }

    IEnumerator PressDissapCorout()
    {
        yield return new WaitForSeconds(duration);

        Turn = false;

    }

    
    void Update()
    {
        if (Turn == true)
        {
            if (canBeTurned)
            {

                Destroy(gameObject);
                //GameManager.instance.NoteHit();

                if ( Mathf.Abs(transform.position.y) > 0.07)
                {
                    Debug.Log("Normal");
                    GameManager.instance.NormalHit();
                    Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
                } else 
                {
                    Debug.Log("Perfect");
                    GameManager.instance.PerfectHit();
                    Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                }
                //else
                //{
                //    Debug.Log("Perfect");
                //    GameManager.instance.PerfectHit();
                //}

            }
            scorePress();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBeTurned = true;
        }

        if (other.tag == "Activator2")
        {
            GameManager.instance.NoteMissed();
            Instantiate(missEffect, new Vector2(transform.position.x, transform.position.y + 0.8f), missEffect.transform.rotation);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBeTurned = false;
        }
    }


    public void disappAlg()
    {
        Turn = true;
    }
}
