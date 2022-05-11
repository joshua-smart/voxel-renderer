using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.Cameras;

class PerspectiveCamera : ICamera {

    private double Fov;

    public PerspectiveCamera(double fov) {
        Fov = fov;
    }

    public IImage Render(IScene scene) {
        return null;
    }
}
