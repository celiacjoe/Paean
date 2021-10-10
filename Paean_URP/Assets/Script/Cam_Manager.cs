using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Manager : MonoBehaviour
{
    private bool OrthoA;
    private bool OrthoB;
    public Camera AB;
    public Camera A;
    public Camera[] A0;
    public Camera[] A0_0;
    public Camera B;
    public Camera[] B0;
    public Camera[] B0_0;

    void Start()
    {
        OrthoA = false;
        OrthoB = false;
    }

    void Update()
    {

    }

    public void SetCamOrthoA()
    {
        if (OrthoA==false){
            A.orthographic = true;
            A0[0].orthographic = true;      A0[1].orthographic = true;
            A0_0[0].orthographic = true;    A0_0[1].orthographic = true;    A0_0[2].orthographic = true;    A0_0[3].orthographic = true;    A0_0[4].orthographic = true;    A0_0[5].orthographic = true;
            OrthoA = true;
        }else{
            OrthoA = false;
            A.orthographic = false;
            A0[0].orthographic = false;     A0[1].orthographic = false;
            A0_0[0].orthographic = false;   A0_0[1].orthographic = false;   A0_0[2].orthographic = false;   A0_0[3].orthographic = false;   A0_0[4].orthographic = false;   A0_0[5].orthographic = false;
            //A.orthographicSize = 5.0f;
        }
    }
    public void SetCamOrthoB()
    {
        if (OrthoB == false)
        {
            B.orthographic = true;
            B0[0].orthographic = true;      B0[1].orthographic = true;
            B0_0[0].orthographic = true;    B0_0[1].orthographic = true;    B0_0[2].orthographic = true;    B0_0[3].orthographic = true;    B0_0[4].orthographic = true;    B0_0[5].orthographic = true;
            OrthoB = true;
        }else{            
            B.orthographic = false;
            B0[0].orthographic = false;     B0[1].orthographic = false;
            B0_0[0].orthographic = false;   B0_0[1].orthographic = false;   B0_0[2].orthographic = false;   B0_0[3].orthographic = false;   B0_0[4].orthographic = false;   B0_0[5].orthographic = false;
            OrthoB = false;
            //B.orthographicSize = 5.0f;
        }
    }
}
