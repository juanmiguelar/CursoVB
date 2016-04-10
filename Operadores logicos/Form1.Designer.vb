<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnMayorQue = New System.Windows.Forms.Button()
        Me.btnMenorQue = New System.Windows.Forms.Button()
        Me.btnMayorIgual = New System.Windows.Forms.Button()
        Me.btnMenorIgual = New System.Windows.Forms.Button()
        Me.btnDiferente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(13, 25)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 0
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(163, 24)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 1
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(13, 78)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(75, 23)
        Me.btnIgual.TabIndex = 2
        Me.btnIgual.Text = "Igual"
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnMayorQue
        '
        Me.btnMayorQue.Location = New System.Drawing.Point(13, 118)
        Me.btnMayorQue.Name = "btnMayorQue"
        Me.btnMayorQue.Size = New System.Drawing.Size(75, 23)
        Me.btnMayorQue.TabIndex = 3
        Me.btnMayorQue.Text = "Mayor que"
        Me.btnMayorQue.UseVisualStyleBackColor = True
        '
        'btnMenorQue
        '
        Me.btnMenorQue.Location = New System.Drawing.Point(13, 161)
        Me.btnMenorQue.Name = "btnMenorQue"
        Me.btnMenorQue.Size = New System.Drawing.Size(75, 23)
        Me.btnMenorQue.TabIndex = 4
        Me.btnMenorQue.Text = "Menor que"
        Me.btnMenorQue.UseVisualStyleBackColor = True
        '
        'btnMayorIgual
        '
        Me.btnMayorIgual.Location = New System.Drawing.Point(163, 77)
        Me.btnMayorIgual.Name = "btnMayorIgual"
        Me.btnMayorIgual.Size = New System.Drawing.Size(100, 23)
        Me.btnMayorIgual.TabIndex = 5
        Me.btnMayorIgual.Text = "Mayor o igual"
        Me.btnMayorIgual.UseVisualStyleBackColor = True
        '
        'btnMenorIgual
        '
        Me.btnMenorIgual.Location = New System.Drawing.Point(163, 117)
        Me.btnMenorIgual.Name = "btnMenorIgual"
        Me.btnMenorIgual.Size = New System.Drawing.Size(109, 23)
        Me.btnMenorIgual.TabIndex = 6
        Me.btnMenorIgual.Text = "Menor o igual"
        Me.btnMenorIgual.UseVisualStyleBackColor = True
        '
        'btnDiferente
        '
        Me.btnDiferente.Location = New System.Drawing.Point(163, 161)
        Me.btnDiferente.Name = "btnDiferente"
        Me.btnDiferente.Size = New System.Drawing.Size(75, 23)
        Me.btnDiferente.TabIndex = 7
        Me.btnDiferente.Text = "Diferente"
        Me.btnDiferente.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnDiferente)
        Me.Controls.Add(Me.btnMenorIgual)
        Me.Controls.Add(Me.btnMayorIgual)
        Me.Controls.Add(Me.btnMenorQue)
        Me.Controls.Add(Me.btnMayorQue)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnMayorQue As Button
    Friend WithEvents btnMenorQue As Button
    Friend WithEvents btnMayorIgual As Button
    Friend WithEvents btnMenorIgual As Button
    Friend WithEvents btnDiferente As Button
End Class
