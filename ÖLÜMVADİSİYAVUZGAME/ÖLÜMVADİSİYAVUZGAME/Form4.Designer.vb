<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Viner Hand ITC", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(11, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 39)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "YAVUZ GAME"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(861, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 64)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "DİNLEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(699, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(24, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(979, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DOĞRU YOLLARI SEÇEREK ORMANDAN KURTULMAYI BAŞARDIN"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(974, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Yardım Botu Yolda. Onlar Gelene Kadar Biraz Dinlen. Bunu Hak Ettin:)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(233, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 93)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TEBRİKLER"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ÖLÜMVADİSİYAVUZGAME.My.Resources.Resources.Kumsal
        Me.ClientSize = New System.Drawing.Size(1057, 553)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "ÖLÜM VADİSİ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
