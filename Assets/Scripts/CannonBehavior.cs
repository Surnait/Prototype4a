using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{ public GameObject projectile;
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Cannonball");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Shoot(5);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(SteadyShot(6, 0.5f));
        }
    }

    public void Shoot(int numberOfBalls)
    {
        for (int i = 0; i < numberOfBalls; i++)
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }

    IEnumerator SteadyShot(int numberOfBalls, float delay)
    {
        for (int i = 0; i < numberOfBalls; i++)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
}
