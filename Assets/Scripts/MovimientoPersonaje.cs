using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private float h, v;
    Rigidbody rb;
    [SerializeField] float fuerzaMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * fuerzaMovimiento, ForceMode.Force);
    }
}
