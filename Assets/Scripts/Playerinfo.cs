using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerinfo : MonoBehaviour
{
    public PlayerSO PlayerdataSO;
    public Text Rank;
    public Text Name;
    public Text BattlePoints;
    public Text WLratio;
    public Text WinRatio;
    public Text ExpPoints;
    public Text BrickCount;
    public Image Top4Rank;

    public void OnClick()
    {
        UImanager.instance.PlayerName.text =PlayerdataSO.Name;
        UImanager.instance.Money.text = "Money: " + PlayerdataSO.Money.ToString();
        UImanager.instance.Diamond.text ="Diamond: " + PlayerdataSO.Diamond.ToString();
    }
}


