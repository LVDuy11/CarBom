using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenySpawner : Spawner
{
    //[Header("Emeny")]

    //protected List<GameObject> spawnerList;
    //protected int maxSpawn = 2;
    //protected GameObject spawnerPos;
    //protected GameObject spawnerPrefab;
    //protected float spawnTimer = 0f;
    //protected float spawnDelay = 2f;

    //private void Awake()
    //{
    //    this.spawnerPrefab = GameObject.Find("EmenyPrefab");
    //    this.spawnerPos = GameObject.Find("EmenySpawnPos");
    //    this.spawnerPrefab.SetActive(false);

    //    this.spawnerList = new List<GameObject>();
    //}

    private void Reset()
    {
        this.spawnPosName = "EmenySpawnPos";
        this.spawnPrefabName = "EmenyPrefab";
    }

    //protected virtual void Spawn()
    //{
    //    if (PlayerCtl.instance.damageReceiver.IsDead()) return;
    //    if (this.spawnerList.Count >= maxSpawn) return;

    //    this.spawnTimer += Time.deltaTime;
    //    if (this.spawnTimer < this.spawnDelay) return;
    //    this.spawnTimer = 0f;

    //    GameObject emeny = Instantiate(this.spawnerPrefab);
    //    emeny.transform.position = this.spawnerPos.transform.position;
    //    emeny.transform.parent = transform;// tao nhom: sinh ra trong EmenySpawner
    //    emeny.SetActive(true);

    //    this.spawnerList.Add(emeny);
    //}

    //void CheckEmenyDead()
    //{
    //    GameObject minion;
    //    for (int i = 0; i < this.spawnerList.Count; i++)
    //    {
    //        minion = this.spawnerList[i];
    //        if (minion == null) this.spawnerList.RemoveAt(i);
    //    }
    //}
}
