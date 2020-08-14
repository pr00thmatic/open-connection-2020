using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActivablePuzzle : MonoBehaviour {
  public Transform activables;

  public bool IsSolved () {
    foreach (Transform child in activables) {
      ActivablePuzzleItem activable = child.GetComponent<ActivablePuzzleItem>();
      if (!activable.IsActive) return false;
    }

    return true;
  }
}
