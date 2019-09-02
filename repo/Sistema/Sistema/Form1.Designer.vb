<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnConsultaVehiculos = New System.Windows.Forms.Button()
        Me.btnConsultaInventario = New System.Windows.Forms.Button()
        Me.btnIngresoVehiculos = New System.Windows.Forms.Button()
        Me.dgvPrueba = New System.Windows.Forms.DataGridView()
        Me.pnlMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Linen
        Me.pnlMenu.Controls.Add(Me.btnIngresoVehiculos)
        Me.pnlMenu.Controls.Add(Me.btnConsultaInventario)
        Me.pnlMenu.Controls.Add(Me.btnConsultaVehiculos)
        Me.pnlMenu.Controls.Add(Me.Panel2)
        Me.pnlMenu.Controls.Add(Me.lblMenu)
        Me.pnlMenu.Location = New System.Drawing.Point(-2, -1)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(234, 503)
        Me.pnlMenu.TabIndex = 0
        '
        'lblMenu
        '
        Me.lblMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMenu.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(3, 10)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(228, 32)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menú"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Sistema.My.Resources.Resources.t1_fondo2
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(237, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 503)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = Global.Sistema.My.Resources.Resources.t1_fondo2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.dgvPrueba)
        Me.Panel3.Location = New System.Drawing.Point(233, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 503)
        Me.Panel3.TabIndex = 2
        '
        'btnConsultaVehiculos
        '
        Me.btnConsultaVehiculos.BackgroundImage = Global.Sistema.My.Resources.Resources.t1_fondo2
        Me.btnConsultaVehiculos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConsultaVehiculos.Location = New System.Drawing.Point(3, 288)
        Me.btnConsultaVehiculos.Name = "btnConsultaVehiculos"
        Me.btnConsultaVehiculos.Size = New System.Drawing.Size(231, 38)
        Me.btnConsultaVehiculos.TabIndex = 2
        Me.btnConsultaVehiculos.Text = "Consulta de vehículos"
        Me.btnConsultaVehiculos.UseVisualStyleBackColor = True
        '
        'btnConsultaInventario
        '
        Me.btnConsultaInventario.BackgroundImage = Global.Sistema.My.Resources.Resources.t1_fondo2
        Me.btnConsultaInventario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConsultaInventario.Location = New System.Drawing.Point(3, 348)
        Me.btnConsultaInventario.Name = "btnConsultaInventario"
        Me.btnConsultaInventario.Size = New System.Drawing.Size(231, 38)
        Me.btnConsultaInventario.TabIndex = 3
        Me.btnConsultaInventario.Text = "Consulta de inventario"
        Me.btnConsultaInventario.UseVisualStyleBackColor = True
        '
        'btnIngresoVehiculos
        '
        Me.btnIngresoVehiculos.BackgroundImage = Global.Sistema.My.Resources.Resources.t1_fondo2
        Me.btnIngresoVehiculos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIngresoVehiculos.Location = New System.Drawing.Point(3, 88)
        Me.btnIngresoVehiculos.Name = "btnIngresoVehiculos"
        Me.btnIngresoVehiculos.Size = New System.Drawing.Size(231, 38)
        Me.btnIngresoVehiculos.TabIndex = 4
        Me.btnIngresoVehiculos.Text = "Ingreso de vehículos"
        Me.btnIngresoVehiculos.UseVisualStyleBackColor = True
        '
        'dgvPrueba
        '
        Me.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrueba.Location = New System.Drawing.Point(2, 3)
        Me.dgvPrueba.Name = "dgvPrueba"
        Me.dgvPrueba.Size = New System.Drawing.Size(522, 224)
        Me.dgvPrueba.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "Form1"
        Me.Text = "Sistema"
        Me.pnlMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnConsultaVehiculos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnIngresoVehiculos As Button
    Friend WithEvents btnConsultaInventario As Button
    Friend WithEvents dgvPrueba As DataGridView
End Class
