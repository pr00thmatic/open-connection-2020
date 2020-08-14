using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Billboard : MonoBehaviour {
  public Camera cam;

  void Update () {
    transform.forward = cam.transform.forward;
  }
}
