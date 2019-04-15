using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat: MonoBehaviour
{
    public Material[] furColor;
    public Material[] eyeColor;
    public GameObject body;
    public GameObject rightEye;
    public GameObject leftEye;
    public int black = 0, bdbrown = 0, bdgray = 0,buf=0;
   // public Text msg;

    Renderer rend;

     void Start()
    {
       // msg.text = " ";
        int colorIndex = (int)(Random.value * 3);
        RenderCube(body, colorIndex, eyeColor);
        buf++;
        if (colorIndex == bdbrown)
            bdbrown++;
        else if (colorIndex == bdgray)
            bdgray++;


        colorIndex = (int)(Random.value * 3);
        RenderCube(rightEye, colorIndex, eyeColor);
        RenderCube(leftEye, colorIndex, eyeColor);

        if (colorIndex == bdbrown)
            bdbrown++;
        else if (colorIndex == bdgray)
            bdgray++;

       /* if (buf < 7)
            if (bdgray > bdbrown)
                msg.text = "Fight";            
           // else if()*/
    }

    private void RenderCube(GameObject obj, int colorIndex, Material[] color)
    {
        rend = obj.GetComponent<Renderer>();
        rend.enabled = true;

        rend.sharedMaterial = color[colorIndex];
    }

}
