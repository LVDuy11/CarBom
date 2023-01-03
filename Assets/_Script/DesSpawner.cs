using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesSpawner : MonoBehaviour
{
    public virtual void Destroy()
    {
        Destroy(this.gameObject);
    }
}
