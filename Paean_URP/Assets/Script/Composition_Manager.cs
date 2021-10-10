using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composition_Manager : MonoBehaviour
{
    public GameObject ABLandscape;

    public GameObject A;
    public GameObject[] A0;
    public GameObject[] A1_0;
    public GameObject[] A2_0;

    public GameObject B;
    public GameObject[] B0;
    public GameObject[] B1_0;
    public GameObject[] B2_0;

    public int i;

    void Start()
    {
        i = 0;
        CleanA();
    }

    void Update()
    {
        
    }

    /////////////////////////////////////////FRAGMENTATION
    public void SetupTotalFragmentation()
    {
        int R; R = Random.Range(0, 3);
        if (R == 0){
            A1_0[0].SetActive(true);    A1_0[2].SetActive(true);    B1_0[1].SetActive(true);
            A2_0[1].SetActive(true);    B2_0[0].SetActive(true);    B2_0[2].SetActive(true);
        }else if (R == 1){
            A2_0[0].SetActive(true);    A2_0[2].SetActive(true);   B2_0[1].SetActive(true);
            A1_0[1].SetActive(true);    B1_0[0].SetActive(true);   B1_0[2].SetActive(true);
        }else{
            A1_0[1].SetActive(true);    B1_0[1].SetActive(true);
            A2_0[2].SetActive(true);    B2_0[0].SetActive(true);
        }
    }

    public void SetupFragmentation()
    {
        int R;R = Random.Range(0, 4);
        if (R == 0){
            A1_0[R].SetActive(true); B1_0[R].SetActive(true);
            A2_0[R].SetActive(true); B2_0[R].SetActive(true);
        }else if (R == 1){
            A1_0[R].SetActive(true); B1_0[R].SetActive(true);
            A2_0[R].SetActive(true); B2_0[R].SetActive(true);
        }else if (R == 2){
            A2_0[2].SetActive(true);
        }else{
            A1_0[1].SetActive(true);    B1_0[1].SetActive(true);
            A2_0[0].SetActive(true);    A2_0[2].SetActive(true);    B2_0[2].SetActive(true);
        }
    }

    public void SetupVerticalFragmentationA()
    {
        int R;R = Random.Range(0, 3);
        if (R == 0){
            A1_0[1].SetActive(true);
            A2_0[1].SetActive(true);
        }else if (R == 1){
            A1_0[0].SetActive(true);    A1_0[2].SetActive(true);
            A2_0[0].SetActive(true);    A2_0[2].SetActive(true);
        }
        else{
            A1_0[2].SetActive(true);
            A2_0[2].SetActive(true);
        }
    }

    public void SetupVerticalFragmentationB()
    {
        int R; R = Random.Range(0, 3);
        if (R == 0){
            B1_0[1].SetActive(true);
            B2_0[1].SetActive(true);
        }else if (R == 1){
            B1_0[0].SetActive(true);
            B2_0[0].SetActive(true);
            B1_0[2].SetActive(true);
            B2_0[2].SetActive(true);
        }else{
            B1_0[0].SetActive(true);
            B2_0[0].SetActive(true);
        }
    }
    /////////////////////////////////////////Screen Square
    public void ScreenA()
    {
        A.SetActive(true);
    }
    public void ScreenB()
    {
        B.SetActive(true);
    }

    /////////////////////////////////////////LANDSCAPE
    public void SetupLandscape()
    {
        int R; R = Random.Range(0, 5);
        if (R == 0){
            A0[0].SetActive(true);
        }else if (R == 1){
            A0[1].SetActive(true);
        }else if (R == 2){
            B0[0].SetActive(true);
        }else if (R == 3){
            B0[1].SetActive(true);
        }else if (R == 4){
            A0[0].SetActive(true);
            B0[0].SetActive(true);
        }else{
            A0[1].SetActive(true);
            B0[1].SetActive(true);
        }        
    }
    public void SetupCrossLandscape()
    {
        i++;
        if (i == 1){
            A0[0].SetActive(true);
            B0[1].SetActive(true);
        }else if(i == 2){
            A0[1].SetActive(true);
            B0[0].SetActive(true);
            i = 0;
        }
    }

    public void SetupFullLandscape()
    {
        int R; R = Random.Range(0, 3);
        if (R == 0){
            ABLandscape.transform.position = new Vector3(0, 0.27f, -3);
            ABLandscape.SetActive(true);
        }else if (R == 1){
            ABLandscape.transform.position = new Vector3(0, -0.27f, -3);
            ABLandscape.SetActive(true);
        }else if (R == 2){
            ABLandscape.transform.position = new Vector3(0, 0, -3);
            ABLandscape.SetActive(true);
        }
    }

    /////////////////////////////////////////Clean
    public void CleanA()
    {
        ABLandscape.SetActive(false); 
        A.SetActive(false);         B.SetActive(false);

        A0[0].SetActive(false);     B0[0].SetActive(false);
        A0[1].SetActive(false);     B0[1].SetActive(false);

        A1_0[0].SetActive(false);   B1_0[0].SetActive(false);
        A1_0[1].SetActive(false);   B1_0[1].SetActive(false);
        A1_0[2].SetActive(false);   B1_0[2].SetActive(false);

        A2_0[0].SetActive(false);   B2_0[0].SetActive(false);
        A2_0[1].SetActive(false);   B2_0[1].SetActive(false);
        A2_0[2].SetActive(false);   B2_0[2].SetActive(false);
    }
}
