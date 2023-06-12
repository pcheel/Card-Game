using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    public CharacterView characterView{get;}
    public void Inizialize(IFactory factory, GameObject characterPrefab, Transform parent, CharacterData data);
}
