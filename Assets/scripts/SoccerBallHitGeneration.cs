using UnityEngine;

public class SoccerBallHitGeneration : MonoBehaviour
{
    bool shootFlag = false;

    void Start()
    {
    }

    void Update()
    {
        shootFlag = Input.GetKey(KeyCode.X);
    }

    void OnCollisionEnter(Collision collision)
    {
        string objectName = collision.gameObject.name;

        if (objectName == "Ball")
        {
            Vector3 impulse = collision.contacts[0].impulse;
            collision.gameObject.TryGetComponent(out Rigidbody ballRb);
            ballRb.AddForce(new Vector3(0, -2 * impulse.y, 0));
        }
    }
}
