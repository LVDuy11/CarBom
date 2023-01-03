using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtl : MonoBehaviour
{
    public static PlayerCtl instance;

    public DamageReceiver damageReceiver;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        PlayerCtl.instance = this;
        this.damageReceiver = GetComponent<DamageReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
