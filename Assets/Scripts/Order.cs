using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public void OrderByTopRank()
    {
        
        for (int i = 0; i < UImanager.instance.Players.Count; i++)
        {
            UImanager.instance.Players[i].gameObject.SetActive(true);
            if(UImanager.instance.Players[i].PlayerdataSO.Rank == 1)
            {
                UImanager.instance.Players[i].gameObject.transform.SetAsFirstSibling();
            }
            else if(UImanager.instance.Players[i].PlayerdataSO.Rank == UImanager.instance.Players.Count)
            {
                UImanager.instance.Players[i].gameObject.transform.SetAsLastSibling();
            }
        }


        for (int i = 1; i < UImanager.instance.Players.Count; i++)
        {
            foreach (Playerinfo playerinfo in UImanager.instance.Players)
            {
                if(playerinfo.PlayerdataSO.Rank == i + 1)
                {
                    playerinfo.gameObject.transform.SetSiblingIndex(i);
                }
            }
        }
    }

    public void OrderByFriendsList()
    {
        for (int i = 0; i < UImanager.instance.Players.Count; i++)
        {
            if (!Player.instance.FriendList.Contains(UImanager.instance.Players[i])){
                if(!UImanager.instance.Players[i].PlayerdataSO.IsPlayer)
                    UImanager.instance.Players[i].gameObject.SetActive(false);
            }
        }
        //for (int i = 0; i < Player.instance.FriendList.Count; i++)
        //{
        //    if (UImanager.instance.Players[i].PlayerdataSO.Rank == 1)
        //    {
        //        UImanager.instance.Players[i].gameObject.transform.SetAsFirstSibling();
        //    }
        //    else if (UImanager.instance.Players[i].PlayerdataSO.Rank == UImanager.instance.Players.Count)
        //    {
        //        UImanager.instance.Players[i].gameObject.transform.SetAsLastSibling();
        //    }
        //}


        //for (int i = 1; i < UImanager.instance.Players.Count; i++)
        //{
        //    foreach (Playerinfo playerinfo in UImanager.instance.Players)
        //    {
        //        if (playerinfo.PlayerdataSO.Rank == i + 1)
        //        {
        //            playerinfo.gameObject.transform.SetSiblingIndex(i);
        //        }
        //    }
        //}
    }

    public void OrderByMyRank()
    {

    }
}

