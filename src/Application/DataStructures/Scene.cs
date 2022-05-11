using VoxelRenderer.Domain.Interfaces;
using VoxelRenderer.Domain.Maths;

namespace VoxelRenderer.Application.DataStructures;

public class Scene : IScene {

    private IMaterial[][][] VoxelSpace;

    private Vector3 CameraPosition;
    private Quaternion CameraRotation;

    public Scene(IMaterial[][][] voxelSpace, Vector3 cameraPosition, Quaternion cameraRotation) {
        VoxelSpace = voxelSpace;
        CameraPosition = cameraPosition;
        CameraRotation = cameraRotation;
    }

    public IMaterial? GetVoxel(int x, int y, int z) {
        try {
            return VoxelSpace[x][y][z];
        } catch (IndexOutOfRangeException e) {
            return null;
        }
    }
}
