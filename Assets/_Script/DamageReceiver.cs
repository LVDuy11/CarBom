using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{   
    //hehe
    [Header("DamageReceiver")]
    public int hp = 1;
    public virtual bool IsDead()
        {
            return this.hp <= 0;
        }
    public virtual void Receive(int damage)
    {
        this.hp -= damage;
    }  
}
