using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    private Vector3 bottomLeftEdge;
    private Vector3 topRightEdge;
    [SerializeField] Tilemap tilemap; 

    public string transitonName;
    public static Player instance;
    [SerializeField] Rigidbody2D playerRigidbody2D;
    [SerializeField] Animator playerAnimator;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Sigleton pattern
        if(instance != null && instance!=this)
            Destroy(this.gameObject);
        else
            instance = this;
        DontDestroyOnLoad(gameObject);

        bottomLeftEdge = tilemap.localBounds.min + new Vector3(1.0f, 1.0f, 0f);
        topRightEdge = tilemap.localBounds.max + new Vector3(-1.0f, -1.0f, 0f); ;
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

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, bottomLeftEdge.x, topRightEdge.x),
            Mathf.Clamp(transform.position.y, bottomLeftEdge.y, topRightEdge.y),
            Mathf.Clamp(transform.position.z, bottomLeftEdge.z, topRightEdge.z)  
            );
    }

}
