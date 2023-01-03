using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtl playerCtl;

    private void Awake()
    {
        this.playerCtl = GetComponent<PlayerCtl>();
    }
    
    protected virtual void CheckDaed()
    {
        if(this.playerCtl.damageReceiver.IsDead()) this.Dead();
    }
    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
