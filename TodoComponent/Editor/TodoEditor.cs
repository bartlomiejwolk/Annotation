// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the Annotation extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEditor;

namespace AnnotationEx.TodoComponent {

    [CustomEditor(typeof(Todo))]
    [CanEditMultipleObjects]
    public sealed class TodoEditor : Editor {
        #region FIELDS

        private Todo Script { get; set; }

        #endregion FIELDS

        #region SERIALIZED PROPERTIES

        private SerializedProperty description;

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
            Script = (Todo)target;

            description = serializedObject.FindProperty("description");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS

        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    Todo.Version,
                    Todo.Extension));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }

        #endregion INSPECTOR

        #region METHODS

        [MenuItem("Component/Annotation/Todo")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(Todo));
            }
        }

        #endregion METHODS
    }

}