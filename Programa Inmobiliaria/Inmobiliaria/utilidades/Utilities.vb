Imports System.Drawing.Imaging
Imports System.IO
Imports Gma.QrCodeNet.Encoding
Imports Gma.QrCodeNet.Encoding.Windows.Render


''' <summary>
''' Conjunto de utilidades utilizadas en el proyecto
''' </summary>
Module Utilities

    ''' <summary>
    ''' Arreglo de Bytes a Imagen
    ''' </summary>
    ''' <param name="data">Arreglo de Bytes</param>
    ''' <returns>Imagen</returns>
    Public Function ByteArrayToImage(data() As Byte) As Image
        Dim strmData As New MemoryStream(data)
        Return Image.FromStream(strmData)
    End Function

    ''' <summary>
    ''' Imagen a arreglo de Bytes
    ''' </summary>
    ''' <param name="datos">Imagen a convertir</param>
    ''' <returns>Arreglo de Bytes</returns>
    Public Function ImageToByteArray(datos As Image) As Byte()
        Dim mStream As New MemoryStream()
        datos.Save(mStream, ImageFormat.Jpeg)
        Return mStream.ToArray()
    End Function

    ''' <summary>
    ''' Crea un codigo QR a partir de un texto
    ''' </summary>
    ''' <param name="text">Texto a convertir en codigo QR</param>
    ''' <param name="msize">Tamaño de cada modulo que forma el codigo QR</param>
    ''' <returns>Imagen del codigo QR con el texto pasado por parametro</returns>
    Public Function CreateQrCode(text As String, Optional msize As Integer = 30) As Image
        Dim QrEncoder = New QrEncoder(ErrorCorrectionLevel.H)
        Dim QrCode = QrEncoder.Encode(text)
        Dim renderer = New GraphicsRenderer(New FixedModuleSize(msize, QuietZoneModules.Two), Brushes.Black, Brushes.White)
        Dim stream As New MemoryStream
        renderer.WriteToStream(QrCode.Matrix, ImageFormat.Png, stream)
        Return Image.FromStream(stream)
    End Function

    ''' <summary>
    ''' Abre un dialogo de Buqueda de archivos
    ''' </summary>
    ''' <param name="fd">OpenFileDialog</param>
    ''' <returns>Retorna un archivo en array de Bytes</returns>
    Public Function LoadFile(fd As OpenFileDialog, filter As String) As Byte()
        fd.Filter = filter
        fd.FileName = ""
        If fd.ShowDialog <> DialogResult.OK Then
            Return Nothing
        End If
        Dim fs As New FileStream(fd.FileName, FileMode.Open, FileAccess.Read)
        Dim datos(fs.Length) As Byte
        fs.Read(datos, 0, fs.Length)
        Return datos
        fs.Close()
    End Function

    ''' <summary>
    ''' Abre un dialogo de Buqueda de archivos tipo imagen
    ''' </summary>
    ''' <param name="fd">OpenFileDialog</param>
    ''' <returns>Retorna la imagen en array de Bytes</returns>
    Public Function LoadImageFile(fd As OpenFileDialog) As Byte()
        Return LoadFile(fd, "Imagenes|*.jpg;*.jpeg;*.png;*.bmp;")
    End Function

    ''' <summary>
    ''' Junta el arreglo de 2 dimensiones dado por el parametro data
    ''' </summary>
    ''' <param name="data">arreglo de 2 dimensiones de tipo string</param>
    ''' <param name="s1">Separador de los elementos en cada fila</param>
    ''' <param name="s2">Separador de las filas</param>
    ''' <returns>Retorna un string con la union de los elementos del arreglo</returns>
    Public Function Join2d(ByRef data(,) As String, s1 As String, s2 As String) As String
        Dim temp(UBound(data, 2)) As String
        For i = 0 To data.GetLength(1) - 1
            temp(i) = data(0, i) + s1 + data(1, i)
        Next
        Return String.Join(s2, temp)
    End Function

    ''' <summary>
    ''' Junta solo una de las columnas de un arreglo de 2 dimenciones (las columnas son determinadas por la primer dimención del arreglo)
    ''' </summary>
    ''' <param name="data">Arreglo 2d de string</param>
    ''' <param name="sep">separador</param>
    ''' <param name="use">Elige cual de las columnas del arreglo se va a juntar</param>
    ''' <returns>Retorna un string con la union de los elementos de una dimención del arreglo</returns>
    Public Function Join2d(ByRef data(,) As String, sep As String, use As Integer) As String
        Dim temp(UBound(data, 2)) As String
        For i = 0 To data.GetLength(1) - 1
            temp(i) = data(use, i)
        Next
        Return String.Join(sep, temp)
    End Function

    ''' <summary>
    ''' Converte la fecha y Hora de tipo Date a una cadena con el formato utilizado en MySql
    ''' </summary>
    ''' <param name="d">Fecha y Hora de Tipo Date</param>
    ''' <returns>String que representa la fecha dada por parametro</returns>
    Public Function DateToSql(d As Date) As String
        Return d.ToString("yyyy-MM-dd HH:mm:ss")
    End Function

    ''' <summary>
    ''' Redimenciona una imagen manteniendo su relacion de aspecto con un tamaño maximo dado por parametro
    ''' </summary>
    ''' <param name="img">Imagen a redimencionar</param>
    ''' <param name="width">ancho maximo de la imagen redimencionada</param>
    ''' <param name="height">alto maximo de la imagen redimencionada</param>
    ''' <returns>Retorna la imagen redimencionada</returns>
    Public Function ImageResize(img As Image, width As Integer, height As Integer) As Image
        Dim ratio = Math.Max(width / img.Width, height / img.Height)

        Dim w = CInt(img.Width * ratio)
        Dim h = CInt(img.Height * ratio)

        Return New Bitmap(img, w, h)
    End Function
End Module
