using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerMovement _playerMovementScript;

    // Start is called before the first frame update
    void SpawnObstacle()
    {
        if (_playerMovementScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }

    void Start()
    {
        _playerMovementScript = GameObject.Find("SimpleFarmer_Man_02_White").GetComponent<PlayerMovement>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


