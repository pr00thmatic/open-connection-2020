using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[CustomEditor(typeof(Door))]
public class DoorEditor : Editor {
  Door Target { get => (Door) target; }

  public override void OnInspectorGUI () {
    DrawDefaultInspector();
    if (GUILayout.Button("Toggle open")) {
      Target.Open(!Target.IsOpen);
    }
  }
}
