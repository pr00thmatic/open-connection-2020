using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivablePuzzleItem : MonoBehaviour {
  public bool IsActive { get => active.activeSelf; }

  public ActivablePuzzleItem[] twins;
  public GameObject active;
  public GameObject inactive;

  void OnTriggerEnter (Collider c) {
    if (c.GetComponent<Player>()) {
      foreach (ActivablePuzzleItem twin in twins) {
        twin.Toggle();
      }
      Toggle();
    }
  }

  public void Toggle () {
    active.SetActive(!active.activeSelf);
    inactive.SetActive(!active.activeSelf);
  }
}
