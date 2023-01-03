using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    List<GameObject> minions;
    public GameObject minionPrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    private void Start()
    {
        this.minions = new List<GameObject>();
    }

    private void Update()
    {
        this.Spawn();
        this.CheckMinionDead();
    }

    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;

        if(this.minions.Count > 7) return;
        //Debug.Log("Spawn Bom");
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Bom";
        minion.transform.position = this.transform.position;
        minion.SetActive(true);
        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        GameObject minion;
        for(int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if (minion == null) this.minions.RemoveAt(i);
        }
    }
}
