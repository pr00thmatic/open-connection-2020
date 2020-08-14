using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Lava : MonoBehaviour {
  public GameObject perdiste;

  void OnTriggerEnter (Collider c) {
    if (c.GetComponent<Player>()) {
      perdiste.transform.parent = null;
      perdiste.transform.forward = -Camera.main.transform.forward;
      Destroy(c.gameObject);
      StartCoroutine(_Restart());
    }
  }

  IEnumerator _Restart () {
    perdiste.SetActive(true);
    yield return new WaitForSeconds(5);
    SceneManager.LoadScene(gameObject.scene.name);
  }
}
