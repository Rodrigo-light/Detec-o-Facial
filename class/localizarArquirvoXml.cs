
class LocalizarArquivoXml
{
    public string LocalizarArquivo()
    {
        string caminhoXml = Path.Combine(
            AppContext.BaseDirectory,
            "Modelos",
            "haarcascade_frontalface_default.xml"
        );

        if (!File.Exists(caminhoXml))
        {
            throw new FileNotFoundException(
                "Arquivo XML não encontrado!",
                caminhoXml
            );
        }

        return caminhoXml;
    }
}
