using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    public int historyData01;
    public int historyData02;
    public int historyData03;

    public SaveData()
    {
        //if (PlayerPrefs.HasKey("historyData01"))
        {
            historyData01 = PlayerPrefs.GetInt("historyData01");//キーがなかったら初期値を返す仕様なので↑の分岐は不要
        }
        //if (PlayerPrefs.HasKey("historyData02"))
        {
            historyData02 = PlayerPrefs.GetInt("historyData02");
        }
        //if (PlayerPrefs.HasKey("historyData03"))
        {
            historyData03 = PlayerPrefs.GetInt("historyData03");
        }
    }

    public void saveResult( int _result )
    {

        if (historyData01 == 0)
        {
            historyData01 = _result;
            PlayerPrefs.SetInt("historyData01", historyData01);
        }
        else
        {
            if (historyData02 == 0)
            {
                historyData02 = historyData01;
                historyData01 = _result;
                PlayerPrefs.SetInt("historyData02", historyData02);
                PlayerPrefs.SetInt("historyData01", historyData01);
            }
            else
            {
                historyData03 = historyData02;
                historyData02 = historyData01;
                historyData01 = _result;
                PlayerPrefs.SetInt("historyData03", historyData03);
                PlayerPrefs.SetInt("historyData02", historyData02);
                PlayerPrefs.SetInt("historyData01", historyData01);
            }
        }

    }
}
