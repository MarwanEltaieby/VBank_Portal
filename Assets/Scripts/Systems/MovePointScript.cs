using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointScript : MonoBehaviour
{
    private bool timerActive = false;
    private float timeRequired = 1f;
    private bool startedMoving = false;
    [SerializeField] private GameObject player;
    [SerializeField] private float playerHeight = 3.5f;
    
    public void toBlack() {
        if (!startedMoving) {
            this.GetComponent<Renderer>().material.color = Color.black;
            timerActive = true;
        }
    }

    public void toWhite() {
        if (!startedMoving) {
            this.GetComponent<Renderer>().material.color = Color.white;
            timerActive = false;
            timeRequired = 1f;
        }
    }

    private void Update() {
        if (timerActive == true) {
            timeRequired = timeRequired - Time.deltaTime;
            if (timeRequired <= 0) {
                startedMoving = true;
                if (startedMoving) {
                    float step = 5 * Time.deltaTime;
                    Vector3 endPoint = new Vector3();
                    endPoint.y = playerHeight;
                    player.transform.position = Vector3.MoveTowards(player.transform.position, this.transform.position + endPoint, step);
                    if (player.transform.position == this.transform.position + endPoint) {
                        startedMoving = false;
                    }
                }
                //player.transform.position = this.transform.position;
                //player.transform.Translate(0, 1.5f, 0);
                if(!startedMoving) {
                    toWhite();
                }
            }
        }
    }
}
