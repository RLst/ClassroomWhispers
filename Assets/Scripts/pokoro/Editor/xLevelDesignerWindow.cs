// //Don't think I can use EditorWindow for what I want to use it for

// using UnityEngine;
// using UnityEditor;

// namespace pokoro
// {
//     public class LevelDesignerWindow : EditorWindow
//     {
//         SerializedObject obj;
//         SerializedProperty rows;
//         SerializedProperty columns;
//         SerializedProperty xPos;
//         SerializedProperty yPos;
//         SerializedProperty xPad;
//         SerializedProperty yPad;


//         static LevelDesignerWindow window;

//         // Get existing open window or if none, make a new one:
//         [MenuItem("Window/Level Designer")]
//         static void Invoke()
//         {
//             window = EditorWindow.GetWindow(typeof(LevelDesignerWindow)) as LevelDesignerWindow;
//             window.Show();
//         }

//         //Called as the new window is opened
//         void Awake()
//         {
//             // obj = new SerializedObject(testLevelDesignerScriptableObject);
//             rows = obj.FindProperty("rows");
//             columns = obj.FindProperty("columns");
//             xPos = obj.FindProperty("posNpad.position.x");
//             yPos = obj.FindProperty("posNpad.position.y");
//             xPad = obj.FindProperty("posNpad.width");
//             yPad = obj.FindProperty("posNpad.height");
//         }

//         //Implement your own editor GUI here
//         void OnGUI()
//         {
//             obj.Update();   //Required for undo and other extra features

//             GUILayout.TextField("Rows & Columns", EditorStyles.boldLabel);
//             //Rows and columns
//             EditorGUILayout.DelayedIntField(rows);
//             EditorGUILayout.DelayedIntField(columns);
//             EditorGUILayout.DelayedFloatField(xPos);
//             EditorGUILayout.DelayedFloatField(yPos);
//             EditorGUILayout.DelayedFloatField(xPad);
//             EditorGUILayout.DelayedFloatField(yPad);
//             //Horizontal/Vertical paddings



//             obj.ApplyModifiedProperties();  //Required for undo and other extra features
//         }

//         //called when the window gets keyboard focus
//         void OnFocus()
//         {
//         }
//         //called to close this window
//         void OnDestroy()
//         {
//         }

//     }

// }