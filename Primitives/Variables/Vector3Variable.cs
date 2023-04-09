using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOArchitecture.Variables
{
    [CreateAssetMenu(menuName = "SOVariables/Vector3Variable")]
    public class Vector3Variable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public Vector3 Value;

        public void SetValue(Vector3 value) => Value = value;
        public void SetValue(Vector3Reference value) => Value = value.Value;

        public void ApplyChanges(Vector3 amount) => Value += amount;

        public void ApplyChanges(Vector3Reference amount) => Value += amount.Value;
    }
}
