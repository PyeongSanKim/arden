using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSwipe : MonoBehaviour
{
    public float sense = 30f;
    public float speed = 20f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch.deltaPosition.x);
            if (touch.deltaPosition.x > sense && transform.position.x < 7f)
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            else if (touch.deltaPosition.x < -sense && transform.position.x > -7f)
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
