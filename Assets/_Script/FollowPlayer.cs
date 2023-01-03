using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    protected Transform player;
    public float speed = 40f;
    public float disLimit = 5f;
    public float randPos = 0;

    private void Awake()
    {
        this.player = PlayerCtl.instance.transform;
        randPos = Random.Range(-6,6);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.Follow();;
        //Invoke("Follow", 3f);
    }

    void Follow()
    {
        Vector3 pos = this.player.position;
        pos.x = this.randPos;

        Vector3 distance = pos - transform.position;//vi tri de follow
        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position =
                Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
