namespace VoxelRenderer.Domain.Interfaces;

public interface IColor {
    
    public static IColor FromBytes(byte[] data) { throw new NotImplementedException(); }

    public byte[] ToBytes();
}
