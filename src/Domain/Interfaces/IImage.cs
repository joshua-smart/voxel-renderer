namespace VoxelRenderer.Domain.Interfaces;

public interface IImage {

    public void SetPixel(int x, int y, IColor c);

    public IColor GetPixel(int x, int y);

    public int GetWidth();
    public int GetHeight();
}
