<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        HISTORIAL_COMPRA = New TabControl()
        TabPage1 = New TabPage()
        SplitContainer1 = New SplitContainer()
        TELEFONO_COMPRADOR = New TextBox()
        CORREO_COMPRADOR = New TextBox()
        APELLIDO_COMPRADOR = New TextBox()
        NOMBRE_COMPRADOR = New TextBox()
        TELEFONO_C = New Label()
        CORREO_C = New Label()
        APELLIDO_C = New Label()
        NOMBRE_C = New Label()
        Label2 = New Label()
        CONFIRMAR = New Button()
        TextBoxprecio = New TextBox()
        PRECIO_VEHICULO = New Label()
        Label3 = New Label()
        PAGOS_VEHICULO = New ComboBox()
        COLOR_VEHICULO = New ComboBox()
        MODELO_VEHICULO = New ComboBox()
        MARCA_VEHICULO = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TabPage2 = New TabPage()
        COMPRAR = New Button()
        PATENTE_COMPRADOR = New TextBox()
        PRECIO_COMPRA = New TextBox()
        MODELO_COMPRA = New TextBox()
        PROPIETARIO_VEHICULO = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label12 = New Label()
        COLOR_COMPRA = New ComboBox()
        MARCA_COMPRA = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label11 = New Label()
        TabPage3 = New TabPage()
        HISTORIAL_VENTA = New DataGridView()
        MARCA_V = New DataGridViewTextBoxColumn()
        MODELO_V = New DataGridViewTextBoxColumn()
        COLOR_V = New DataGridViewTextBoxColumn()
        PRECIO_V = New DataGridViewTextBoxColumn()
        TabPage4 = New TabPage()
        DataGridView2 = New DataGridView()
        PROPIETARIO_C = New DataGridViewTextBoxColumn()
        MARCA_C = New DataGridViewTextBoxColumn()
        MODELO_C = New DataGridViewTextBoxColumn()
        COLOR_C = New DataGridViewTextBoxColumn()
        PATENTE_C = New DataGridViewTextBoxColumn()
        FECHA = New DateTimePicker()
        salirB = New Button()
        Label1 = New Label()
        HISTORIAL_COMPRA.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(HISTORIAL_VENTA, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HISTORIAL_COMPRA
        ' 
        HISTORIAL_COMPRA.Controls.Add(TabPage1)
        HISTORIAL_COMPRA.Controls.Add(TabPage2)
        HISTORIAL_COMPRA.Controls.Add(TabPage3)
        HISTORIAL_COMPRA.Controls.Add(TabPage4)
        HISTORIAL_COMPRA.Location = New Point(0, 46)
        HISTORIAL_COMPRA.Name = "HISTORIAL_COMPRA"
        HISTORIAL_COMPRA.SelectedIndex = 0
        HISTORIAL_COMPRA.Size = New Size(801, 367)
        HISTORIAL_COMPRA.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(SplitContainer1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(793, 339)
        TabPage1.TabIndex = 0
        TabPage1.Text = "VENTA"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(TELEFONO_COMPRADOR)
        SplitContainer1.Panel1.Controls.Add(CORREO_COMPRADOR)
        SplitContainer1.Panel1.Controls.Add(APELLIDO_COMPRADOR)
        SplitContainer1.Panel1.Controls.Add(NOMBRE_COMPRADOR)
        SplitContainer1.Panel1.Controls.Add(TELEFONO_C)
        SplitContainer1.Panel1.Controls.Add(CORREO_C)
        SplitContainer1.Panel1.Controls.Add(APELLIDO_C)
        SplitContainer1.Panel1.Controls.Add(NOMBRE_C)
        SplitContainer1.Panel1.Controls.Add(Label2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(CONFIRMAR)
        SplitContainer1.Panel2.Controls.Add(TextBoxprecio)
        SplitContainer1.Panel2.Controls.Add(PRECIO_VEHICULO)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(PAGOS_VEHICULO)
        SplitContainer1.Panel2.Controls.Add(COLOR_VEHICULO)
        SplitContainer1.Panel2.Controls.Add(MODELO_VEHICULO)
        SplitContainer1.Panel2.Controls.Add(MARCA_VEHICULO)
        SplitContainer1.Panel2.Controls.Add(Label7)
        SplitContainer1.Panel2.Controls.Add(Label8)
        SplitContainer1.Panel2.Controls.Add(Label9)
        SplitContainer1.Panel2.Controls.Add(Label10)
        SplitContainer1.Size = New Size(787, 333)
        SplitContainer1.SplitterDistance = 372
        SplitContainer1.TabIndex = 0
        ' 
        ' TELEFONO_COMPRADOR
        ' 
        TELEFONO_COMPRADOR.Location = New Point(120, 148)
        TELEFONO_COMPRADOR.Name = "TELEFONO_COMPRADOR"
        TELEFONO_COMPRADOR.Size = New Size(160, 23)
        TELEFONO_COMPRADOR.TabIndex = 8
        ' 
        ' CORREO_COMPRADOR
        ' 
        CORREO_COMPRADOR.Location = New Point(120, 111)
        CORREO_COMPRADOR.Name = "CORREO_COMPRADOR"
        CORREO_COMPRADOR.Size = New Size(160, 23)
        CORREO_COMPRADOR.TabIndex = 7
        ' 
        ' APELLIDO_COMPRADOR
        ' 
        APELLIDO_COMPRADOR.Location = New Point(120, 76)
        APELLIDO_COMPRADOR.Name = "APELLIDO_COMPRADOR"
        APELLIDO_COMPRADOR.Size = New Size(160, 23)
        APELLIDO_COMPRADOR.TabIndex = 6
        ' 
        ' NOMBRE_COMPRADOR
        ' 
        NOMBRE_COMPRADOR.Location = New Point(120, 42)
        NOMBRE_COMPRADOR.Name = "NOMBRE_COMPRADOR"
        NOMBRE_COMPRADOR.Size = New Size(160, 23)
        NOMBRE_COMPRADOR.TabIndex = 5
        ' 
        ' TELEFONO_C
        ' 
        TELEFONO_C.AutoSize = True
        TELEFONO_C.Font = New Font("Segoe UI", 13F)
        TELEFONO_C.Location = New Point(5, 145)
        TELEFONO_C.Name = "TELEFONO_C"
        TELEFONO_C.Size = New Size(101, 25)
        TELEFONO_C.TabIndex = 4
        TELEFONO_C.Text = "TELEFONO:"
        ' 
        ' CORREO_C
        ' 
        CORREO_C.AutoSize = True
        CORREO_C.Font = New Font("Segoe UI", 13F)
        CORREO_C.Location = New Point(5, 109)
        CORREO_C.Name = "CORREO_C"
        CORREO_C.Size = New Size(86, 25)
        CORREO_C.TabIndex = 3
        CORREO_C.Text = "CORREO:"
        ' 
        ' APELLIDO_C
        ' 
        APELLIDO_C.AutoSize = True
        APELLIDO_C.Font = New Font("Segoe UI", 13F)
        APELLIDO_C.Location = New Point(5, 73)
        APELLIDO_C.Name = "APELLIDO_C"
        APELLIDO_C.Size = New Size(95, 25)
        APELLIDO_C.TabIndex = 2
        APELLIDO_C.Text = "APELLIDO:"
        ' 
        ' NOMBRE_C
        ' 
        NOMBRE_C.AutoSize = True
        NOMBRE_C.Font = New Font("Segoe UI", 13F)
        NOMBRE_C.Location = New Point(5, 42)
        NOMBRE_C.Name = "NOMBRE_C"
        NOMBRE_C.Size = New Size(89, 25)
        NOMBRE_C.TabIndex = 1
        NOMBRE_C.Text = "NOMBRE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 25)
        Label2.TabIndex = 0
        Label2.Text = "DATOS DEL COMPRADOR"
        ' 
        ' CONFIRMAR
        ' 
        CONFIRMAR.Location = New Point(310, 285)
        CONFIRMAR.Name = "CONFIRMAR"
        CONFIRMAR.Size = New Size(95, 35)
        CONFIRMAR.TabIndex = 15
        CONFIRMAR.Text = "CONFIRMAR"
        CONFIRMAR.UseVisualStyleBackColor = True
        ' 
        ' TextBoxprecio
        ' 
        TextBoxprecio.Location = New Point(240, 210)
        TextBoxprecio.Name = "TextBoxprecio"
        TextBoxprecio.Size = New Size(121, 23)
        TextBoxprecio.TabIndex = 9
        ' 
        ' PRECIO_VEHICULO
        ' 
        PRECIO_VEHICULO.AutoSize = True
        PRECIO_VEHICULO.Font = New Font("Segoe UI", 13F)
        PRECIO_VEHICULO.Location = New Point(8, 207)
        PRECIO_VEHICULO.Name = "PRECIO_VEHICULO"
        PRECIO_VEHICULO.Size = New Size(76, 25)
        PRECIO_VEHICULO.TabIndex = 14
        PRECIO_VEHICULO.Text = "PRECIO:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F)
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 25)
        Label3.TabIndex = 13
        Label3.Text = "DATOS DEL VEHICULO"
        ' 
        ' PAGOS_VEHICULO
        ' 
        PAGOS_VEHICULO.FormattingEnabled = True
        PAGOS_VEHICULO.Items.AddRange(New Object() {"Crédito (con IVA)", "Cuotas (12-18-24-36-48)", "Efectivo", "Transferencia", "Cheque", "Auto para medio de pago", "Dos métodos de pago"})
        PAGOS_VEHICULO.Location = New Point(240, 167)
        PAGOS_VEHICULO.Name = "PAGOS_VEHICULO"
        PAGOS_VEHICULO.Size = New Size(121, 23)
        PAGOS_VEHICULO.TabIndex = 12
        ' 
        ' COLOR_VEHICULO
        ' 
        COLOR_VEHICULO.FormattingEnabled = True
        COLOR_VEHICULO.Items.AddRange(New Object() {"NEGRO", "BLANCO", "GRIS", "PLATEADO", "AZUL OSCURO", "AZUL", "ROJO"})
        COLOR_VEHICULO.Location = New Point(240, 125)
        COLOR_VEHICULO.Name = "COLOR_VEHICULO"
        COLOR_VEHICULO.Size = New Size(121, 23)
        COLOR_VEHICULO.TabIndex = 11
        ' 
        ' MODELO_VEHICULO
        ' 
        MODELO_VEHICULO.FormattingEnabled = True
        MODELO_VEHICULO.Location = New Point(240, 87)
        MODELO_VEHICULO.Name = "MODELO_VEHICULO"
        MODELO_VEHICULO.Size = New Size(121, 23)
        MODELO_VEHICULO.TabIndex = 10
        ' 
        ' MARCA_VEHICULO
        ' 
        MARCA_VEHICULO.FormattingEnabled = True
        MARCA_VEHICULO.Location = New Point(240, 48)
        MARCA_VEHICULO.Name = "MARCA_VEHICULO"
        MARCA_VEHICULO.Size = New Size(121, 23)
        MARCA_VEHICULO.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13F)
        Label7.Location = New Point(3, 165)
        Label7.Name = "Label7"
        Label7.Size = New Size(175, 25)
        Label7.TabIndex = 8
        Label7.Text = "METODOS DE PAGO"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13F)
        Label8.Location = New Point(3, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 25)
        Label8.TabIndex = 7
        Label8.Text = "COLOR:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13F)
        Label9.Location = New Point(3, 85)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 25)
        Label9.TabIndex = 6
        Label9.Text = "MODELO:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13F)
        Label10.Location = New Point(3, 46)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 25)
        Label10.TabIndex = 5
        Label10.Text = "MARCA:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(COMPRAR)
        TabPage2.Controls.Add(PATENTE_COMPRADOR)
        TabPage2.Controls.Add(PRECIO_COMPRA)
        TabPage2.Controls.Add(MODELO_COMPRA)
        TabPage2.Controls.Add(PROPIETARIO_VEHICULO)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(COLOR_COMPRA)
        TabPage2.Controls.Add(MARCA_COMPRA)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label11)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(793, 339)
        TabPage2.TabIndex = 1
        TabPage2.Text = "COMPRA"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' COMPRAR
        ' 
        COMPRAR.Location = New Point(668, 268)
        COMPRAR.Name = "COMPRAR"
        COMPRAR.Size = New Size(95, 46)
        COMPRAR.TabIndex = 28
        COMPRAR.Text = "COMPRAR"
        COMPRAR.UseVisualStyleBackColor = True
        ' 
        ' PATENTE_COMPRADOR
        ' 
        PATENTE_COMPRADOR.Location = New Point(150, 209)
        PATENTE_COMPRADOR.Name = "PATENTE_COMPRADOR"
        PATENTE_COMPRADOR.Size = New Size(119, 23)
        PATENTE_COMPRADOR.TabIndex = 27
        ' 
        ' PRECIO_COMPRA
        ' 
        PRECIO_COMPRA.Location = New Point(150, 251)
        PRECIO_COMPRA.Name = "PRECIO_COMPRA"
        PRECIO_COMPRA.Size = New Size(119, 23)
        PRECIO_COMPRA.TabIndex = 26
        ' 
        ' MODELO_COMPRA
        ' 
        MODELO_COMPRA.Location = New Point(150, 124)
        MODELO_COMPRA.Name = "MODELO_COMPRA"
        MODELO_COMPRA.Size = New Size(121, 23)
        MODELO_COMPRA.TabIndex = 25
        ' 
        ' PROPIETARIO_VEHICULO
        ' 
        PROPIETARIO_VEHICULO.Location = New Point(150, 49)
        PROPIETARIO_VEHICULO.Name = "PROPIETARIO_VEHICULO"
        PROPIETARIO_VEHICULO.Size = New Size(119, 23)
        PROPIETARIO_VEHICULO.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 13F)
        Label13.Location = New Point(8, 248)
        Label13.Name = "Label13"
        Label13.Size = New Size(76, 25)
        Label13.TabIndex = 23
        Label13.Text = "PRECIO:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13F)
        Label14.Location = New Point(8, 206)
        Label14.Name = "Label14"
        Label14.Size = New Size(85, 25)
        Label14.TabIndex = 22
        Label14.Text = "PATENTE:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13F)
        Label12.Location = New Point(303, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(183, 25)
        Label12.TabIndex = 21
        Label12.Text = "COMPRA VEHICULOS"
        ' 
        ' COLOR_COMPRA
        ' 
        COLOR_COMPRA.FormattingEnabled = True
        COLOR_COMPRA.Location = New Point(150, 169)
        COLOR_COMPRA.Name = "COLOR_COMPRA"
        COLOR_COMPRA.Size = New Size(121, 23)
        COLOR_COMPRA.TabIndex = 20
        ' 
        ' MARCA_COMPRA
        ' 
        MARCA_COMPRA.FormattingEnabled = True
        MARCA_COMPRA.Location = New Point(150, 89)
        MARCA_COMPRA.Name = "MARCA_COMPRA"
        MARCA_COMPRA.Size = New Size(121, 23)
        MARCA_COMPRA.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F)
        Label4.Location = New Point(8, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 25)
        Label4.TabIndex = 16
        Label4.Text = "COLOR:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13F)
        Label5.Location = New Point(8, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 25)
        Label5.TabIndex = 15
        Label5.Text = "MODELO:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F)
        Label6.Location = New Point(8, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 25)
        Label6.TabIndex = 14
        Label6.Text = "MARCA:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 13F)
        Label11.Location = New Point(8, 47)
        Label11.Name = "Label11"
        Label11.Size = New Size(125, 25)
        Label11.TabIndex = 13
        Label11.Text = "PROPIETARIO:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(HISTORIAL_VENTA)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(793, 339)
        TabPage3.TabIndex = 2
        TabPage3.Text = "HISTORIAL DE VENTA"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' HISTORIAL_VENTA
        ' 
        HISTORIAL_VENTA.AllowUserToOrderColumns = True
        HISTORIAL_VENTA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HISTORIAL_VENTA.Columns.AddRange(New DataGridViewColumn() {MARCA_V, MODELO_V, COLOR_V, PRECIO_V})
        HISTORIAL_VENTA.Dock = DockStyle.Fill
        HISTORIAL_VENTA.Location = New Point(3, 3)
        HISTORIAL_VENTA.Name = "HISTORIAL_VENTA"
        HISTORIAL_VENTA.Size = New Size(787, 333)
        HISTORIAL_VENTA.TabIndex = 0
        ' 
        ' MARCA_V
        ' 
        MARCA_V.HeaderText = "MARCA"
        MARCA_V.Name = "MARCA_V"
        ' 
        ' MODELO_V
        ' 
        MODELO_V.HeaderText = "MODELO"
        MODELO_V.Name = "MODELO_V"
        ' 
        ' COLOR_V
        ' 
        COLOR_V.HeaderText = "COLOR"
        COLOR_V.Name = "COLOR_V"
        ' 
        ' PRECIO_V
        ' 
        PRECIO_V.HeaderText = "PRECIO"
        PRECIO_V.Name = "PRECIO_V"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(DataGridView2)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(793, 339)
        TabPage4.TabIndex = 3
        TabPage4.Text = "HISTORIAL DE COMPRA"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToOrderColumns = True
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {PROPIETARIO_C, MARCA_C, MODELO_C, COLOR_C, PATENTE_C})
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.Location = New Point(3, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(787, 333)
        DataGridView2.TabIndex = 1
        ' 
        ' PROPIETARIO_C
        ' 
        PROPIETARIO_C.HeaderText = "PROPIETARIO"
        PROPIETARIO_C.Name = "PROPIETARIO_C"
        ' 
        ' MARCA_C
        ' 
        MARCA_C.HeaderText = "MARCA"
        MARCA_C.Name = "MARCA_C"
        ' 
        ' MODELO_C
        ' 
        MODELO_C.HeaderText = "MODELO"
        MODELO_C.Name = "MODELO_C"
        ' 
        ' COLOR_C
        ' 
        COLOR_C.HeaderText = "COLOR"
        COLOR_C.Name = "COLOR_C"
        ' 
        ' PATENTE_C
        ' 
        PATENTE_C.HeaderText = "PATENTE"
        PATENTE_C.Name = "PATENTE_C"
        ' 
        ' FECHA
        ' 
        FECHA.Location = New Point(577, 17)
        FECHA.Name = "FECHA"
        FECHA.Size = New Size(217, 23)
        FECHA.TabIndex = 5
        ' 
        ' salirB
        ' 
        salirB.Location = New Point(693, 412)
        salirB.Name = "salirB"
        salirB.Size = New Size(95, 35)
        salirB.TabIndex = 0
        salirB.Text = "SALIR"
        salirB.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI Semibold", 13F)
        Label1.Location = New Point(4, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 25)
        Label1.TabIndex = 1
        Label1.Text = "CONCESIONARIA DE VEHICULOS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(FECHA)
        Controls.Add(salirB)
        Controls.Add(HISTORIAL_COMPRA)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        HISTORIAL_COMPRA.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(HISTORIAL_VENTA, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HISTORIAL_COMPRA As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents salirB As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents HISTORIAL_VENTA As DataGridView
    Friend WithEvents MARCA_V As DataGridViewTextBoxColumn
    Friend WithEvents MODELO_V As DataGridViewTextBoxColumn
    Friend WithEvents COLOR_V As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_V As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PROPIETARIO_C As DataGridViewTextBoxColumn
    Friend WithEvents MARCA_C As DataGridViewTextBoxColumn
    Friend WithEvents MODELO_C As DataGridViewTextBoxColumn
    Friend WithEvents COLOR_C As DataGridViewTextBoxColumn
    Friend WithEvents PATENTE_C As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TELEFONO_C As Label
    Friend WithEvents CORREO_C As Label
    Friend WithEvents APELLIDO_C As Label
    Friend WithEvents NOMBRE_C As Label
    Friend WithEvents FECHA As DateTimePicker
    Friend WithEvents TELEFONO_COMPRADOR As TextBox
    Friend WithEvents CORREO_COMPRADOR As TextBox
    Friend WithEvents APELLIDO_COMPRADOR As TextBox
    Friend WithEvents NOMBRE_COMPRADOR As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PAGOS_VEHICULO As ComboBox
    Friend WithEvents COLOR_VEHICULO As ComboBox
    Friend WithEvents MODELO_VEHICULO As ComboBox
    Friend WithEvents MARCA_VEHICULO As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents COLOR_COMPRA As ComboBox
    Friend WithEvents MARCA_COMPRA As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents COMPRAR As Button
    Friend WithEvents PATENTE_COMPRADOR As TextBox
    Friend WithEvents PRECIO_COMPRA As TextBox
    Friend WithEvents MODELO_COMPRA As TextBox
    Friend WithEvents PROPIETARIO_VEHICULO As TextBox
    Friend WithEvents PRECIO_VEHICULO As Label
    Friend WithEvents CONFIRMAR As Button
    Friend WithEvents TextBoxprecio As TextBox

End Class
