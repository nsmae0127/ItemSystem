using System.Collections;
using UnityEditor;
using UnityEngine;

namespace BurgZergArcade.ItemSystem.Editor
{
	public partial class ISQualityDatabaseEditor : EditorWindow
	{
		ISQualityDatabase qualityDatabase;
		Texture2D selectedTexture;
		int selectedIndex = -1;
		Vector2 _scrollPos;
		// scroll position for the ListView

		const int SPRITE_BUTTON_SIZE = 46;

		const string DATABASE_NAME = @"bzaQualityDatabase.asset";
		const string DATABASE_PATH = @"Database";
		//		const string DATABASE_PULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

		[MenuItem ("BZA/Database/Quality Editor %#w")]
		public static void Init ()
		{
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor> ();
			window.minSize = new Vector2 (400, 300);
			window.titleContent.text = "Quality Database";
			window.Show ();
		}

		void OnEnable ()
		{
			if (qualityDatabase == null)
				qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase> (DATABASE_PATH, DATABASE_NAME);
		}

		void OnGUI ()
		{
			if (qualityDatabase == null) {
				Debug.LogWarning ("qualityDatabase not loaded");
				return;
			}
			ListView ();

			GUILayout.BeginHorizontal ("Box", GUILayout.ExpandWidth (true));
			BottomBar ();
			GUILayout.EndHorizontal ();
		}

		void BottomBar ()
		{
			// count
			GUILayout.Label ("Qualities: " + qualityDatabase.Count);

			// add button
			if (GUILayout.Button ("Add")) {
				qualityDatabase.Add (new ISQuality ());
			}
		}
	}
}
