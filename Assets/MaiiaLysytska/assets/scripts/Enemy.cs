using UnityEngine;
namespace MaiMothman
{
    public class Enemy : MonoBehaviour
    {

        public Transform player;
        [SerializeField] private float speed = 2f;
        private Rigidbody2D _rb;
        private Vector2 direction;
        // Start is called before the first frame update
        void Start()
        {
            _rb = transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
           Vector2 direction = Vector2.MoveTowards(transform.position, player.position, speed);
            direction -= (Vector2)transform.position;
            _rb.velocity = direction;
        }
    }
}

