using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
  public Transform camera { get => Camera.main.transform; }
  public Animator animator;
  public float speed = 8;
  public bool hacerQueLaCamaraSigaAlJugador = true;
  public Rigidbody body;
  public bool moverConFisica = true;

  void Reset () {
    body = GetComponent<Rigidbody>();
  }

  void Start () {
    if (hacerQueLaCamaraSigaAlJugador) {
      GameObject anchor = new GameObject();
      anchor.AddComponent<SmoothFollow>().target = transform;
      anchor.transform.position = transform.position;
      camera.transform.parent = anchor.transform;
    }
  }

  void FixedUpdate () {

    Vector3 delta =
      (Vector3.Scale(new Vector3(1,0,1), camera.forward) *
       Input.GetAxis("Vertical") +
       Vector3.Scale(new Vector3(1,0,1), camera.right) *
       Input.GetAxis("Horizontal")) * speed * Time.deltaTime;
    animator.SetFloat("speed", (delta.magnitude / Time.deltaTime) / 4f);
    if (moverConFisica) {
      body.MovePosition(transform.position + delta);
    } else {
      transform.position += delta;
    }

    if (delta.magnitude > 0) {
      transform.forward = delta.normalized;
    }

  }
}
