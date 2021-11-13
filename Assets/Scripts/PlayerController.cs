using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    public float _speed=5;
    public float _turnSpeed=360;

    private Vector3 _input;


    private void Update()
    {
        GetPlayerInput();
        Look();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void GetPlayerInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"),
                            0,
                            Input.GetAxisRaw("Vertical"));
    }

    void Look()
    {
        if (_input != Vector3.zero)
        {
            var relative = (transform.position + _input) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation,rot,_turnSpeed*Time.deltaTime);
        }
    }


    void Move()
    {
        _rb.MovePosition(transform.position + (transform.forward * _input.magnitude) * _speed * Time.deltaTime);
    }
}
