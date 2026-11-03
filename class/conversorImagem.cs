using OpenCvSharp;
//O conversor de imagens utilizado no início do projeto foi desenvolvido com outra IA.
class ConversorImagem{
    public Mat ConverterParaCinza(Mat imagemColorida){

        Mat imagemCinza = new Mat();

        Cv2.CvtColor(
            imagemColorida,
            imagemCinza,
            ColorConversionCodes.BGR2GRAY
        );

        return imagemCinza;


    }
}