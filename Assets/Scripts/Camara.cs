using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speed;
    Vector3 _dir;
    private Transform _myTransform;

    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _dir = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //_myTransform.Translate = Time.deltaTime * speed * _dir;
    }
}
