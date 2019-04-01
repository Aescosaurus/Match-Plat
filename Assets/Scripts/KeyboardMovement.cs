using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class KeyboardMovement
    :
    MonoBehaviour
{
    #region methods
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Assert.IsNotNull( body );
    }
    // FixedUpdate is called 50ish times a second I think.
    void FixedUpdate()
    {
        // Turn raw input into player movement velocity.
        if( Input.GetAxis( "Walk Left" ) > 0.0f )
        {
            moveVel.x -= moveSpeed * Time.deltaTime;
            // TODO: Rotate when moving in a direction.
        }
        if( Input.GetAxis( "Walk Right" ) > 0.0f )
        {
            moveVel.x += moveSpeed * Time.deltaTime;
        }

        // Make sure player moves no faster than allowed.
        if( moveVel.x > maxVel ) moveVel.x = maxVel;
        if( moveVel.x < -maxVel ) moveVel.x = -maxVel;

        // Jump if pressing space and not already jumping.
        if( Input.GetAxis( "Jump" ) > 0.0f && canJump )
        {
            jumping = true;
            canJump = false;
            body.useGravity = false;
        }

        // Jump for a certain duration then stop.
        if( jumping )
        {
            moveVel.y += ( jumpPower *
                ( 1.2f - jumpTimer.GetPercent() ) ) *
                Time.deltaTime;

            // Update jump timer and stop when it's done.
            jumpTimer.Update();
            if( jumpTimer.IsDone() )
            {
                jumpTimer.Reset();
                jumping = false;
                body.useGravity = true;
                // moveVel.y -= jumpPower * Time.deltaTime;
            }
        }

        // Slow down player so they don't go forever.
        // TODO: Make this based on delta time.
        moveVel *= velDecay;

        // Move the player based on velocity.
        transform.Translate( moveVel );
    }
    // When you touch ground you can jump again.
    void OnCollisionEnter( Collision otherColl )
    {
        canJump = true;
    }
    #endregion

    #region members
    Rigidbody body;

    bool jumping = false;
    bool canJump = false;
    const float jumpPower = 2.2f;
    Timer jumpTimer = new Timer( 0.16f );

    const float moveSpeed = 0.7f;
    const float maxVel = 2.1f;
    const float velDecay = 0.94f;
    Vector2 moveVel = Vector2.zero;
    #endregion
}
