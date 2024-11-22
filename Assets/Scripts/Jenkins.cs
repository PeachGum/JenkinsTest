﻿using System;
using System.Collections.Generic;
using UnityEditor;

public class Jenkins
{
    //dd
#if UNITY_EDITOR
    //[MenuItem("Build/Standalone Windows")]
    public static void PerformBuild()
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
        options.locationPathName = "UnityWindowsBuild"; // 241123 path 
        // 빌드 타겟
        options.target = BuildTarget.StandaloneWindows64;

        // 빌드
        BuildPipeline.BuildPlayer(options);
    }
#endif
}