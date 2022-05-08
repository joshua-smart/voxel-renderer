namespace VoxelRenderer.Domain.Interfaces;

public interface ICamera {
    public IImage Render(IScene scene);
}
