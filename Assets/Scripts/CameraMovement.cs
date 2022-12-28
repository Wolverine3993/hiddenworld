using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject cameraObject;
    Move move;
    RoomBoundary boundary;
    private void Start()
    {
        move = cameraObject.GetComponent<Move>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "VerticalDoor")
        {
            if (move.moving == false)
            {
                boundary = collision.GetComponent<RoomBoundary>();
                if (boundary.pos)
                    move.SetTarget(0, 10, 0, 1);
                else if (!boundary.pos)
                    move.SetTarget(0, -10, 0, -1);
                boundary.pos = !boundary.pos;
            }
        }
        if(collision.gameObject.tag == "HorizontalDoor")
        {
            if (move.moving == false)
            {
                boundary = collision.GetComponent<RoomBoundary>();
                if (boundary.pos)
                    move.SetTarget(17.8f, 0, 1, 0);
                else if (!boundary.pos)
                    move.SetTarget(-17.8f, 0, -1, 0);
                boundary.pos = !boundary.pos;
            }
        }
    }
}
