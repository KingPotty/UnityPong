using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Vector3 moveVector;
    private double speed;
    private double minY;
    private double maxY;

    public KeyCode upKey;
    public KeyCode downKey;

    // Start is called before the first frame update
    void Start()
    {
        // variables
        speed = 2.5f;
        minY = -3.73f;
        maxY = 3.76;

        resetPosition();
    }

    // Update is called once per frame
    void Update() {
        double yMove = 0.0f;

        if (Input.GetKey(upKey)) {
            yMove += speed;
        }

        if (Input.GetKey(downKey)) {
            yMove -= speed;
        }

        if ((transform.position.y + yMove * Time.deltaTime) < minY) {
            transform.position = new Vector3(transform.position.x,
                                            (float) minY,
                                            transform.position.z);

        } else if ((transform.position.y + yMove * Time.deltaTime) > maxY) {
            transform.position = new Vector3(transform.position.x,
                                            (float) maxY,
                                            transform.position.z);

        } else {
            moveVector = new Vector3(0, (float)(yMove * Time.deltaTime));
            transform.position += moveVector;
        }
    }

    public void resetPosition() {
        transform.position = new Vector3(transform.position.x,
                                                    0.0f,
                                                    transform.position.z);
    }
}
