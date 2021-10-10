using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render_Manager : MonoBehaviour
{

    public Composition_Manager Compo;
    public Cam_Manager Cam;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown("a")) /////// Full Landscape
        {
            //Compo.CleanA();
            Compo.SetupFullLandscape();
        }
        if (Input.GetKeyDown("z")) /////// Screen A full
        {
            Compo.CleanA();
            Compo.ScreenA();
        }

        if (Input.GetKeyDown("e"))  /////// Screen B full
        {
            Compo.CleanA();
            Compo.ScreenB();
        }
        if (Input.GetKeyDown("r"))  /////// Landscape
        {
            Compo.CleanA();
            Compo.SetupLandscape();
        }
        if (Input.GetKeyDown("t")) /////// Cross Landscape
        {
            Compo.CleanA();
            Compo.SetupCrossLandscape();
        }
        if (Input.GetKeyDown("y")) /////// Vertical fragmentation A
        {
            Compo.SetupVerticalFragmentationA();
        }
        if (Input.GetKeyDown("u")) /////// Vertical fragmentation B
        {
            Compo.SetupVerticalFragmentationB();
        }
        if (Input.GetKeyDown("i")) /////// fragmentation AB
        {
            Compo.SetupFragmentation();
        }
        if (Input.GetKeyDown("o")) /////// Total Fragmentation
        {
            Compo.CleanA();
            Compo.SetupTotalFragmentation();
        }

        if (Input.GetKeyDown("q")) /////// Cam Ortho A
        {
            Cam.SetCamOrthoA();
        }

        if (Input.GetKeyDown("s")) /////// Cam Ortho B
        {
            Cam.SetCamOrthoB();
        }



        if (Input.GetKeyDown("space"))  /////// Just Clean
        {
            Compo.CleanA();
        }
    }
}
