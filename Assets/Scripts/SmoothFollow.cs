using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmoothFollow : MonoBehaviour {
  // public float rotationVelocity = Mathf.Deg2Rad * 360;
  public Vector3 velocity;
  public float time = 0.5f;
  public Transform target;
  // public float timeWithoutMoving = 0;

  void Update () {
    // if ((transform.position - target.position).magnitude == 0) {
    //   timeWithoutMoving += Time.deltaTime;
    // } else {
    //   timeWithoutMoving = 0;
    // }

    if (!target) return;
    transform.position =
      Vector3.SmoothDamp(transform.position, target.position,
                         ref velocity, time);

    // if (timeWithoutMoving > 0.5f) {
    //   transform.forward =
    //     Vector3.RotateTowards(transform.forward, target.forward,
    //                           rotationVelocity * Time.deltaTime, 1);
    // }
  }
}
