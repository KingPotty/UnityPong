using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Vector3 direction;
    private float speed;
    private float angleRange = 1;

    // Start is called before the first frame update
    void Start() {
        ResetBall("left");
    }

    // Update is called once per frame
    void Update() {
        transform.position += direction * speed * Time.deltaTime;
    }

    public void ResetBall(string side) {
        transform.position = Vector3.zero;
        speed = 4;

        if (side == "left") {
            direction = new Vector3(-1, Random.Range(-angleRange, angleRange)).normalized;
        } else {
            direction = new Vector3(1, Random.Range(-angleRange, angleRange)).normalized;
        }
    }

    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.name == "PlayerLeft" || other.gameObject.name == "PlayerRight") {
            direction = Vector3.Reflect(direction, Vector3.right);
            speed += 0.5f;

            direction = new Vector3(direction.x/Mathf.Abs(direction.x),
                                    (transform.position.y - other.gameObject.transform.position.y)/2,
                                    direction.z);

        } else if (other.gameObject.name == "WallTop" || other.gameObject.name == "WallBottom") {
            direction = Vector3.Reflect(direction, Vector3.up);

        } else if (other.gameObject.name == "GoalLeft") {
            other.gameObject.SendMessage("IncrementScore");
            ResetBall("left");

        } else if (other.gameObject.name == "GoalRight") {
            other.gameObject.SendMessage("IncrementScore");
            ResetBall("right");
        }
    }
}
