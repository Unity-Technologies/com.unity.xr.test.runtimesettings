using UnityEngine;

namespace com.unity.xr.test.runtimesettings
{
    public class CurrentSettings : ScriptableObject
    {
        public string EnabledXrTarget;
        public string PlayerGraphicsApi;
        public string StereoRenderingMode;
        public string StereoRenderingModeDesktop;
        public string StereoRenderingModeAndroid;
        public bool MtRendering;
        public bool GraphicsJobs;
        public string SimulationMode;
        public string ColorSpace;
        public string PluginVersion;
        public string XrsdkRevision;
        public string XrManagementRevision;
        public string PerfTestsPackageRevision;
        public string DeviceRuntimeVersion;
        public string Username;
        public string RenderPipeline;
        public int AntiAliasing;
        public string FfrLevel;
        public string TestsRevision;
        public string TestsRevisionDate;
        public string TestsBranch;
        public string AndroidTargetArchitecture;
    }
}