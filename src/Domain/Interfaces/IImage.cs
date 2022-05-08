namespace VoxelRenderer.Domain.Interfaces;

public interface IImage {
    public void SetPixel(int x, int y, IColor c);
}
