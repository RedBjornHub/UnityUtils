﻿using System.Linq;
using UnityEditor;
using UnityEngine;

namespace RedBjorn.Utils
{
    public static class AssetDatabaseExtensions
    {
        public static T[] FindAssets<T>(string filter = null) where T : Object
        {
            var typeFilter = string.IsNullOrEmpty(filter) ? $"t: {typeof(Tag).Name}" : $"t: {typeof(Tag).Name} {filter}";
            var guids = AssetDatabase.FindAssets(typeFilter);
            var assets = new T[guids.Length];
            for (int i = 0; i < assets.Length; i++)
            {
                var path = AssetDatabase.GUIDToAssetPath(guids[i]);
                assets[i] = AssetDatabase.LoadAssetAtPath<T>(path);
            }
            return assets;
        }

        public static T FindAsset<T>(string filter = null) where T : Object
        {
            return FindAssets<T>(filter).OrderBy(a => a.name).FirstOrDefault();
        }
    }

    public static class AssetDatabaseUtils
    {
        [System.Obsolete("Soon will be removed")]
        public static T[] FindAssets<T>() where T : Object
        {
            return AssetDatabaseExtensions.FindAssets<T>();
        }
    }
}
