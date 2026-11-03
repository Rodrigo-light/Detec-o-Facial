# 🔍 Detecção Facial com C# e Inteligência Artificial

Projeto desenvolvido em C# utilizando OpenCvSharp, OpenCV e o modelo de Inteligência Artificial YuNet para detectar rostos em tempo real através da webcam.

O objetivo é aplicar conceitos de visão computacional e processamento de imagens, utilizando um modelo de IA para localizar rostos em imagens capturadas pela câmera.

## 🚀 Funcionalidades

- Captura de imagens em tempo real pela webcam.
- Detecção facial utilizando o modelo YuNet.
- Processamento de imagens com OpenCV.
- Identificação das coordenadas dos rostos detectados.
- Desenho de retângulos ao redor dos rostos identificados.
- Exibição da imagem processada em uma janela.

## 🛠️ Tecnologias utilizadas

- **C#** – Linguagem de programação.
- **.NET 10** – Plataforma de desenvolvimento.
- **OpenCvSharp** – Biblioteca que permite utilizar recursos do OpenCV em C#.
- **OpenCV** – Biblioteca de visão computacional e processamento de imagens.
- **YuNet** – Modelo de Inteligência Artificial para detecção facial.
- **ONNX** – Formato utilizado para armazenar e executar o modelo de IA.

## 📋 Pré-requisitos

Antes de executar o projeto, é necessário instalar:

### 1. .NET 10 SDK

O projeto utiliza o .NET 10.

Download: https://dotnet.microsoft.com/download/dotnet/10.0

Após instalar, abra o terminal e execute:

```bash
dotnet --version
```

### 2. Visual Studio Code

Editor utilizado no desenvolvimento do projeto.

Download: https://code.visualstudio.com/

### 3. Extensão C# Dev Kit

No Visual Studio Code:

1. Abra a aba de extensões.
2. Pesquise por `C# Dev Kit`.
3. Instale a extensão da Microsoft.

### 4. Webcam

É necessário possuir uma webcam conectada ao computador e permitir que o Windows e o aplicativo tenham acesso à câmera.

## 📦 Pacotes NuGet utilizados

O projeto utiliza os seguintes pacotes:

| Pacote | Versão | Finalidade |
|---|---|---|
| OpenCvSharp4 | 4.13.0.20260627 | Utilização dos recursos do OpenCV em C#. |
| OpenCvSharp4.runtime.win | 4.13.0.20260627 | Bibliotecas nativas necessárias para executar o OpenCvSharp no Windows. |

**Importante:** não é necessário instalar esses pacotes manualmente. Eles já estão declarados no arquivo `recocherFacial.csproj` e serão restaurados automaticamente pelo .NET.

## 🧠 Modelo de Inteligência Artificial

O projeto utiliza o modelo YuNet:

`face_detection_yunet_2023mar.onnx`

O arquivo deve estar dentro da pasta:

```text
ModelosIA/
└── face_detection_yunet_2023mar.onnx
```

O modelo é carregado automaticamente pela aplicação durante a inicialização.

O projeto também mantém o arquivo Haar Cascade:

```text
Modelos/
└── haarcascade_frontalface_default.xml
```

Esse arquivo pertence à implementação anterior de detecção facial e pode ser utilizado em futuras melhorias.

## 📥 Como instalar e executar

### 1. Clonar o repositório

Abra o terminal e execute:

```bash
git clone https://github.com/Rodrigo-light/Detec-o-Facial.git
```

### 2. Entrar na pasta do projeto

```bash
cd Detec-o-Facial
```

### 3. Restaurar os pacotes

```bash
dotnet restore
```

Esse comando baixa as dependências NuGet declaradas no projeto.

### 4. Compilar o projeto

```bash
dotnet build
```

### 5. Executar

```bash
dotnet run
```

A aplicação abrirá a webcam e começará a detectar os rostos presentes na imagem.

Para encerrar a execução, pressione a tecla:

```text
Q
```

## 📁 Estrutura do projeto

```text
Detec-o-Facial/
│
├── ModelosIA/
│   └── face_detection_yunet_2023mar.onnx
│
├── class/
│   ├── Camera.cs
│   ├── ConversorImagem.cs
│   ├── DetectorFacial.cs
│   ├── DesenhadorRostos.cs
│   └── LocalizarArquivoXml.cs
│
├── modelos/
│   └── haarcascade_frontalface_default.xml
│
├── Program.cs
│
├── recocherFacial.csproj
│
└── README.md
```

## ⚙️ Como funciona?

O funcionamento do projeto acontece em algumas etapas:

1. **Captura:** a webcam captura os frames em tempo real.
2. **Detecção:** o modelo YuNet analisa a imagem e localiza os rostos.
3. **Coordenadas:** o sistema obtém a posição e as dimensões de cada rosto detectado.
4. **Desenho:** são desenhados retângulos ao redor dos rostos.
5. **Exibição:** a imagem processada é apresentada na tela.

## ⚠️ Observações

- Atualmente, o projeto realiza detecção facial, não reconhecimento de identidade.
- É necessário manter o arquivo ONNX na pasta esperada pelo programa.
- A versão atual não possui detecção de vivacidade (Face Anti-Spoofing).
- O projeto foi configurado para Windows, utilizando o pacote `OpenCvSharp4.runtime.win`.

## 🔮 Melhorias futuras

- Implementar Face Anti-Spoofing para tentar diferenciar rostos reais de fotografias e telas.
- Melhorar a precisão da detecção facial.
- Identificar pontos importantes do rosto, como olhos, nariz e boca.
- Desenvolver novas funcionalidades utilizando Inteligência Artificial.

## 👨‍💻 Desenvolvedor

**Rodrigo Líbano**

Projeto desenvolvido com o objetivo de estudar e aplicar conceitos de C#, Inteligência Artificial e Visão Computacional.

## 📄 Licença

Este projeto está disponível para fins de estudo e aprendizado. Consulte as licenças das bibliotecas e do modelo YuNet utilizados antes de redistribuí-los.

## 📚 Modelos pré-treinados utilizados

Este projeto utiliza modelos de detecção facial previamente treinados, disponibilizados publicamente pelo projeto OpenCV.

Os modelos não foram treinados do zero para este projeto. Eles foram baixados e integrados à aplicação C#.

### YuNet (ONNX)

- **Finalidade:** detecção facial.
- **Arquivo:** `face_detection_yunet_2023mar.onnx`.
- **Fonte:** [OpenCV Zoo – YuNet](https://github.com/opencv/opencv_zoo/tree/main/models/face_detection_yunet).
- **Download:** [Modelo ONNX](https://huggingface.co/opencv/opencv_zoo/resolve/main/models/face_detection_yunet/face_detection_yunet_2023mar.onnx).

### Haar Cascade (XML)

- **Finalidade:** detecção frontal de rostos.
- **Arquivo:** `haarcascade_frontalface_default.xml`.
- **Fonte:** [OpenCV – Haar Cascades](https://github.com/opencv/opencv_attic/tree/master/opencv/data/haarcascades).
- **Download:** [Arquivo XML](https://raw.githubusercontent.com/opencv/opencv_attic/master/opencv/data/haarcascades/haarcascade_frontalface_default.xml).

### Créditos

Agradecimentos aos desenvolvedores e colaboradores do projeto OpenCV pela disponibilização dos modelos pré-treinados utilizados como base para este projeto.

Consulte as licenças e condições de redistribuição dos modelos nos respectivos repositórios de origem.