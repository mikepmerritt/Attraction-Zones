using UnityEngine;

public class Attractable : MonoBehaviour
{
    public FloatVariable maxSpeed; // max object speed
    Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();  // get attached rigidbody
    }

    void OnTriggerStay2D(Collider2D other) {
        PullZone currentPullZone = other.gameObject.GetComponent<PullZone>();
        if(currentPullZone != null) {
            // determine which direction to pull the attractable object in
            Vector2 currPos = new Vector2(transform.position.x, transform.position.y);
            Vector2 pullPos = new Vector2(other.transform.position.x, other.transform.position.y);
            Vector2 pullDir = pullPos - currPos; // calculates vector pointing toward attractor center
            pullDir.Normalize(); // only want direction so set magnitude of vector to 1
            // determine new velocity to move the pullable object toward attractor
            Vector2 newVel = rb.velocity + pullDir * currentPullZone.attractionSpeed.value;
            // cap object velocity if too high
            if(newVel.magnitude > maxSpeed.value) {
                newVel.Normalize();
                newVel *= maxSpeed.value;
            }
            rb.velocity = newVel;
        }
    }
}