using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D rb;

    void Update() {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        var vec3 = new Vector3(horz, vert, 0.0F);
        rb.velocity =  vec3 * 10.0F;
    }
}
