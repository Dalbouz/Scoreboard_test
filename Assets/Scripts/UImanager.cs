using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public static UImanager instance;
    public Text PlayerName;
    public Text Money;
    public Text Diamond;
    public List<Playerinfo> Players;
    [SerializeField]
    private Image _battlePointsImg;
    [SerializeField]
    private List<IsOpen> Stats;
    [SerializeField]
    private UpperInfoPanel _upperInfoPanel;


    private void Awake()
    {
        if (this.gameObject.activeInHierarchy) instance = this;
    }

    private void Start()
    {
        foreach (IsOpen stat in Stats)
        {
            if (!stat.IsStatsOpen)
            {
                stat.gameObject.GetComponent<Image>().color = Color.gray;
            }
            else
                stat.gameObject.GetComponent<Image>().color = Color.black;
        }
        
    }

    public void BattlePoints()
    {
        _upperInfoPanel.DisableAllUpperInfoPanel();
        DisableAll();
        foreach (Playerinfo player in Players)
        { 
            player.BattlePoints.gameObject.SetActive(true);          
        }
        _upperInfoPanel.EnableBP();
        UnselectedColor();
        Stats[0].gameObject.GetComponent<Image>().color = Color.black;
        Stats[0].IsStatsOpen = true;

    }

    public void WLRatio()
    {
        _upperInfoPanel.DisableAllUpperInfoPanel();
        DisableAll();
        foreach (Playerinfo player in Players)
        {
            player.WLratio.gameObject.SetActive(true);
            player.WinRatio.gameObject.SetActive(true);
        }
        _upperInfoPanel.EnableWLRatio();
        UnselectedColor();
        Stats[1].gameObject.GetComponent<Image>().color = Color.black;
        Stats[1].IsStatsOpen = true;
    }

    public void EXPpoints()
    {
        _upperInfoPanel.DisableAllUpperInfoPanel();
        DisableAll();
        foreach (Playerinfo player in Players)
        {
            player.ExpPoints.gameObject.SetActive(true);
        }
        _upperInfoPanel.EnableExp();
        UnselectedColor();
        Stats[2].gameObject.GetComponent<Image>().color = Color.black;
        Stats[2].IsStatsOpen = true;
    }

    public void SpecialTraning()
    {
        _upperInfoPanel.DisableAllUpperInfoPanel();
        DisableAll();
        foreach (Playerinfo player in Players)
        {
            player.BrickCount.gameObject.SetActive(true);
        }
        _upperInfoPanel.EnableBrickPoints();
        UnselectedColor();
        Stats[3].gameObject.GetComponent<Image>().color = Color.black;
        Stats[3].IsStatsOpen = true;
    }

    private void DisableAll()
    {
        foreach (Playerinfo player in Players)
        {
            player.BattlePoints.gameObject.SetActive(false);
            player.WLratio.gameObject.SetActive(false);
            player.WinRatio.gameObject.SetActive(false);
            player.ExpPoints.gameObject.SetActive(false);
            player.BrickCount.gameObject.SetActive(false);
        }

    }

    private void UnselectedColor()
    {
        foreach (IsOpen stat in Stats)
        {
            if (stat.IsStatsOpen)
            {
                stat.gameObject.GetComponent<Image>().color = Color.gray;
            }
        }
    }
}

