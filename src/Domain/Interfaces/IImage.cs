namespace VoxelRenderer.Domain.Interfaces;

interface IImage {
    public void SetPixel(int x, int y, IColor c);
}
