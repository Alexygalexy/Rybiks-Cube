using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo;

    public bool hasStarted;

    public bool startCall = false;


    void Start()
    {
        beatTempo = beatTempo / 60f;
    }


    void Update()
    {
        if (!hasStarted)
        {
            //if(startCall == true)
            //{
            //    hasStarted = true;
            //}
        } else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }

        //if (Input.anyKeyDown)
        //{
        //    startAlgU();
        //}
    }

    public void startAlgU()
    {
        startCall = true;
    }
}
