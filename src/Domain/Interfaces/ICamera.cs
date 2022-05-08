namespace VoxelRenderer.Domain.Interfaces;

interface ICamera {
    public IImage Render(IScene scene);
}
