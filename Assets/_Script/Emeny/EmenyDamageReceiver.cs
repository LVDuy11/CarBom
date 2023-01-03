using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyDamageReceiver : DamageReceiver
{
    [Header("Emeny")]
    protected EmenyCtl emenyCtl;

    private void Awake()
    {
        this.emenyCtl = GetComponent<EmenyCtl>();
    }

    private void Reset()
    {
        this.hp = 3;
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead()) 
        {
            this.emenyCtl.desSpawner.Destroy();
            EffectManager.instance.SpawnVFX("Explosion_A", transform.position, transform.rotation);
        }
    }

}
