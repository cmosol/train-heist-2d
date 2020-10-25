using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTunnel : MonoBehaviour
{
    public float speed = 15f;
    private float timer = 0.0f;
    public float waitingTime = 5f;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            timer = 0f;
            Destroy(gameObject);

        }
    }
}
