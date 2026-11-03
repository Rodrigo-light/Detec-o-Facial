using OpenCvSharp;

class Camera: IDisposable{

    private VideoCapture? camera;

    public bool Abrir(int numeroCamera = 0){
        camera = new VideoCapture(numeroCamera);
        camera.Set(VideoCaptureProperties.FrameWidth, 640);
camera.Set(VideoCaptureProperties.FrameHeight, 480);

        if (!camera.IsOpened())
        {
            Console.WriteLine("Não foi possível abrir a câmera.");
            camera.Dispose();
            camera = null;
            return false;
        }

        return true;
    }


    public Mat CapturarImagem(){
         Mat frame = new Mat();

        if (camera == null || !camera.Read(frame) || frame.Empty())
        {
            frame.Dispose();
            return new Mat();
        }

        return frame;
    }

 public void Fechar()
    {
        camera?.Dispose();
        camera = null;
    }

    public void Dispose()
    {
        Fechar();
    }

}