using UnityEditor;
using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        ISWeaponDatabase database;

        const string DATABASE_NAME = @"bzaWeaponDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_PULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

        [MenuItem("BZA/Database/Item System Editor %#i")]
    public static void Init()
    {
        ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
        window.minSize = new Vector2(800, 600);
        window.titleContent.text = "Item System Database";
        window.Show();
    }

    void OnEnable()
    {
            if ( database == null )
                database = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>( DATABASE_PATH, DATABASE_NAME );
    }

    void OnGUI()
    {
            TopTabBar();

            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();

            BottomStatusBar();
    }
}
}
