using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb2D;
    public Vector2 velocity;
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    public float speedUp = 0.5f;
    public float speedDown = 0.5f;
    public float speedMax = 25f;
    public float speedHorizontal = 4f;
    public bool autoRun = false;
    private void Awake()
    {
        this.rb2D = GetComponent<Rigidbody2D>();
        this.velocity = new Vector2(0f, 0f);
    }

    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");
        if (this.autoRun)
            this.pressVertical = 1;
    }

    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }

    protected virtual void UpdateSpeed()
    {
        this.velocity.x = this.pressHorizontal * this.speedHorizontal;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();
        //move
        this.rb2D.MovePosition(this.rb2D.position + this.velocity * Time.fixedDeltaTime);
    }

    protected virtual void UpdateSpeedUp()
    {
        //hold the up button
        if (this.pressVertical <= 0) return;   
        this.velocity.y += this.speedUp;
            
        //check speed  
        if (this.velocity.y > this.speedMax) this.velocity.y = this.speedMax;

        //check on road   
        if (this.transform.position.x < -7 || this.transform.position.x > 7)
        {   
            this.velocity.y -= 1f;   
            if (this.velocity.y < 3) this.velocity.y = 3f;
        }
    }

    protected virtual void UpdateSpeedDown()
    {
        //Drop arm
        if (this.pressVertical != 0) return;
        this.velocity.y -= this.speedDown;
        
        if (this.velocity.y < 0) this.velocity.y = 0;
    }
}
