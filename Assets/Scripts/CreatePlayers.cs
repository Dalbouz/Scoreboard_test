using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayers : MonoBehaviour
{
    [SerializeField]
    private PlayerDatabaseSO _playersDB;
    [SerializeField]
    private GameObject PlayerSlot;
    [SerializeField]
    private Player You;

    private void Start()
    {
        UImanager.instance.Players = new List<Playerinfo>();
        FillWithPlayers();
        UImanager.instance.BattlePoints();
        this.gameObject.GetComponent<Order>().OrderByTopRank();
    }

    private void FillWithPlayers()
    {
        Playerinfo PlayerInfoScript;
        GameObject NewGridObj;
        for (int i = 0; i < _playersDB.Playerdatabase.Count; i++)
        {
            NewGridObj = Instantiate(PlayerSlot, transform);
            PlayerInfoScript = NewGridObj.GetComponent<Playerinfo>();
            PlayerInfoScript.PlayerdataSO = _playersDB.Playerdatabase[i];
            PlayerInfoScript.Rank.text = PlayerInfoScript.PlayerdataSO.Rank.ToString();
            PlayerInfoScript.Name.text = PlayerInfoScript.PlayerdataSO.Name.ToString();
            PlayerInfoScript.BattlePoints.text = PlayerInfoScript.PlayerdataSO.BattlePoints.ToString();
            PlayerInfoScript.WinRatio.text = PlayerInfoScript.PlayerdataSO.WinRatio.ToString();
            PlayerInfoScript.ExpPoints.text = PlayerInfoScript.PlayerdataSO.ExpPoints.ToString();
            PlayerInfoScript.BrickCount.text = PlayerInfoScript.PlayerdataSO.BrickCount.ToString();
            UImanager.instance.Players.Add(PlayerInfoScript);
            if(PlayerInfoScript.PlayerdataSO.Rank>=1 && PlayerInfoScript.PlayerdataSO.Rank <= 4)
            {
                PlayerInfoScript.Top4Rank.enabled = true;
            }
            if (PlayerInfoScript.PlayerdataSO.IsPlayer) //CREATE THE PLAYER AND ADD SOME FRIENDS TO HIS FRIEND LIST
            {
                NewGridObj.AddComponent<Player>();
                var PlayerScript = NewGridObj.GetComponent<Player>();
                PlayerScript.FriendList = new List<Playerinfo>();
                for (int j = 0; j < PlayerScript.NumOfFriends; j++)
                {
                    if (!UImanager.instance.Players[j].PlayerdataSO.IsPlayer)
                    {
                        PlayerScript.FriendList.Add(UImanager.instance.Players[j]);
                    }
                   
                }
            }

        }
    }
}
