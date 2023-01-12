using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerMovement _playerMovementScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovementScript = GameObject.Find("SimpleFarmer_Man_02_White").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerMovementScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
