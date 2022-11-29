using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class AlgButtonController : MonoBehaviour
{
    //private SpriteRenderer theSR;
    //public Sprite defaultImage;
    //public Sprite pressedImage;

    public bool resultAct = false;

    public static UnityEvent onTurnR = new UnityEvent();
    public static UnityEvent onTurnU = new UnityEvent();
    public static UnityEvent onTurnRp = new UnityEvent();
    public static UnityEvent onTurnUp = new UnityEvent();
    public static UnityEvent onTurnL = new UnityEvent();
    public static UnityEvent onTurnLp = new UnityEvent();
    public static UnityEvent onTurnF = new UnityEvent();
    public static UnityEvent onTurnFp = new UnityEvent();
    public static UnityEvent onTurnD = new UnityEvent();
    public static UnityEvent onTurnDp = new UnityEvent();
    public static UnityEvent onTurnB = new UnityEvent();
    public static UnityEvent onTurnBp = new UnityEvent();

    public KeyCode keyPressCode;
    public float duration = 0.1f;

    public bool R = false;
    public bool U = false;
    public bool Rp = false;
    public bool Up = false;
    public bool L = false;
    public bool Lp = false;
    public bool F = false;
    public bool Fp = false;
    public bool D = false;
    public bool Dp = false;
    public bool B = false;
    public bool Bp = false;


    public bool didfunct = false;
    //public bool didfunctU = false;

    //public int mainMenuInput = 0;
    private enum SceneState
    {
        mainMenu,
        main,
        manual_1,
        tutorial,
        manual_main,
    }

    private SceneState sceneState;



    #region Turn Inputs
    void pressDelay()
    {
        StartCoroutine(pressCorout());
    }

    IEnumerator pressCorout()
    {
        yield return new WaitForSeconds(duration);

        if (didfunct == true)
        {
            if (R == true)
            {
                didfunct = false;
            }
            if (U == true)
            {
                didfunct = false;
            }
            if (Rp == true)
            {
                didfunct = false;
            }
            if (Up == true)
            {
                didfunct = false;
            }
            if (L == true)
            {
                didfunct = false;
            }
            if (Lp == true)
            {
                didfunct = false;
            }
            if (F == true)
            {
                didfunct = false;
            }
            if (Fp == true)
            {
                didfunct = false;
            }
            if (D == true)
            {
                didfunct = false;
            }
            if (Dp == true)
            {
                didfunct = false;
            }
            if (B == true)
            {
                didfunct = false;
            }
            if (Bp == true)
            {
                didfunct = false;
            }
        }

    }

    public void turnSideR()
    {

        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For Manual Input
        if (sceneState == SceneState.manual_1)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Level");
        }

        //For Main
        if (sceneState == SceneState.main)
        {
            startAlg();

            if (R == true)
            {
                onTurnR.Invoke();
                //Debug.Log("R press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For Main Manual Input
        if (sceneState == SceneState.manual_main)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Main");
        }


        //For UI Input in Main
        if (sceneState == SceneState.main && resultAct == true)
        {
            SceneManager.LoadScene("");
            resultAct = false;
        }


        //For tutorial
        if (sceneState == SceneState.tutorial)
        {
            startAlg();

            if (R == true)
            {
                onTurnR.Invoke();
                //Debug.Log("R press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For UI Input in tutorial
        if (sceneState == SceneState.tutorial && resultAct == true)
        {
            SceneManager.LoadScene("Main");
            resultAct = false;
        }

    }

    public void turnSideU()
    {
        

        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For Main
        if (sceneState == SceneState.main)
        {

            if (U == true)
            {
                onTurnU.Invoke();
                //Debug.Log("U press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For UI Input in Main
        if (sceneState == SceneState.main && resultAct == true)
        {
            SceneManager.LoadScene("Main");
            resultAct = false;
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (U == true)
            {
                onTurnU.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For UI Input in tutorial
        if (sceneState == SceneState.tutorial && resultAct == true)
        {
            SceneManager.LoadScene("Tutorial_Level");
            resultAct = false;
        }
    }

    public void turnSideRp()
    {

        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For Main
        if (sceneState == SceneState.main)
        {

            if (Rp == true)
            {
                onTurnRp.Invoke();
                //Debug.Log("R' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (Rp == true)
            {
                onTurnRp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideUp()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For Main
        if (sceneState == SceneState.main)
        {

            if (Up == true)
            {
                onTurnUp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (Up == true)
            {
                onTurnUp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideL()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }


        //For UI Input in Main
        if (sceneState == SceneState.main && resultAct == true)
        {
            SceneManager.LoadScene("Manual_for_Main");
            resultAct = false;
        }


        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (L == true)
            {
                onTurnL.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }

        //For UI Input in tutorial
        if (sceneState == SceneState.tutorial && resultAct == true)
        {
            SceneManager.LoadScene("Tutorial_Manual_1");
            resultAct = false;
        }
    }

    public void turnSideLp()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (Lp == true)
            {
                onTurnLp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideF()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (F == true)
            {
                onTurnF.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideFp()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (Fp == true)
            {
                onTurnFp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideD()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (D == true)
            {
                onTurnD.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideDp()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (Dp == true)
            {
                onTurnDp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideB()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (B == true)
            {
                onTurnB.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }

    public void turnSideBp()
    {
        //For Main Menu
        if (sceneState == SceneState.mainMenu)
        {
            Debug.Log("scene change");
            SceneManager.LoadScene("Tutorial_Manual_1");
        }

        //For tutorial
        if (sceneState == SceneState.tutorial)
        {

            if (Bp == true)
            {
                onTurnBp.Invoke();
                //Debug.Log("U' press");
                //theSR.sprite = pressedImage;
                didfunct = true;
                pressDelay();
            }
        }
    }
    #endregion

    void Start()
    {
        //For scene transition
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Main_Menu":
                sceneState = SceneState.mainMenu;
                break;
            case "Main":
                sceneState = SceneState.main;
                GameManager.resultAct.AddListener(resultActive);
                break;
            case "Tutorial_Manual_1":
                sceneState = SceneState.manual_1;
                break;
            case "Tutorial_Level":
                sceneState = SceneState.tutorial;
                GameManager.resultAct.AddListener(resultActive);
                break;
            case "Manual_for_Main":
                sceneState = SceneState.manual_main;
                break;
        }

        



        //theSR = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Application.isEditor)
        {
            if (Input.GetKeyDown(keyPressCode))
            {
                switch (keyPressCode)
                {
                    case KeyCode.A:
                        turnSideR();
                        break;
                    case KeyCode.S:
                        turnSideU();
                        break;
                    case KeyCode.D:
                        turnSideRp();
                        break;
                    case KeyCode.F:
                        turnSideUp();
                        break;
                    case KeyCode.Q:
                        turnSideL();
                        break;
                    case KeyCode.W:
                        turnSideLp();
                        break;
                    case KeyCode.E:
                        turnSideF();
                        break;
                    case KeyCode.R:
                        turnSideFp();
                        break;
                    case KeyCode.Z:
                        turnSideD();
                        break;
                    case KeyCode.X:
                        turnSideDp();
                        break;
                    case KeyCode.C:
                        turnSideB();
                        break;
                    case KeyCode.V:
                        turnSideBp();
                        break;
                }
            }
        }
        
    }

    private void startAlg()
    {
        FindObjectOfType<BeatScroller>().startAlgU();
    }

    public void resultActive()
    {
        resultAct = true;
    }

    
}
