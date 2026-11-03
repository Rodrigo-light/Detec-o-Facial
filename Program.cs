
using OpenCvSharp;

class Program
{
    static void Main()
    {
        using var camera = new Camera();

        
        var detector = new DetectorFacial();
        var desenhador = new DesenhadorRostos();

        if (!camera.Abrir())
        {
            return;
        }

        while (true)
        {
            using Mat frame = camera.CapturarImagem();

            if (frame.Empty())
            {
                continue;
            }


           Rect[] rostos = detector.DetectarRostos(frame);

            desenhador.DesenharRetangulos(frame, rostos);

            Cv2.ImShow("Reconhecimento Facial", frame);

            int tecla = Cv2.WaitKey(1);

            if (tecla == 'q')
            {
                break;
            }
        }

        Cv2.DestroyAllWindows();
    }
}

