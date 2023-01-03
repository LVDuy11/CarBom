using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyDamageSender : DamageSender
{
    [Header("Emeny")]
    protected EmenyCtl emenyCtl;

    private void Awake()
    {
        this.emenyCtl = GetComponent<EmenyCtl>();
    }

    protected override void ColliderSendDamage(Collider2D collision)
    {
        base.ColliderSendDamage(collision);

        this.emenyCtl.damageReceiver.Receive(1);
    }
}
