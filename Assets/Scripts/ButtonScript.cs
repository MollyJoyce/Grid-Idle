using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{

    public float Blocks;
    public float BlocksPerClick = 1f;

    public TextMeshProUGUI BlockNumTxt;
    public TextMeshProUGUI SquareNumTxt;



    public float AutoBlocks;
    public float AutoStrength = 1f;
    public float AutoCost = 10;
    public float AutoValue = 5;
    public float AutoStrengthCost = 25;

    public TextMeshProUGUI AutoNumTxt;
    public TextMeshProUGUI BlockSecTxt;
    public TextMeshProUGUI AutoStrengthTxt;

    public List<float> AutoBlockList = new List<float>();



    public float AutoDes;
    public float DesStrength = 1f;
    public float DesCost = 10;
    public float DesValue = 5;
    public float DesStrengthCost = 25;

    public TextMeshProUGUI AutoDesTxt;
    public TextMeshProUGUI DesSecTxt;
    public TextMeshProUGUI DesStremgthTxt;

    public List<float> AutoDesList = new List<float>();



    public float Money;
    public TextMeshProUGUI MoneyTxt;

    public TextMeshProUGUI AutoCostTxt;
    public TextMeshProUGUI AutoValueTxt;

    public TextMeshProUGUI DesCostTxt;
    public TextMeshProUGUI DesValueTxt;

    public float BlockValue = 10;


    public void BuildClick()
    {

        Blocks += BlocksPerClick;

        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;
    }


    public void DesClick()
    {
        if (Blocks >= 1)
        {
            Blocks -= BlocksPerClick;

            DesBlockClick();

            BlockNumTxt.text = "Blocks: " + Blocks;
            //SquareNumTxt.text = "Squares: " + Blocks;
        }
    }

    public void AutoBlockBuy()
    {
        if (Money >= AutoCost)
        {
            AutoBlocks++;

            AutoBlockList.Add(Time.time);

            AutoCost = AutoCost * 2;
            AutoValue = Mathf.Round(AutoCost / 3);

            Money -= AutoCost;

            MoneyTxt.text = "$" + Money;

            AutoCostTxt.text = "-$" + AutoCost;
            AutoValueTxt.text = "+$" + AutoValue;

            AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
            BlockSecTxt.text = "Built/Sec: " + AutoBlocks * AutoStrength;
        }
    }


    public void AutoBlockSell()
    {

        if (AutoBlocks > 0)
        {
            AutoBlocks--;

            Money += AutoValue;

            AutoBlockList.RemoveAt(0);

            MoneyTxt.text = "$" + Money;

            AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
            BlockSecTxt.text = "Built/Sec: " + AutoBlocks * AutoStrength;
        }
    }


    public void AutoDesBuy()
    {
        if (Money >= DesCost)
        {
            AutoDes++;

            AutoDesList.Add(Time.time);

            Money -= DesCost;

            DesCost = DesCost * 2;
            DesValue = Mathf.Round(DesCost / 3);

            MoneyTxt.text = "$" + Money;

            DesCostTxt.text = "-$" + DesCost;
            DesValueTxt.text = "+$" + DesValue;

            AutoDesTxt.text = "Auto Destroys:  " + AutoDes;
            DesSecTxt.text = "Destroyed/Sec: " + AutoDes * DesStrength;
        }
    }


    public void AutoDesSell()
    {
        if (AutoDes > 0)
        {
            AutoDes--;

            Money += DesValue;

            AutoDesList.RemoveAt(0);

            MoneyTxt.text = "$" + Money;

            AutoDesTxt.text = "Auto Destroys:  " + AutoDes;
            DesSecTxt.text = "Destroyed/Sec: " + AutoDes * DesStrength;
        }
    }

    public void BuildBlock()
    {
        if (Blocks % 1 == 0)
        {
            
        }
    }

    public void DesBlockClick()
    {
        Money += BlockValue;

        MoneyTxt.text = "$" + Money;

    }

    private void Start()
    {
        BlockNumTxt.text = "Blocks: " + Blocks;
        //SquareNumTxt.text = "Squares: " + Blocks;

        AutoNumTxt.text = "Auto Blocks: " + AutoBlocks;
        BlockSecTxt.text = "Built/Sec: " + AutoBlocks * AutoStrength;

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


        for (int j = 0; j < AutoDesList.Count; j++)
        {

            Debug.Log(j);

            if (Time.time - AutoBlockList[j] >= 1)
            {
                if(Blocks >= DesStrength)
                AutoDesList[j] = Time.time;

                Blocks -= DesStrength;

                Money += BlockValue;

                Debug.Log(Money);

                MoneyTxt.text = "$" + Money;

                BlockNumTxt.text = "Blocks: " + Blocks;
            }
        }
    }
}
