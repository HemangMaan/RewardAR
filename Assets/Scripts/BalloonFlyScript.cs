using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFlyScript : MonoBehaviour
{
    public float FlySpeed = 0.2f;
    private void Start()
    {
        Destroy(this.gameObject, 10);
    }
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * FlySpeed);
        FlySpeed *=1.0000003f;
    }
}
