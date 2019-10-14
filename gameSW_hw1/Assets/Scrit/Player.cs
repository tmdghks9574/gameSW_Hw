using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject health;
    private int k = 0;
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Destroy(health.transform.GetChild(0).gameObject);
        if (health.transform.childCount == 1)
        {
            Time.timeScale = 0;
        }
    }
    private static float moveSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8.5f)
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.5f)
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
    }
}
