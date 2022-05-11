using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.DataStructures;

public class Color : IColor {

    private readonly int R, G, B, A;

    public Color(int r, int g, int b, int a) {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    public static IColor FromBytes(byte[] data) {
        int r = data[0];
        int g = data[1];
        int b = data[2];
        int a = data[3];

        return new Color(r, g, b, a);
    }

    public byte[] ToBytes() {
        return new byte[] {
            (byte) R, 
            (byte) G,
            (byte) B, 
            (byte) A
        };
    }
}
