using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    private static bool startedMoving;
    // method with 3 attributes, the player, the end position, and the player hight
    //this method is a static method that moves the player to a position with standard hight
    public static void moveTo(GameObject player , GameObject movePoint, float playerHeight)
    {
        startedMoving = true;
        if (startedMoving)
        {
            float step = 5 * Time.deltaTime;
            Vector3 endPoint = new Vector3();
            endPoint.y = playerHeight;
            player.transform.position = Vector3.MoveTowards(player.transform.position, movePoint.transform.position + endPoint, step);
            if (player.transform.position == movePoint.transform.position) {
                startedMoving = false;
            }
        }

    }
}
