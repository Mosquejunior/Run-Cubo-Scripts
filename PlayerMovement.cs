using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Aixo es una referencia al Rigidbody que li hem posat de nom rb
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    // Hem markat aixo com a FixedUpdate perque en la seguent linea de codi estem modifican fisicas.
    void FixedUpdate ()
    {
        // Afegiex una força constant
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   // Nomes executara si la condicio es complerta
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

              
    }
}