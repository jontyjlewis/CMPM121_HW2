using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    private bool end = false;
    private float dirX = 1f;
    [SerializeField] private float moveSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        // start at 6 x, finish at -5 x
        if (!end)
        {
            if (transform.position.x >= -5f)
            {
                transform.position -= new Vector3(dirX * moveSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                end = true;
            }
        }
        if (end)
        {
            if (transform.position.x < 6f)
            {
                transform.position += new Vector3(dirX * moveSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                end = false;
            }
        }
    }
}
