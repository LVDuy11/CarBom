using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyCtl : MonoBehaviour
{
    public DesSpawner desSpawner;
    public EmenyDamageReceiver damageReceiver;

    private void Awake()
    {
        this.desSpawner = GetComponent<DesSpawner>();
        this.damageReceiver = GetComponent<EmenyDamageReceiver>();
    }
}
