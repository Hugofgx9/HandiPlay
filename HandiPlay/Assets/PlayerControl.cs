using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0f)
        {
            transform.localPosition = transform.localPosition + Time.deltaTime * m_speed *
           Vector3.left;
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            transform.localPosition = transform.localPosition + Time.deltaTime * m_speed *
           Vector3.right;
        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.up);
        }
        if (Input.GetAxis("Vertical") < 0f)

        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.down);
        }
    }
}
