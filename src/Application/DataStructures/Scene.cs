using VoxelRenderer.Domain.Interfaces;
using VoxelRenderer.Domain.Maths;

namespace VoxelRenderer.Application.DataStructures;

public class Scene : IScene {

    private int[] VoxelSpace;
    private int Width;
    private int Height;
    private IMaterial[] Materials;

    private Vector3 CameraPosition;
    private Quaternion CameraRotation;

    public Scene(int[] voxelSpace, IMaterial[] materials, Vector3 cameraPosition, Quaternion cameraRotation) {
        VoxelSpace = voxelSpace;
        Materials = materials;
        CameraPosition = cameraPosition;
        CameraRotation = cameraRotation;
    }

    private int GetIndex(int x, int y, int z) {
        return z * Width * Height + y * Width + x;
    }

    public IMaterial? GetVoxel(int x, int y, int z) {
        try {
            int materialIndex = VoxelSpace[GetIndex(x, y, z)];
            return Materials[materialIndex];
        } catch (IndexOutOfRangeException e) {
            return null;
        }
    }
}
