// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the Annotation extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEngine;

namespace AnnotationEx.TodoComponent {

    public sealed class Todo : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.2.0";
        public const string Extension = "Annotation";

        #endregion

        #region DELEGATES
        #endregion

        #region EVENTS
        #endregion

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "Todo";
#pragma warning restore0414

        #endregion

        #region INSPECTOR FIELDS

        /// <summary>
        /// Description of the task.
        /// </summary>
        [SerializeField]
        private string description = "Description";

        #endregion

        #region PROPERTIES

        /// <summary>
        ///     Optional text to describe purpose of this instance of the component.
        /// </summary>
        public string Description {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region UNITY MESSAGES

        private void Awake() { }

        private void FixedUpdate() { }

        private void LateUpdate() { }

        private void OnEnable() { }

        private void Reset() { }

        private void Start() { }

        private void Update() { }

        private void OnValidate() { }

        private void OnCollisionEnter(Collision collision) { }

        private void OnCollisionStay(Collision collision) { }

        private void OnCollisionExit(Collision collision) { }

        #endregion

        #region EVENT INVOCATORS
        #endregion

        #region EVENT HANDLERS
        #endregion

        #region METHODS
        #endregion

    }

}
