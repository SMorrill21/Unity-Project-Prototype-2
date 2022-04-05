using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeTemp = 0;

    // Update is called once per frame
    void Update()
    {
        timeTemp += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeTemp > 1)
        {
            timeTemp = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
