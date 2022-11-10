using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    public List<Playerinfo> FriendList;
    public int NumOfFriends = 3;

    private void Awake()
    {
        if (this.gameObject.activeInHierarchy) instance = this;
    }
}
