using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Manager : MonoBehaviour
{
    public Render_Manager Render;
    public float RandomSpeed;
    public bool Cam_Translation;
    public Animator AC_Cam;
    public Camera AB;
    public Camera A;
    public Camera[] A0;
    public Camera[] A0_0;
    public Camera B;
    public Camera[] B0;
    public Camera[] B0_0;

    void Start()
    {
    }

    void Update()
    {
        
        if (Cam_Translation == true)
        {
            B0[1].transform.Translate(0, RandomSpeed * Time.deltaTime, 0);
            A0[1].transform.Translate(0, RandomSpeed * Time.deltaTime, 0);
        }
    }

    public void CamTranslation()
    {      

        if (Render.Intensity == 1){
            RandomSpeed = Random.Range(1f, 3f);
            AC_Cam.speed = RandomSpeed;
            AC_Cam.SetBool("Animate", true);
        }else if (Render.Intensity == 2){
            RandomSpeed = Random.Range(2f, 5f);
            AC_Cam.speed = RandomSpeed;
            AC_Cam.SetBool("Animate", false);
            AC_Cam.SetBool("Crossed", true);
        }else if (Render.Intensity == 3){
            RandomSpeed = Random.Range(3f, 7f);
            AC_Cam.SetBool("Crossed", false);
            AC_Cam.SetBool("Melt", true);
        }else if(Render.Intensity > 3){
            Debug.Log("StopAnim");
            AC_Cam.SetBool("Melt", false);
        }

        /*if (Cam_Translation)
        {
            B0[1].transform.transform.position = new Vector3(0, 0, 0);
            A0[1].transform.transform.position = new Vector3(0, 0, 0);
            Cam_Translation = false;
        }else
        {
            Cam_Translation = true;
        }*/

    }

    public void SetCamOrthoA()
    {
        if (!A.orthographic){
            A.orthographic = true;
            A0[0].orthographic = true;      A0[1].orthographic = true;
            A0_0[0].orthographic = true;    A0_0[1].orthographic = true;    A0_0[2].orthographic = true;    A0_0[3].orthographic = true;    A0_0[4].orthographic = true;    A0_0[5].orthographic = true;
        }else{
            A.orthographic = false;
            A0[0].orthographic = false;     A0[1].orthographic = false;
            A0_0[0].orthographic = false;   A0_0[1].orthographic = false;   A0_0[2].orthographic = false;   A0_0[3].orthographic = false;   A0_0[4].orthographic = false;   A0_0[5].orthographic = false;
            //A.orthographicSize = 5.0f;
        }
    }
    public void SetCamOrthoB()
    {
        if (!B.orthographic){
            B.orthographic = true;
            B0[0].orthographic = true;      B0[1].orthographic = true;
            B0_0[0].orthographic = true;    B0_0[1].orthographic = true;    B0_0[2].orthographic = true;    B0_0[3].orthographic = true;    B0_0[4].orthographic = true;    B0_0[5].orthographic = true;
        }else{            
            B.orthographic = false;
            B0[0].orthographic = false;     B0[1].orthographic = false;
            B0_0[0].orthographic = false;   B0_0[1].orthographic = false;   B0_0[2].orthographic = false;   B0_0[3].orthographic = false;   B0_0[4].orthographic = false;   B0_0[5].orthographic = false;
            //B.orthographicSize = 5.0f;
        }
    }
}
