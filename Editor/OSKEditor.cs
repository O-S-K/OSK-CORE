using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace OSK
{
    public class OSKEditor : MonoBehaviour
    {
        [MenuItem("OSK-Framework/Create/ Framework", false,5)]
        public static void CreateWorldOnScene()
        {
            if (FindObjectOfType<Main>() == null)
            {
                PrefabUtility.InstantiatePrefab(Resources.LoadAll<Main>("").First());
            }
        }

        [MenuItem("OSK-Framework/SO Files/List Sound")]
        public static void LoadListSound()
        {
            FindSoundSOAssets();
        }

        private static void FindSoundSOAssets()
        {
            string[] guids = AssetDatabase.FindAssets("t:ListSoundSO");
            if (guids.Length == 0)
            {
                Logg.LogError("No SoundSO found in the project.");
                return;
            }

            var soundData = new List<ListSoundSO>();
            foreach (var guid in guids)
            {
                string path = AssetDatabase.GUIDToAssetPath(guid);
                ListSoundSO v = AssetDatabase.LoadAssetAtPath<ListSoundSO>(path);
                soundData.Add(v);
            }

            if (soundData.Count == 0)
            {
                Logg.LogError("No SoundSO found in the project.");
            }
            else
            {
                foreach (var v in soundData)
                {
                    Logg.Log("SoundSO found: " + v.name);
                    Selection.activeObject = v;
                    EditorGUIUtility.PingObject(v);
                }
            }
        } 
    }
}
