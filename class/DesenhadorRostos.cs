
using OpenCvSharp;

class DesenhadorRostos
{
    public void DesenharRetangulos(Mat imagem, Rect[] rostos)
    {
        foreach (Rect rosto in rostos)
        {
            Cv2.Rectangle(
                imagem,
                rosto,
                Scalar.Green,
                2
            );
        }
    }
}
