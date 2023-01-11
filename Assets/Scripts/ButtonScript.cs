using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public float Blocks;
    public float BlocksPerClick = .2f;

    public TextMeshProUGUI BlockNumTxt;
    public TextMeshProUGUI SquareNumTxt;



    public float AutoBlocks;
    public float AutoStrength = .2f;
    public float AutoCost = 10;
    public float AutoValue = 5;

    public TextMeshProUGUI AutoNumTxt;
    public TextMeshProUGUI BlockSecTxt;



    public float Money;
    public TextMeshProUGUI MoneyTxt;
    public TextMeshProUGUI AutoCostTxt;
    public TextMeshProUGUI AutoValueTxt;

    public void BlockPress()
    {

        Blocks += BlocksPerClick;

        Debug.Log(Blocks);

        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;
    }

    public void AutoBlockBuy()
    {
        AutoBlocks ++;

        Debug.Log(AutoBlocks);

        AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
       // BlockSecTxt.text = "Blocks/Sec: " + Blocks;
    }


    private void Start()
    {
        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;
        AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
        // BlockSecTxt.text = "Blocks/Sec: " + Blocks;
        MoneyTxt.text = "$" + Money;
        AutoCostTxt.text = "-$" + AutoCost;
        AutoValueTxt.text = "+$" + AutoValue;

    }
}
