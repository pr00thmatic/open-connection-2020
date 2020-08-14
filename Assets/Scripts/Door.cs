using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Door : MonoBehaviour {
  public HingeJoint joint;
  public bool IsOpen { get => joint.spring.targetPosition > 0; }

  void Reset () {
    joint = GetComponent<HingeJoint>();
  }

  public void Open (bool value) {
    JointSpring spring = joint.spring;
    spring.targetPosition = value? 100: 0;
    joint.spring = spring;
  }
}
