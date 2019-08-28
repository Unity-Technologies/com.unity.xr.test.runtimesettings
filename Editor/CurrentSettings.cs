using UnityEngine;

namespace com.unity.xr.test.runtimesettings
{
    public class CurrentSettings : ScriptableObject
    {
        public string EnabledXrTarget;
        public string PlayerGraphicsApi;
        public string StereoRenderingMode;

        // OculusSettings.StereoRenderingMode, to string
        public string StereoRenderingModeDesktop;
        public string StereoRenderingModeAndroid;

        public bool MtRendering;
        public bool GraphicsJobs;

        public string SimulationMode;
    }
}