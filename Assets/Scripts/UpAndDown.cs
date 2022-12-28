using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    Vector2 initialPos;
    [SerializeField] float targetPosY;
    [SerializeField] float timer;
    [SerializeField] float movementSpeed;
    [SerializeField] float height;
    Rigidbody2D rb;
    bool down = false;
    float _timer;
    float SIenfen = 0;
    void Start()
    {
        initialPos = transform.position;
        _timer = timer;
        rb = GetComponent<Rigidbody2D>();
        height = Random.Range(0.8f, 1.1f);
    }
    void Update()
    {
        //if (!down)
        //    transform.position += new Vector3(0, ((initialPos.y + targetPosY) - transform.position.y) * Time.deltaTime * movementSpeed, 0);
        //if (down)
        //    transform.position += new Vector3(0, ((initialPos.y - targetPosY) - transform.position.y) * Time.deltaTime * movementSpeed, 0);
        //_timer -= Time.deltaTime;
        //if (_timer <= 0)
        //{
        //    down = !down;
        //    _timer = timer;
        //}
        SIenfen++;
        rb.velocity = new Vector2(0, Mathf.Sin(SIenfen / movementSpeed) * height);

    }
    }
