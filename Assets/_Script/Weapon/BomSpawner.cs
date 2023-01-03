using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomSpawner : Spawner
{
    //[Header("Bom")]

    //List<GameObject> spawnerList;
    //public GameObject spawnerPrefab;
    //public GameObject spawnerPos;
    //protected float spawnTimer = 0f;
    //protected float spawnDelay = 1f;

    //private void Awake()
    //{
    //    this.spawnerList = new List<GameObject>();
    //    this.spawnerPrefab = GameObject.Find("BomPrefab");
    //    this.spawnerPos = GameObject.Find("BomSpawnPos");
    //    this.spawnerPrefab.SetActive(false);
    //}

    private void Reset()
    {
        this.spawnPosName = "BomSpawnPos";
        this.spawnPrefabName = "BomPrefab";
        this.maxSpawn = 7;
    }

    //void Spawn()
    //{
    //    this.spawnTimer += Time.deltaTime;
    //    if (this.spawnTimer < this.spawnDelay) return;
    //    this.spawnTimer = 0f;

    //    if (this.spawnerList.Count > this.maxSpawn) return;
    //    //Debug.Log("Spawn Bom");
    //    GameObject minion = Instantiate(this.spawnerPrefab);
    //    minion.name = "Bom";
    //    minion.transform.position = this.spawnerPos.transform.position;
    //    minion.transform.parent = transform;
    //    minion.SetActive(true);
    //    this.spawnerList.Add(minion);
    //}

    //void CheckMinionDead()
    //{
    //    GameObject minion;
    //    for (int i = 0; i < this.spawnerList.Count; i++)
    //    {
    //        minion = this.spawnerList[i];
    //        if (minion == null) this.spawnerList.RemoveAt(i);
    //    }
    //}
}
