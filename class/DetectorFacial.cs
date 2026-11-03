
using OpenCvSharp;
using System.IO;

class DetectorFacial : IDisposable
{
    private FaceDetectorYN detector;

    public DetectorFacial()
    {
        string caminhoModelo = Path.Combine(
            AppContext.BaseDirectory,
            "ModelosIA",
            "face_detection_yunet_2023mar.onnx"
        );

        if (!File.Exists(caminhoModelo))
        {
            throw new FileNotFoundException(
                "Modelo YuNet não encontrado!",
                caminhoModelo
            );
        }

        detector = FaceDetectorYN.Create(
            caminhoModelo,
            "",
            new Size(640, 480),
            0.8f,
            0.3f,
            5000
        );

        Console.WriteLine("Modelo YuNet carregado!");
    }

    public void Dispose()
    {
        detector.Dispose();
    }

    
public Rect[] DetectarRostos(Mat imagemColorida)
{
    if (imagemColorida.Empty())
    {
        return Array.Empty<Rect>();
    }

    
    using Mat resultados = new Mat();

    detector.Detect(imagemColorida, resultados);

   int quantidadeRostos = resultados.Rows;

Rect[] rostos = new Rect[quantidadeRostos];

for (int i = 0; i < quantidadeRostos; i++)
    {
        int x = (int)resultados.At<float>(i, 0);
        int y = (int)resultados.At<float>(i, 1);
        int largura = (int)resultados.At<float>(i, 2);
        int altura = (int)resultados.At<float>(i, 3);

        rostos[i] = new Rect(x, y, largura, altura);
    }

    return rostos;
}

}



