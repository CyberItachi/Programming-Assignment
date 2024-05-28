using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObstacleData))]
public class ObstacleEditor : Editor
{
    private bool[] toggles = new bool[100];

    public override void OnInspectorGUI()
    {
        ObstacleData obstacleData = (ObstacleData)target;

        EditorGUILayout.LabelField("Obstacle Grid", EditorStyles.boldLabel);

        for (int x = 0; x < 10; x++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int y = 0; y < 10; y++)
            {
                int index = x * 10 + y;
                toggles[index] = GUILayout.Toggle(obstacleData.obstacles[index], "");
                obstacleData.obstacles[index] = toggles[index];
            }
            EditorGUILayout.EndHorizontal();
        }

        if (GUI.changed)
        {
            EditorUtility.SetDirty(obstacleData);
        }
    }
}
