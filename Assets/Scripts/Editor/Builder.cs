using UnityEditor;
using System;

namespace Builder.Editor {

    public static class Builder
    {
        public static void BuildAndroid()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = new[] { "Assets/Scene/SampleScene.unity", "Assets/Scene2.unity" };
            buildPlayerOptions.target = BuildTarget.Android;
            buildPlayerOptions.options = BuildOptions.None;
            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }
    }
}
