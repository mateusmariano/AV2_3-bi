using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;
using UnityEditor;

[CustomPropertyDrawer(typeof(TagSelec))]
public class Tagcontrol : PropertyDrawer {
	public int indice;
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label){
		if(indice >= 0 ){
			property.stringValue = InternalEditorUtility.tags [indice];
		}
		indice = System.Array.IndexOf (InternalEditorUtility.tags, property.stringValue);
		indice = EditorGUI.Popup(position,label.text,indice,InternalEditorUtility.tags);
	}
}
