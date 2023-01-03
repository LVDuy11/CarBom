using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")]
    public GameObject spawnerPrefab;
    public GameObject spawnerPos;
    public List<GameObject> spawnerList;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;
    public string spawnPrefabName = "";
    public string spawnPosName = "";
    public int maxSpawn = 2;


    private void Awake()
    {
        this.spawnerList = new List<GameObject>();
        this.spawnerPrefab = GameObject.Find(this.spawnPrefabName);
        this.spawnerPos = GameObject.Find(this.spawnPosName);
        this.spawnerPrefab.SetActive(false);
    }

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtl.instance.damageReceiver.IsDead()) return;
        if (this.spawnerList.Count >= maxSpawn) return;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;

        GameObject emeny = Instantiate(this.spawnerPrefab);
        emeny.transform.position = this.spawnerPos.transform.position;
        emeny.transform.parent = transform;// tao nhom: sinh ra trong EmenySpawner
        emeny.SetActive(true);

        this.spawnerList.Add(emeny);
    }

    protected virtual void CheckDead()
    {
        GameObject minion;
        for (int i = 0; i < this.spawnerList.Count; i++)
        {
            minion = this.spawnerList[i];
            if (minion == null) this.spawnerList.RemoveAt(i);
        }
    }
}
