using UnityEditor;
using UnityEngine;

// ReSharper disable once CheckNamespace
public static class CoreGameKitInspectorResources {
	public const string CoreGameKitFolderPath = "Core GameKit";

	public static Texture LogoTexture = EditorGUIUtility.LoadRequired(string.Format("{0}/inspector_header_killer_waves.png", CoreGameKitFolderPath)) as Texture;
    public static Texture SettingsTexture = EditorGUIUtility.LoadRequired(string.Format("{0}/gearIcon.png", CoreGameKitFolderPath)) as Texture;
	public static Texture LeftArrowTexture = EditorGUIUtility.LoadRequired(string.Format("{0}/arrow_left.png", CoreGameKitFolderPath)) as Texture;
	public static Texture RightArrowTexture = EditorGUIUtility.LoadRequired(string.Format("{0}/arrow_right.png", CoreGameKitFolderPath)) as Texture;
	public static Texture UpArrowTexture = EditorGUIUtility.LoadRequired(string.Format("{0}/arrow_up.png", CoreGameKitFolderPath)) as Texture;
	public static Texture DownArrowTexture = EditorGUIUtility.LoadRequired(string.Format("{0}/arrow_down.png", CoreGameKitFolderPath)) as Texture;
}
