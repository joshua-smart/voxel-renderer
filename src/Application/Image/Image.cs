using VoxelRenderer.Domain.Interfaces;
using VoxelRenderer.Application.DataStructures;

namespace VoxelRenderer.Application.Image;

public class Image : IImage {

    private byte[,,] Pixels;

    public Image(int width, int height) {
        Pixels = new byte[width, height, 4];
    }

    public IColor GetPixel(int x, int y) {
        byte[] data = new byte[4];

        for (int i = 0; i < 4; i++) {
            data[i] = Pixels[x, y, i];
        }

        return Color.FromBytes(data);
    }
    
    public void SetPixel(int x, int y, IColor c) {
        byte[] bytes = c.ToBytes();
        for (int i = 0; i < 4; i++) {
            Pixels[x, y, i] = bytes[i];
        }
    }
}
