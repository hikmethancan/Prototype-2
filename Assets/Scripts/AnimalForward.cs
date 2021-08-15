using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalForward : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.Translate( 0 ,0, speed * Time.deltaTime);
        Boundaries();
    }

    void Boundaries()
    {
        if (transform.position.z < -5f)
        {
            Destroy(gameObject);
        }
    }

}
