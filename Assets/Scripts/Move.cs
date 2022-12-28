using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float time;
    [SerializeField] float xMove;
    [SerializeField] float yMove;
    float x, y;
    [SerializeField] public bool moving;
    public float currentSpeedX;
    public float currentSpeedY;
    Vector2 target;
    GameObject player;
    float timer = 0;
    private void Start()
    {
        target = transform.position;
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        if (moving)
        {
            Vector3 goTo = new Vector3(Mathf.SmoothDamp(transform.position.x, target.x, ref currentSpeedX, time), Mathf.SmoothDamp(transform.position.y, target.y, ref currentSpeedY, time), transform.position.z);
            transform.position = goTo;
            if (transform.position - goTo == Vector3.zero && timer <= 0)
            {
                moving = false;
                transform.position = new Vector3((Mathf.Round(transform.position.x * 10) / 10), (Mathf.Round(transform.position.y * 10) / 10), transform.position.z);
            }
            timer -= Time.deltaTime;
        }
    }

    public void SetTarget(float xQuan, float yQuan, float _x, float _y)
    {
        target = new Vector2(transform.position.x + xQuan, transform.position.y + yQuan);
        moving = true;
        x = _x;
        y = _y;
        player.transform.position += new Vector3(xMove * x, yMove * y);
        timer = 0.25f;
    }
}
