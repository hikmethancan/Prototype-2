using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float speed;

    [SerializeField] GameObject projectTilePrefab;


    private void Update()
    {
        Boundaries();
        Move();
        ThrowPizza();
    }

    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
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
    }
}
