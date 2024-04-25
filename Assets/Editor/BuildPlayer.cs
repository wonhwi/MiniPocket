using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;
using UnityEditor.Build.Reporting;

public class BuildPlayer : MonoBehaviour
{
  [MenuItem("Build/Standalone Windows")]
  public static void Build_AOS_Debug()
  {
    BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
    {
      scenes = GetScenes(),
      locationPathName = $"Builds/MiniPocket_{PlayerSettings.bundleVersion}.exe",
      target = BuildTarget.StandaloneWindows
    };

    BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);

    Debug.Log(GetResult(report.summary));

    //Hi plz build plz
  }



  static string[] GetScenes()
    => EditorBuildSettings.scenes.Where(n => n.enabled).Select(m => m.path).ToArray();

  static string GetResult(BuildSummary buildSummary) => buildSummary.result switch
  {
    BuildResult.Succeeded
      => $"Build succeeded: {buildSummary.totalSize} bytes in {buildSummary.totalTime}",

    BuildResult.Unknown
    or BuildResult.Failed
    or BuildResult.Cancelled
    or _
      => $"Build {buildSummary.result} totalErrors = {buildSummary.totalErrors}",
  };

}
