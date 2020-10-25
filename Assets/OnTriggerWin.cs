using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerWin : MonoBehaviour
{
    public CharacterController2D charCon;
    public DestroyTunnel dt;
    public GameObject terrain;
    public GameObject cactus;
    public GameObject sign;
    public GameObject tumbleweed;
    public GameObject Obj_Position;
    int count = 0;
    private float timer = 0.0f;
    public float waitingTime = 5f;
    public GameObject gameOver;
    public GameObject win;
    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count = Random.Range(1, 4);

        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            timer = 0f;
            if (count == 1)
            {
                (Instantiate(cactus, Obj_Position.transform.position, Quaternion.identity)).transform.SetParent(terrain.transform);
            }

            else if (count == 2)
            {
                (Instantiate(sign, Obj_Position.transform.position, Quaternion.identity)).transform.SetParent(terrain.transform); ;
            }

            else if (count == 3)
            {
                (Instantiate(tumbleweed, Obj_Position.transform.position, Quaternion.identity)).transform.SetParent(terrain.transform); ;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Finish")
        {
            animator.SetBool("IsWon", true);
            charCon.enabled = false;
            print("you win");
            win.SetActive(true);
            terrain.SetActive(false);
        }

        if (col.gameObject.tag == "Start")
        {
            print("Obstacles are coming");
            dt.enabled = true;
            terrain.SetActive(true);
            
        }

        if (col.gameObject.tag == "Respawn")
        {
            charCon.enabled = false;
            print("you lose");
            gameOver.SetActive(true);
            animator.SetBool("IsLost", true);
        }


        
        }
        
    }

