using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(KillableChildVisibility))]
// ReSharper disable once CheckNamespace
public class KillableChildVisibilityInspector : Editor {
	public override void OnInspectorGUI() {
        EditorGUIUtility.LookLikeControls();
		EditorGUI.indentLevel = 0;
		
		var kill = (KillableChildVisibility) target;
		
		var isDirty = false;
		
		WorldVariableTracker.ClearInGamePlayerStats();
		
		LevelSettings.Instance = null; // clear cached version
        DTInspectorUtility.DrawTexture(CoreGameKitInspectorResources.LogoTexture);
		
		var newKillableToAlert = (Killable) EditorGUILayout.ObjectField("Killable To Alert", kill.killableWithRenderer, typeof(Killable), true);
		if (newKillableToAlert != kill.killableWithRenderer) {
			UndoHelper.RecordObjectPropertyForUndo(ref isDirty, kill, "change Killable To Alert");
			kill.killableWithRenderer = newKillableToAlert;
		}
		
		if (GUI.changed || isDirty) {
  			EditorUtility.SetDirty(target);	// or it won't save the data!!
		}
		
		//DrawDefaultInspector();
    }
}