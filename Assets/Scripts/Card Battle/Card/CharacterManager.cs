using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private CharacterPositionsController _characterPositionsController;

    [Header("Prefabs")]
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _enemyPrefab;

    private ICharacter _player;
    private List<ICharacter> _enemies;
    private const int MAX_ENEMIES = 5;

    public void SpawnPlayer(IFactory factory, CharacterData playerData)
    {
        _player = factory.CreateCharacterModel();
        _player.Inizialize(factory, _playerPrefab, transform, playerData);
        _characterPositionsController.RefreshPlayerPosition(_player);
    }
    public void SpawnEnemies(IFactory factory, List<CharacterData> enemyDatas)
    {
        for (int i = 0; i < enemyDatas.Count; i++)
        {
            if (_enemies.Count < MAX_ENEMIES)
            {
                ICharacter enemy = factory.CreateCharacterModel();
                enemy.Inizialize(factory, _enemyPrefab, transform.parent, enemyDatas[i]);
                _enemies.Add(enemy);
            }
        }
        _characterPositionsController.RefreshEnemiesPositions(_enemies);
    }

    private void Awake() 
    {
        _enemies = new List<ICharacter>();
    }
}
