<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_dig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_selectFolder = New System.Windows.Forms.Button()
        Me.tx_path = New System.Windows.Forms.TextBox()
        Me.lb_path = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_dig
        '
        Me.btn_dig.Enabled = False
        Me.btn_dig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dig.Location = New System.Drawing.Point(182, 140)
        Me.btn_dig.Name = "btn_dig"
        Me.btn_dig.Size = New System.Drawing.Size(100, 44)
        Me.btn_dig.TabIndex = 0
        Me.btn_dig.Text = "Dig"
        Me.btn_dig.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a folder path"
        '
        'btn_selectFolder
        '
        Me.btn_selectFolder.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectFolder.Location = New System.Drawing.Point(205, 33)
        Me.btn_selectFolder.Name = "btn_selectFolder"
        Me.btn_selectFolder.Size = New System.Drawing.Size(56, 23)
        Me.btn_selectFolder.TabIndex = 2
        Me.btn_selectFolder.Text = "..."
        Me.btn_selectFolder.UseVisualStyleBackColor = True
        '
        'tx_path
        '
        Me.tx_path.Enabled = False
        Me.tx_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_path.Location = New System.Drawing.Point(86, 83)
        Me.tx_path.Name = "tx_path"
        Me.tx_path.Size = New System.Drawing.Size(349, 22)
        Me.tx_path.TabIndex = 3
        '
        'lb_path
        '
        Me.lb_path.AutoSize = True
        Me.lb_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_path.Location = New System.Drawing.Point(33, 81)
        Me.lb_path.Name = "lb_path"
        Me.lb_path.Size = New System.Drawing.Size(47, 24)
        Me.lb_path.TabIndex = 4
        Me.lb_path.Text = "Path"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 210)
        Me.Controls.Add(Me.lb_path)
        Me.Controls.Add(Me.tx_path)
        Me.Controls.Add(Me.btn_selectFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_dig)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Select path"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_dig As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_selectFolder As Button
    Friend WithEvents tx_path As TextBox
    Friend WithEvents lb_path As Label
End Class
