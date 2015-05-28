// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the Annotation extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEditor;

namespace AnnotationEx.DescriptionComponent {

    [CustomEditor(typeof(Description))]
    [CanEditMultipleObjects]
    public sealed class DescriptionEditor : Editor {
        #region FIELDS

        private Description Script { get; set; }

        #endregion FIELDS

        #region SERIALIZED PROPERTIES

        private SerializedProperty text;

        #endregion SERIALIZED PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            serializedObject.ApplyModifiedProperties();
        }

        private void OnEnable() {
            Script = (Description)target;

            text = serializedObject.FindProperty("text");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    Description.Version,
                    Description.Extension));
        }

        private void DrawDescriptionTextArea() {
            text.stringValue = EditorGUILayout.TextArea(
                text.stringValue);
        }

        #endregion INSPECTOR

        #region METHODS

        [MenuItem("Component/Annotation/Description")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(Description));
            }
        }

        #endregion METHODS
    }

}