namespace VoxelRenderer.Domain.Interfaces;

public interface IScene {
    public IMaterial? GetVoxel(int x, int y, int z);
}
