using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.DataStructures;

public class Image : IImage {

    private byte[] Pixels;
    private int Width;
    private int Height;

    public Image(int width, int height) {
        Width = width;
        Height = height;
        Pixels = new byte[width * height * 4];
    }

    public int GetWidth() { return Width; }
    public int GetHeight() { return Height; }

    private int GetIndex(int x, int y, int i) {
        return y * Width * 4 + x * 4 + i;
    }

    public IColor GetPixel(int x, int y) {
        byte[] data = new byte[4];

        for (int i = 0; i < 4; i++) {
            data[i] = Pixels[GetIndex(x, y, i)];
        }

        return Color.FromBytes(data);
    }
    
    public void SetPixel(int x, int y, IColor c) {
        byte[] bytes = c.ToBytes();
        for (int i = 0; i < 4; i++) {
            Pixels[GetIndex(x, y, i)] = bytes[i];
        }
    }
}
