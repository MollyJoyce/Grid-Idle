using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public float Blocks;

    public float BlocksPerClick = .2f;

    public void BlockPress()
    {

        Debug.Log("Clicked");

        Blocks += BlocksPerClick;

        Debug.Log(Blocks);
    }
    
}
