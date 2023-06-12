using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPositionsController : MonoBehaviour
{
    [SerializeField] private Transform _playerPositionPoint;
    [SerializeField] private List<Transform> _enemyPositionPoints;

    public void RefreshEnemiesPositions(List<ICharacter> enemies)
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i].characterView.transform.parent = _enemyPositionPoints[i];
            enemies[i].characterView.transform.localPosition = Vector3.zero;
            enemies[i].characterView.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }
    }
    public void RefreshPlayerPosition (ICharacter player)
    {
        player.characterView.transform.parent = _playerPositionPoint;
        player.characterView.transform.localPosition = Vector3.zero;
        player.characterView.transform.localRotation = Quaternion.Euler(Vector3.zero);
    }
}
