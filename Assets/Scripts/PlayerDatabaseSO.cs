using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Player/PlayerDatabase")]

public class PlayerDatabaseSO : ScriptableObject
{
    public List<PlayerSO> Playerdatabase;
}