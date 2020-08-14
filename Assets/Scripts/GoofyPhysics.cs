using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoofyPhysics : MonoBehaviour {
  public Rigidbody body;

  void Reset () {
    body = GetComponent<Rigidbody>();
  }

  IEnumerator Start () {
    yield return new WaitForSeconds(0.25f);
    body.AddForce(5 * Random.insideUnitSphere.normalized, ForceMode.VelocityChange);
    body.AddTorque(5 * Random.insideUnitSphere.normalized, ForceMode.VelocityChange);
  }
}
