using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
[CustomEditor (typeof (UnityEngine.Object), true)]
public class ObjectEditor : Editor {
  public override void OnInspectorGUI () {
    if (EditorApplication.isPlaying == false) {
      var _methods = target.GetType ().GetMethods (BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
      foreach (var _method in _methods) {
        var _inspectorButton = (InspectorButton) Attribute.GetCustomAttribute (_method, typeof (InspectorButton));
        if (_inspectorButton != null)
          if (GUILayout.Button (ObjectNames.NicifyVariableName (_method.Name)))
            _method.Invoke (target, null);
      }
    }
    this.DrawDefaultInspector ();
  }
}