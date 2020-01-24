using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health = 10f;
    [SerializeField] private float _damage = 5f;
    [SerializeField] private float _sideWaysForce = 10f;
    [SerializeField] private float _forwardBackForce = 10f;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            _rb.AddForce(0, 0, _forwardBackForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            _rb.AddForce(0, 0, -_forwardBackForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            _rb.AddForce(0, 0, -_sideWaysForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            _rb.AddForce(0, 0, _sideWaysForce * Time.deltaTime);
        }
    }
}
