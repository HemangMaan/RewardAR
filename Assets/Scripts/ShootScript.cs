using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    private GameObject scoreManager;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");
    }

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit))
        {
            Destroy(hit.transform.gameObject);
            Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            scoreManager.GetComponent<ScoreManger>().incrementScore(10);
        }
    }

    void Update()
    {
        
    }
}
