using VoxelRenderer.Domain.Interfaces;
using VoxelRenderer.Application.Interfaces;
using SixLabors.ImageSharp.PixelFormats;
using ImageSharp = SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;

namespace VoxelRenderer.Infrastructure.ImageWriters;

public class ImageFileWriter : IImageWriter {

    private string FilePath;

    public ImageFileWriter(string filePath) {
        FilePath = filePath;
    }

    public void Write(IImage image) {
        ImageSharp.Image<Rgba32> fileImage = new (image.GetWidth(), image.GetHeight());

        for (int x = 0; x < image.GetWidth(); x++) {
            for(int y = 0; y < image.GetHeight(); y++) {
                IColor color = image.GetPixel(x, y);
                byte[] colorBytes = color.ToBytes();
                Rgba32 colorFormatted = new (colorBytes[0], colorBytes[1], colorBytes[2], colorBytes[3]);
                fileImage[x, y] = colorFormatted;
            }
        }

        FileStream fileStream = File.Open(FilePath, FileMode.Create);
        fileImage.Save(fileStream, new PngEncoder());
    }
}
