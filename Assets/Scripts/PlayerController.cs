using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;
    [SerializeField] float speed;

    [SerializeField] GameObject projectTilePrefab;

    [SerializeField] GameObject gameManager;


    private void Update()
    {
        Boundaries();
        Move();
        ThrowPizza();
    }

    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(horizontalInput * Time.deltaTime * speed,0,verticalInput *Time.deltaTime *speed);
    }

    void ThrowPizza()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectTilePrefab,transform.position,projectTilePrefab.transform.rotation);
        }
    }

    void Boundaries()
    {
        // Player control boundaries
        if (transform.position.x <= -15f)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 15f)
        {
            transform.position = new Vector3(15f, transform.position.y, transform.position.z);
        }
        else if (transform.position.z < -1.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1.5f);
        }
        else if (transform.position.z > 16f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15f);  
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Animal")
        {
            gameManager.GetComponent<GameManager>().GameOverPanel();
        }

    }





}
