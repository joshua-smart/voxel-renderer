using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.Interfaces;

interface ISceneLoader {
    public IScene? Load();
}
