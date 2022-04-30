using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRigidbody2D;
    [SerializeField] Animator playerAnimator;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);  
    }

    // Update is called once per frame
    void Update()
    {
        float movementLR = Input.GetAxis("Horizontal");
        float movementUD = Input.GetAxis("Vertical");
        playerRigidbody2D.velocity = new Vector2(movementLR, movementUD)*movementSpeed;
        playerAnimator.SetFloat("movementX", playerRigidbody2D.velocity.x);
        playerAnimator.SetFloat("movementY", playerRigidbody2D.velocity.y);

        if (movementUD == 1 || movementUD == -1 || movementLR == 1 || movementLR ==-1)
        {
            playerAnimator.SetFloat("lastX", movementLR);
            playerAnimator.SetFloat("lastY", movementUD);
        }
    }

}
