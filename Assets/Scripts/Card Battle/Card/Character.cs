using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : ICharacter, IDamageable
{
    private CharacterView _characterView;
    private int _curentHealth;
    private int _maxHealth;

    public CharacterView characterView => _characterView;
    public int curentHealth => _curentHealth;
    public int maxHealth => _maxHealth;

    public void Inizialize(IFactory factory, GameObject characterPrefab, Transform parent, CharacterData data)
    {
        _characterView = factory.CreateCharacterView(characterPrefab, parent);
    }
    public void ApplyDamage(int damage)
    {

    }
    public void Heal(int Damage)
    {

    }
}
