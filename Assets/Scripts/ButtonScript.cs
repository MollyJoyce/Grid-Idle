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
    public float AutoStrength = 1f;
    public float AutoCost = 10;
    public float AutoValue = 5;

    public TextMeshProUGUI AutoNumTxt;
    public TextMeshProUGUI BlockSecTxt;

    public List<float> AutoBlockList = new List<float>();



    public float AutoDes;
    public float DesStrength = 1f;
    public float DesCost = 10;
    public float DesValue = 5;

    public TextMeshProUGUI AutoDesTxt;
    public TextMeshProUGUI DesSecTxt;

    public List<float> AutoDesList = new List<float>();



    public float Money;
    public TextMeshProUGUI MoneyTxt;

    public TextMeshProUGUI AutoCostTxt;
    public TextMeshProUGUI AutoValueTxt;

    public TextMeshProUGUI DesCostTxt;
    public TextMeshProUGUI DesValueTxt;

    public void BuildClick()
    {

        Blocks += BlocksPerClick;

        Debug.Log(Blocks);

        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;
    }


    public void DesClick()
    {

        Blocks -= BlocksPerClick;

        Debug.Log(Blocks);

        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;
    }

    public void AutoBlockBuy()
    {
        AutoBlocks ++;

        AutoBlockList.Add(Time.time);

        AutoCost = AutoCost * 2;
        AutoValue = AutoCost / 2;

        AutoCostTxt.text = "-$" + AutoCost;
        AutoValueTxt.text = "+$" + AutoValue;

        AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
        BlockSecTxt.text = "Blocks/Sec: " + AutoBlocks * AutoStrength;
    }


    public void AutoBlockSell()
    {
        AutoBlocks--;

        Debug.Log(AutoBlocks);

        AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
        BlockSecTxt.text = "Blocks/Sec: " + AutoBlocks * AutoStrength;
    }


    public void AutoDesBuy()
    {
        AutoDes++;

        AutoDesList.Add(Time.time);

        DesCost = DesCost * 2;
        DesValue = DesCost / 2;

        DesCostTxt.text = "-$" + DesCost;
        DesValueTxt.text = "+$" + DesValue;

        AutoDesTxt.text = "Auto Destroys:  " + AutoDes;
        DesSecTxt.text = "Destroyed/Sec: " + AutoDes * DesStrength;
    }


    public void AutoDesSell()
    {
        AutoDes--;

        Debug.Log(AutoBlocks);

        AutoDesTxt.text = "Auto Destroys:  " + AutoDes;
        DesSecTxt.text = "Destroyed/Sec: " + AutoDes * DesStrength;
    }

    private void Start()
    {
        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;

        AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
        BlockSecTxt.text = "Blocks/Sec: " + AutoBlocks * AutoStrength;

        MoneyTxt.text = "$" + Money;

        AutoCostTxt.text = "-$" + AutoCost;
        AutoValueTxt.text = "+$" + AutoValue;

        DesCostTxt.text = "-$" + DesCost;
        DesValueTxt.text = "+$" + DesValue;

    }


    private void Update()
    {
        for(int i = 0; i < AutoBlockList.Count; i++)
        {
            if(Time.time - AutoBlockList[i] >= 1)
            {
                AutoBlockList[i] = Time.time;

                Blocks += AutoStrength;

                BlockNumTxt.text = "Blocks: " + Blocks;
            }
        }

        for (int i = 0; i < AutoDesList.Count; i++)
        {
            if (Time.time - AutoBlockList[i] >= 1)
            {
                AutoDesList[i] = Time.time;

                Blocks -= DesStrength;

                BlockNumTxt.text = "Blocks: " + Blocks;
            }
        }
    }
}
