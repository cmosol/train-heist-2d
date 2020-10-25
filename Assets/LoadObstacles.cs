using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObstacles : MonoBehaviour
{

    public GameObject terrain;
    public float speed = .5f;

    // Start is called before the first frame update
    void Start()
    {
        terrain.transform.position = new Vector3(260, 0, -1);
        terrain.transform.SetParent(transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
