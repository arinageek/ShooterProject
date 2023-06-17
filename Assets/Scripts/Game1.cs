using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour {
    public GameObject bird1;
    public GameObject bird2;
    public GameObject bird3;
    public GameObject bullet;
    public GameObject BulletEmitter;
    GameObject newBird;
    private float t = 0.0f;
    public float interpolationPeriod = 1f;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        t += Time.deltaTime;
        if (t >= interpolationPeriod)
        {
            t = 0.0f;
            int r = Random.Range(0, 3);

            Vector3 spawnPoint = new Vector3();
            spawnPoint.x = Random.Range(10.0f, 30.0f) * (Random.Range(0.0f, 1.0f) > 0.5 ? 2.0f : -2.0f);
            spawnPoint.y = Random.Range(0.1f, 0.2f);
            spawnPoint.z = Random.Range(10.0f, 30.0f) * (Random.Range(0.0f, 1.0f) > 0.5 ? 2.0f : -2.0f);
            if (r == 0)
            {
                newBird = Instantiate(bird1, spawnPoint, Quaternion.Euler(0f, 90f, 0f));
            } else if (r == 1)
            {
                newBird = Instantiate(bird2, spawnPoint, Quaternion.Euler(0f, 90f, 0f));
            } else
            {
                newBird = Instantiate(bird3, spawnPoint, Quaternion.Euler(0f, 90f, 0f));
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject bulletObj = Instantiate(bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation);
            bulletObj.GetComponent<Rigidbody>().AddForce(bulletObj.transform.forward * 4000.0f);
        }
        
    }
}
