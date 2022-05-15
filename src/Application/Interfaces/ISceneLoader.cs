using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.Interfaces;

public interface ISceneLoader {
    public IScene Load();
}
