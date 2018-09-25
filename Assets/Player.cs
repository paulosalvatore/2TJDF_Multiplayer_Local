using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2f;
    public float rotationSpeed = 100f;

    private float h = 0;
    private float v = 0;

    public enum PLAYERS
    {
        PLAYER_1,
        PLAYER_2
    }

    public PLAYERS player;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
	}

	void Update()
    {
        if (player == PLAYERS.PLAYER_1)
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }
        else if (player == PLAYERS.PLAYER_2)
        {
            h = Input.GetAxis("Horizontal2");
            v = Input.GetAxis("Vertical2");
        }

        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * h * rotationSpeed * Time.deltaTime);
	}
}
