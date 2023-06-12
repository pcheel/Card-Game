using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public int curentHealth{get;}
    public int maxHealth{get;}
    public void ApplyDamage(int damage);
    public void Heal(int heal);
}
