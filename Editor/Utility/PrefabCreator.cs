namespace Tilia.Visuals.Tooltip.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string project = "Visuals/Tooltip/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation + project;

        private const string package = "io.extendreality.tilia.visuals.tooltip.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabTooltip = "Visuals.Tooltip";

        [MenuItem(menuItemRoot + prefabTooltip, false, priority)]
        private static void AddTooltip()
        {
            string prefab = prefabTooltip + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}