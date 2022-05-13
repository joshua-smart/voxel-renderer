using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.Interfaces;

public interface IImageWriter {
    public void Write(IImage image);
}
