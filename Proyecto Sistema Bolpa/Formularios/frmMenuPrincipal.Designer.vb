<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.timMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.timOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenuDesplegable = New System.Windows.Forms.Panel()
        Me.btnMenuDesplegable = New System.Windows.Forms.Button()
        Me.pnlFormulario = New System.Windows.Forms.Panel()
        Me.pnlMenuDesplegable.SuspendLayout()
        Me.SuspendLayout()
        '
        'timMostrar
        '
        Me.timMostrar.Interval = 1
        '
        'timOcultar
        '
        Me.timOcultar.Interval = 1
        '
        'pnlMenuDesplegable
        '
        Me.pnlMenuDesplegable.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnlMenuDesplegable.Controls.Add(Me.btnMenuDesplegable)
        Me.pnlMenuDesplegable.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuDesplegable.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuDesplegable.Name = "pnlMenuDesplegable"
        Me.pnlMenuDesplegable.Size = New System.Drawing.Size(80, 681)
        Me.pnlMenuDesplegable.TabIndex = 1
        '
        'btnMenuDesplegable
        '
        Me.btnMenuDesplegable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuDesplegable.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMenuDesplegable.BackgroundImage = CType(resources.GetObject("btnMenuDesplegable.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuDesplegable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenuDesplegable.FlatAppearance.BorderSize = 0
        Me.btnMenuDesplegable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuDesplegable.Location = New System.Drawing.Point(20, 12)
        Me.btnMenuDesplegable.Name = "btnMenuDesplegable"
        Me.btnMenuDesplegable.Size = New System.Drawing.Size(49, 42)
        Me.btnMenuDesplegable.TabIndex = 0
        Me.btnMenuDesplegable.UseVisualStyleBackColor = False
        '
        'pnlFormulario
        '
        Me.pnlFormulario.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFormulario.Location = New System.Drawing.Point(80, 0)
        Me.pnlFormulario.Name = "pnlFormulario"
        Me.pnlFormulario.Size = New System.Drawing.Size(1184, 681)
        Me.pnlFormulario.TabIndex = 2
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pnlFormulario)
        Me.Controls.Add(Me.pnlMenuDesplegable)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenuDesplegable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timMostrar As Timer
    Friend WithEvents timOcultar As Timer
    Friend WithEvents pnlMenuDesplegable As Panel
    Friend WithEvents btnMenuDesplegable As Button
    Friend WithEvents pnlFormulario As Panel
End Class
