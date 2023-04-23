using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public new string name;
    public int hp;
    public int at;
    Action tapAction;

    public void Attack(PlayerManager player)
    {
        player.Damage(at);
    }

    public void Damage(int damege)
    {
        hp -= damege;
        Debug.Log("Enemy‚ÌHP‚Í" + hp);
    }
    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }

    public void OnTap()
    {
        tapAction();
    }

}
