using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laura
{
    public class EnemyController : MonoBehaviour
    {
        private Transform target;
        [SerializeField]
        private float speed;
        [SerializeField]
        private float maxRange;
        [SerializeField]
        private float minRange;

        void Start()
        {
            target = FindObjectOfType<TempPlayerController>().transform;
        }

        
        void Update()
        {
            if (Vector3.Distance(target.position, transform.position) <= maxRange && Vector3.Distance(target.position, transform.position) >= minRange)
            {
                FollowPlayer();
            }

        }

        public void FollowPlayer()
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
}

