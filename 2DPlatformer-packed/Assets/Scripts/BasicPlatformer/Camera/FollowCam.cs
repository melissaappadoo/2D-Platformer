using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    float nextTimeToSearch = 0;

	// Update is called once per frame
	void LateUpdate ()
    {
        if (target == null)
        {
            FindPlayer();
            return;
        }

        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
	}

    void FindPlayer ()
    {
        if (nextTimeToSearch <= Time.time)
        {
            GameObject searchResult = GameObject.FindGameObjectWithTag("Player");
            if (searchResult != null)
                target = searchResult.transform;
            nextTimeToSearch = Time.time + 0.5f;
        }
    }
}
