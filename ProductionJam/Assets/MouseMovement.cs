using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    Vector3 worldPosition;
    private bool _isMoving;
    private transform movePosition;
    // Start is called before the first frame update
    void Start()
    {
        movePosition=(Random.Range(0f, 100f), Random.Range(0f, 100f),0f)
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        if (_isMoving)
        {
            ResetAndMove();
        }
    }

    void ResetAndMove()
    {
        if(transform.position==movePosition)
        {
            movePosition = (Random.Range(0f, 100f), Random.Range(0f, 100f), 0f)
        }
        else
        {

        }
    }

    void OnMouseOver()
    {
        Debug.Log("Hi")
    }

    void OnMouseExit()
    {
        Debug.Log("Yo")
    }

    void OnMouseDrag()
    {
        transform.position = worldPosition;
    }
}
