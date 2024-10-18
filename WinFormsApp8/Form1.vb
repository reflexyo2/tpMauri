Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private Sub salirB_Click(sender As Object, e As EventArgs) Handles salirB.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MARCA_VEHICULO.Items.AddRange(New String() {
            "FORD",
            "CHEVROLET",
            "TOYOTA",
            "NISSAN",
            "MERCEDES-BENZ",
            "VOLKSWAGEN",
            "HONDA",
            "HYUNDAI",
            "KIA",
            "JEEP"
        })
    End Sub

    Private Sub CargarModelosSegunMarca(marcaSeleccionada As String)
        MODELO_VEHICULO.Items.Clear()

        Select Case marcaSeleccionada
            Case "FORD"
                MODELO_VEHICULO.Items.AddRange(New String() {"F-150 RAPTOR", "RANGER", "MAVERICK", "MUSTANG", "FOCUS", "FIESTA", "EXPLORER"})

            Case "CHEVROLET"
                MODELO_VEHICULO.Items.AddRange(New String() {"SILVERADO", "COLORADO", "CAMARO COUPE", "MALIBU", "SPARK", "CORVETTE"})

            Case "TOYOTA"
                MODELO_VEHICULO.Items.AddRange(New String() {"HILUX", "TACOMA", "TUNDRA", "COROLLA", "CAMRY", "PRIUS", "YARIS"})

            Case "NISSAN"
                MODELO_VEHICULO.Items.AddRange(New String() {"FRONTIER", "NAVARA", "TITAN", "ALTIMA", "SENTRA", "MAXIMA", "VERSA"})

            Case "MERCEDES-BENZ"
                MODELO_VEHICULO.Items.AddRange(New String() {"X-CLASS", "G 63 AMG 6X6", "C-CLASS", "E-CLASS", "S-CLASS", "A-CLASS"})

            Case "VOLKSWAGEN"
                MODELO_VEHICULO.Items.AddRange(New String() {"AMAROK", "TAROK", "SAVEIRO", "GOLF", "JETTA", "PASSAT", "POLO"})

            Case "HONDA"
                MODELO_VEHICULO.Items.AddRange(New String() {"RIDGELINE", "CIVIC", "ACCORD", "FIT", "CR-V"})

            Case "HYUNDAI"
                MODELO_VEHICULO.Items.AddRange(New String() {"ELANTRA", "SONATA", "TUCSON", "VELOSTER"})

            Case "KIA"
                MODELO_VEHICULO.Items.AddRange(New String() {"RIO", "FORTE", "OPTIMA", "SPORTAGE"})
        End Select
        TextBoxprecio.Text = String.Empty



    End Sub
    Private Sub CargarPrecioDesdeArchivo(modeloSeleccionado As String)
        Dim Ruta_de_Archivo As String = "D:\Microsoft.NET\precios\PRECIOS_VEHICULOS.txt"
        Try
            If File.Exists(Ruta_de_Archivo) Then
                Dim lineas As String() = File.ReadAllLines(Ruta_de_Archivo)



                ' Recorre todas las líneas del archivo para buscar el modelo seleccionado
                For Each linea As String In lineas
                    Dim datos() As String = linea.Split(","c) ' Dividimos la línea en marca, modelo y precio




                    ' Verificar si la línea contiene los 3 elementos esperados
                    If datos.Length = 3 Then
                        Dim marca As String = datos(0)
                        Dim modelo As String = datos(1)
                        Dim precio As String = datos(2)

                        ' Si el modelo seleccionado coincide con el modelo en el archivo, mostramos el precio
                        If modeloSeleccionado = modelo Then
                            TextBoxprecio.Text = precio ' Asignar el precio al TextBox
                            Exit Sub ' Salir del bucle una vez que encontramos el modelo
                        End If
                    End If
                Next

                ' Si no se encuentra el modelo seleccionado
                MessageBox.Show("Modelo no encontrado en el archivo.")
            Else
                MessageBox.Show("El archivo no existe.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer el archivo" & ex.Message)
        End Try
    End Sub



    Private Sub PAGOS_VEHICULO_SelectedIndexCharged(sender As Object, e As EventArgs) Handles PAGOS_VEHICULO.SelectedIndexChanged
        Dim credito, coutas, efect, tranf, cheque, auto, dos_medios_pago As Integer
        Select Case PAGOS_VEHICULO.SelectedItem.ToString
            Case "EFECTIVO"



            Case "Cuotas"


            Case "Transferencia"


            Case "Cheque"


            Case "Auto para medio de pago"


            Case "Dos metodos de pago"


        End Select
    End Sub

    Private Sub MARCA_VEHICULO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MARCA_VEHICULO.SelectedIndexChanged
        ' Obtener la marca seleccionada en el ComboBox
        Dim marcaSeleccionada As String = MARCA_VEHICULO.SelectedItem.ToString()

        ' Cargar los modelos correspondientes a la marca seleccionada
        CargarModelosSegunMarca(marcaSeleccionada)
    End Sub

    Private Sub MODELO_VEHICULO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MODELO_VEHICULO.SelectedIndexChanged
        ' Obtener el modelo seleccionado en el ComboBox
        Dim modeloSeleccionado As String = MODELO_VEHICULO.SelectedItem.ToString()

        ' Cargar el precio correspondiente desde el archivo
        CargarPrecioDesdeArchivo(modeloSeleccionado)
    End Sub


End Class


