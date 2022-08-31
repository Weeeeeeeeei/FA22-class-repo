using UnityEngine;

namespace AishaVampireSurvivors
{
    public class Enemy : MonoBehaviour
    {

        private Rigidbody2D rb;
        public Transform player;
        [SerializeField] private float speed = 5f;
        // Start is called before the first frame update
        void Start()
        {
            rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 direction= Vector2.MoveTowards(transform.position, player.position, speed);
            direction -= (Vector2)transform.position;
            rb.velocity = direction;
        }
    }
}