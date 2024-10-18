<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(184, 368)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(454, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 394)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 21)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.WhatsApp_Image_2024_10_16_at_10_17_56_AM
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 559)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
