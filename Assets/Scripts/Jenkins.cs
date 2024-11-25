using System;
using System.Collections.Generic;
using UnityEditor;

public class Jenkins
{
    //dd
#if UNITY_EDITOR
    //[MenuItem("Build/Standalone Windows")]
    public static void PerformPCBuild()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();
        // 씬 추가
        List<string> scenes = new List<string>();
        foreach (var scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            scenes.Add(scene.path);
        }
        options.scenes = scenes.ToArray();
        // 타겟 경로(빌드 결과물이 여기 생성됨)
        options.locationPathName = "C:/Builds/UnityWindowsBuild/Build.exe";
        // 빌드 타겟
        options.target = BuildTarget.StandaloneWindows64;

        // 빌드
        BuildPipeline.BuildPlayer(options);
    }

    public static void PerformWebGLBuild()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();
        // 씬 추가
        List<string> scenes = new List<string>();
        foreach (var scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            scenes.Add(scene.path);
        }
        options.scenes = scenes.ToArray();
        // 타겟 경로(빌드 결과물이 여기 생성됨)
        options.locationPathName = "C:/WebGLBuild/Build";
        // 빌드 타겟
        options.target = BuildTarget.WebGL;

        // 빌드
        BuildPipeline.BuildPlayer(options);
    }
#endif
}