using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render_Manager : MonoBehaviour
{

    public Composition_Manager Compo;
    public Cam_Manager Cam;
    public Scene_Manager Scene;

    public int Intensity;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown("a")) /////// Full Landscape
        {
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
            Compo.SetupLandscape();
        }
        if (Input.GetKeyDown("t")) /////// Cross Landscape
        {
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
        if (Input.GetKeyDown("d")) /////// Cam random set translation
        {
            Intensity++;
            Cam.CamTranslation();
        }

        if (Input.GetKeyDown("w")) /////// TEXT PAEAN
        {
            Scene.TextPaeanApparition();
        }




        if (Input.GetKeyDown("space"))  /////// Just Clean
        {
            Intensity = 0;
            Compo.CleanA();
        }
    }
}
