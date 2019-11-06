using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    //public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets
    struct Bullet
    {
        public int bulletID;
        public int bulletCount;

        private static int _bulletPoolMaxSize = 5;
        private static Queue bulletPool = new Queue(_bulletPoolMaxSize);

    }
    Bullet bul = new Bullet();

    public int bulletCount = 5;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public void GetBullet()
    {
        if (bulletCount >= 5)
        {
        // dequeue the bulletPoll by 1
        }
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        // if bullet reaches boundary, add bullet back to queue and reset the position of the bullet
    }
}
