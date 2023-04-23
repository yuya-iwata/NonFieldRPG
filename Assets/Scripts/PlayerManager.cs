using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int hp;
    public int at;

    public void Attack(EnemyManager enemy)
    {
        enemy.Damage(at);
    }

    public void Damage(int damege)
    {
        hp -= damege;
        if (hp <= 0)
        {
            hp = 0;
        }
    }

}
