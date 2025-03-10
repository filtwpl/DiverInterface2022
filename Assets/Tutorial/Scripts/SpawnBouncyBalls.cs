using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBouncyBalls : MonoBehaviour
{
    public GameObject bouncyBallPrefab;
    public int numberOfBalls = 5;
    public float heightAboveGround = 15;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < numberOfBalls; i++)
        {
            Vector3 ballPosition = new Vector3(
                Random.Range(-10f, 10f),
                heightAboveGround,
                Random.Range(-10f, 10f)
                );
            Instantiate(bouncyBallPrefab, ballPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
