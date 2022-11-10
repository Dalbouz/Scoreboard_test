using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Player/PlayerSO")]

public class PlayerSO : ScriptableObject
{
    public int Rank;
    public string Name;
    public float Money;
    public float Diamond;
    public float BattlePoints;
    public float WinRatio;
    public float ExpPoints;
    public float BrickCount;
    public bool IsPlayer;
}
