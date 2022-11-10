using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownLogic : MonoBehaviour
{
    [SerializeField]
    private Order _orderCommand;
    public void HandleInput(int value)
    {
        switch (value)
        {
            case 0:
                _orderCommand.OrderByTopRank();
                break;
            case 1:
                _orderCommand.OrderByFriendsList();
                break;
            case 2:
                _orderCommand.OrderByMyRank();
                break;
            default:
                break;
        }
    }
}
