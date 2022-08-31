using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AishaVampireSurvivors
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D rb;
        [SerializeField] private float speed = 20f;

        // Start is called before the first frame update
        void Start()
        {
            rb =transform.GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}
