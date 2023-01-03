using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ghi ?è lên DamageReceiver ?? check dead thay vì update ? playerStatus liên t?c
public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerCtl playerCtl;

    private void Awake()
    {
        this.playerCtl = GetComponent<PlayerCtl>(); 
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            this.playerCtl.playerStatus.Dead();
            UIManager.instance.btnGameOver.SetActive(true);
        }
    }
}
