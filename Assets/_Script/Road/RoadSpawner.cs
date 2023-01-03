using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RoadSpawner : MonoBehaviour
{
    [Header("Road")]
    protected GameObject spawnerPrefab;
    protected GameObject spawnerPos;
    protected float distance = 0;// kiem tra di chuyen bao xa
    protected GameObject roadCurrent; // lay duong hien tai

    private void Awake()
    {
        this.spawnerPrefab = GameObject.Find("RoadPrefab");
        this.spawnerPos = GameObject.Find("RoadSpawnPos");
        this.spawnerPrefab.SetActive(false);// tat di k lay dc toa o nen 'current phai lay toa do o this.Spawn(pos)

        //this.roadCurrent = this.roadPrefab;
        this.Spawn(this.spawnerPrefab.transform.position);
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(PlayerCtl.instance.transform.position, this.roadCurrent.transform.position);// (vi tri xe, vi tri duong hien tai)
        if (distance > 30) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.spawnerPos.transform.position;
        pos.x=0;
        
        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.roadCurrent = Instantiate(this.spawnerPrefab, position, this.spawnerPrefab.transform.rotation); //(cai can de, vi tri, rotation)
        this.roadCurrent.transform.parent = transform; // nhom road dc sinh ra
        this.roadCurrent.SetActive(true);
    }
}
