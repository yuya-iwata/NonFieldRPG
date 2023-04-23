using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public new string name;
    public int hp;
    public int at;

    public void Attack(PlayerManager player)
    {
        player.Damage(at);
    }

    public void Damage(int damege)
    {
        hp -= damege;
        Debug.Log("Enemy‚ÌHP‚Í" + hp);
    }

    public void OnTap()
    {
        Debug.Log("Click");
    }

}
