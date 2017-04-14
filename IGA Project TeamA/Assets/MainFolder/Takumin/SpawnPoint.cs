using UnityEngine;
using System.Collections;

namespace Itsuki
{
    public class SpawnPoint : MonoBehaviour
    {
        public GameObject debri;
        public float interval = 5F;
        private bool spawnStarted = false;
        public float spawn = 5;

        static public bool spawnFlag = false;

        void StartSpawn()
        {
            if (!spawnStarted)
            {
                spawnStarted = false;
                StopCoroutine("SpawnDebris");
            }
        }

        // Use this for initialization
        void Start()
        {
            StartCoroutine("SpawnDebris");
        }

        void Update()
        {
        }

        // Update is called once per frame
        IEnumerator SpawnDebris()
        {
            //while (true)
            //{
            //    Vector3 spawn = transform.position;
            //    spawn.x = Random.Range(-10.0f, 10.0f);
            //    spawn.y = Random.Range(-10.0f, 10.0f);
            //    spawn.z = Random.Range(-10.0f, 10.0f);

            //    Instantiate(debri, spawn, Quaternion.identity);

            //    yield return new WaitForSeconds(interval);
            //}

            if (spawnFlag)
            {
                Instantiate(debri, transform.position, Quaternion.identity);

                spawnFlag = false;

                yield return new WaitForSeconds(interval);
            }
        }
    }
}