using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementLR = Input.GetAxis("Horizontal");
        float movementUD = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(movementLR, movementUD);
        
    }
}
