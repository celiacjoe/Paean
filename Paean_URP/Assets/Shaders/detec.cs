using UnityEngine;
using System.Collections;
public class detec : MonoBehaviour
{
    public ComputeShader compute_shader;
    RenderTexture A;
    RenderTexture B;

    public GameObject img1;
    
    //public Material material;
    int handle_main;
    /*[Range(0, 1)]
    public float mousex;   */
    [Range(0, 1)]
    public float mousey;

    void Start()
    { 
  
        A = new RenderTexture(Screen.width, Screen.height, 0);
        A.enableRandomWrite = true;
        A.Create();
        B = new RenderTexture(Screen.width, Screen.height, 0);
        B.enableRandomWrite = true;
        B.Create();
        handle_main = compute_shader.FindKernel("CSMain");
    }
   
    void Update()
    {
       

        compute_shader.SetTexture(handle_main, "reader", A);
        compute_shader.SetFloat("_time", Time.time);
        compute_shader.SetFloat("_rx", Screen.width);
        compute_shader.SetFloat("_ry", Screen.height);
        //compute_shader.SetFloat("_mousex",mousex);
        compute_shader.SetFloat("_mousey", mousey);
        compute_shader.SetTexture(handle_main, "writer", B);
        compute_shader.Dispatch(handle_main, B.width / 8, B.height / 8, 1);
        compute_shader.SetTexture(handle_main, "reader", B);
        compute_shader.SetTexture(handle_main, "writer", A);
        compute_shader.Dispatch(handle_main, B.width / 8, B.height / 8, 1);
        img1.GetComponent<Renderer>().material.mainTexture = B;

    }
  
}
