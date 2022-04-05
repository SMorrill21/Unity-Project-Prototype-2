using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 20; // Left/Right Player Speed

    private float horizontalMovement; // Horizontal Movement Variable
    private float verticalMovement; // Vertical Movement Variable
    private float xRange = 20; // Horizontal Boundary
    private float zRangeTop = 15;
    private float zRangeBot = 0;

    public GameObject projectilePrefab; // Grabs the projectile food prefabs


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        } 
        else if (transform.position.z > zRangeTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }
        else if (transform.position.z < zRangeBot)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBot);
        }

        
        horizontalMovement = Input.GetAxis("Horizontal"); // Get Horizontal Movement
        transform.Translate(Vector3.right * Time.deltaTime * horizontalMovement * playerSpeed); // Make Player move Left/Right

        verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalMovement * playerSpeed); // Move Player Up/Down

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a prefab projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
