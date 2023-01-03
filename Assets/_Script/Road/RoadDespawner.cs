using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawner : MonoBehaviour
{
    protected float distance;

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtl.instance.transform.position, transform.position);// (vi tri xe, vi tri duong dang lien ket)
        if (distance > 70) this.Despawn();
    }

    protected virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
