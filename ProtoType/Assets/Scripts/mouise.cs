using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouise : MonoBehaviour
{
    Vector2 mouse;
    // Start is called before the first frame update
    void Start()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    // Update is called once per frame
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = mouse;
    }
}
