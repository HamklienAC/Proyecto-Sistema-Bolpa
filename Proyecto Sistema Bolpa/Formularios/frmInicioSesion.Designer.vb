<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
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
        Me.pnlImagen = New System.Windows.Forms.Panel()
        Me.pibLogo = New System.Windows.Forms.PictureBox()
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.linContrasena = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.linUsuario = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblReporte = New System.Windows.Forms.LinkLabel()
        Me.pnlImagen.SuspendLayout()
        CType(Me.pibLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlImagen
        '
        Me.pnlImagen.BackColor = System.Drawing.Color.White
        Me.pnlImagen.Controls.Add(Me.pibLogo)
        Me.pnlImagen.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlImagen.Location = New System.Drawing.Point(0, 0)
        Me.pnlImagen.Name = "pnlImagen"
        Me.pnlImagen.Size = New System.Drawing.Size(334, 150)
        Me.pnlImagen.TabIndex = 9
        '
        'pibLogo
        '
        Me.pibLogo.Image = Global.Proyecto_Sistema_Bolpa.My.Resources.Resources.Logo_Bolpa
        Me.pibLogo.Location = New System.Drawing.Point(12, 14)
        Me.pibLogo.Name = "pibLogo"
        Me.pibLogo.Size = New System.Drawing.Size(310, 123)
        Me.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pibLogo.TabIndex = 0
        Me.pibLogo.TabStop = False
        '
        'pnlControles
        '
        Me.pnlControles.Controls.Add(Me.txtUsuario)
        Me.pnlControles.Controls.Add(Me.btnIngresar)
        Me.pnlControles.Controls.Add(Me.txtContrasena)
        Me.pnlControles.Controls.Add(Me.ShapeContainer1)
        Me.pnlControles.Location = New System.Drawing.Point(12, 181)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(310, 381)
        Me.pnlControles.TabIndex = 10
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(30, 86)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(250, 16)
        Me.txtUsuario.TabIndex = 7
        Me.txtUsuario.Tag = ""
        Me.txtUsuario.Text = "Usuario"
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Location = New System.Drawing.Point(105, 220)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(100, 30)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.White
        Me.txtContrasena.Location = New System.Drawing.Point(30, 166)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(250, 16)
        Me.txtContrasena.TabIndex = 8
        Me.txtContrasena.Text = "Contraseña"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linContrasena, Me.linUsuario})
        Me.ShapeContainer1.Size = New System.Drawing.Size(310, 381)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'linContrasena
        '
        Me.linContrasena.BorderColor = System.Drawing.Color.White
        Me.linContrasena.BorderWidth = 2
        Me.linContrasena.Enabled = False
        Me.linContrasena.Name = "linContrasena"
        Me.linContrasena.X1 = 30
        Me.linContrasena.X2 = 280
        Me.linContrasena.Y1 = 184
        Me.linContrasena.Y2 = 184
        '
        'linUsuario
        '
        Me.linUsuario.BorderColor = System.Drawing.Color.White
        Me.linUsuario.BorderWidth = 2
        Me.linUsuario.Enabled = False
        Me.linUsuario.Name = "linUsuario"
        Me.linUsuario.X1 = 30
        Me.linUsuario.X2 = 280
        Me.linUsuario.Y1 = 103
        Me.linUsuario.Y2 = 103
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporte.LinkColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblReporte.Location = New System.Drawing.Point(12, 582)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(186, 17)
        Me.lblReporte.TabIndex = 11
        Me.lblReporte.TabStop = True
        Me.lblReporte.Text = "¿Has olvidado tú contraseña?"
        '
        'frmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(334, 606)
        Me.Controls.Add(Me.lblReporte)
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.pnlImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInicioSesion"
        Me.pnlImagen.ResumeLayout(False)
        CType(Me.pibLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControles.ResumeLayout(False)
        Me.pnlControles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlImagen As Panel
    Friend WithEvents pibLogo As PictureBox
    Friend WithEvents pnlControles As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblReporte As LinkLabel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents linContrasena As PowerPacks.LineShape
    Friend WithEvents linUsuario As PowerPacks.LineShape
End Class
