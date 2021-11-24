using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    [SerializeField] float m_jumpPower;
    [SerializeField] float m_settiLength;
    [SerializeField] LayerMask m_zimen;
    int m_jumpCount;
    Rigidbody2D m_rb;
   
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerInput();
        PlayerState();
    }

    void PlayerInput()
    {
        if(Input.GetButtonDown("Jump") && m_jumpCount < 2)
        {
            m_jumpCount++;
            Jump();
        }
    }

    void PlayerState()
    {
        if (isGround())
        {
            m_jumpCount = 0;
        }

        Debug.Log(isGround());
    }

    void Jump()
    {
        m_rb.velocity = Vector2.up * m_jumpPower;
    }

    bool isGround()
    {
        bool jumpray = Physics2D.Raycast(transform.position, Vector2.down, m_settiLength, m_zimen);
        Debug.DrawRay(transform.position, Vector2.down * m_settiLength);
        return jumpray;
    }
}
