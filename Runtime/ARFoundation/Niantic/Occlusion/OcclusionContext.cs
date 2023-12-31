namespace Niantic.Lightship.AR.ARFoundation
{
    internal struct OcclusionContext
    {
        /// Linear eye-depth from the camera to the occludee
        public float OccludeeEyeDepth;

        /// The aspect ratio of the camera (background) image
        public float? CameraImageAspectRatio;

        /// Global setting
        public static OcclusionContext Shared;

        static OcclusionContext()
        {
            // Defaults
            Shared.CameraImageAspectRatio = null;
            ResetOccludee();
        }

        public static void ResetOccludee()
        {
#if UNITY_EDITOR
            Shared.OccludeeEyeDepth = 100.0f;
#else
            Shared.OccludeeEyeDepth = 5.0f;
#endif
        }
    }
}
