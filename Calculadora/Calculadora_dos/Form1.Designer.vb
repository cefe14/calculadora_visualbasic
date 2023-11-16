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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btnigual = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnsumar = New System.Windows.Forms.Button()
        Me.btnrestar = New System.Windows.Forms.Button()
        Me.btndividir = New System.Windows.Forms.Button()
        Me.btnmultiplicar = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.btnborrartodo = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.lblmuestra = New System.Windows.Forms.TextBox()
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnporcentaje = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnINV = New System.Windows.Forms.Button()
        Me.btnSEN = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnTAN = New System.Windows.Forms.Button()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn0
        '
        Me.btn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn0.Location = New System.Drawing.Point(122, 308)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(53, 30)
        Me.btn0.TabIndex = 0
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Location = New System.Drawing.Point(63, 272)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(53, 30)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Location = New System.Drawing.Point(122, 272)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(53, 30)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Location = New System.Drawing.Point(181, 272)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(53, 30)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btnComa
        '
        Me.btnComa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComa.Location = New System.Drawing.Point(181, 308)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(53, 30)
        Me.btnComa.TabIndex = 4
        Me.btnComa.Text = ","
        Me.btnComa.UseVisualStyleBackColor = True
        '
        'btnigual
        '
        Me.btnigual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnigual.Location = New System.Drawing.Point(240, 308)
        Me.btnigual.Name = "btnigual"
        Me.btnigual.Size = New System.Drawing.Size(53, 30)
        Me.btnigual.TabIndex = 5
        Me.btnigual.Text = "="
        Me.btnigual.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn4.Location = New System.Drawing.Point(63, 236)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(53, 30)
        Me.btn4.TabIndex = 6
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn5.Location = New System.Drawing.Point(122, 236)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(53, 30)
        Me.btn5.TabIndex = 7
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn6.Location = New System.Drawing.Point(181, 236)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(53, 30)
        Me.btn6.TabIndex = 8
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn7.Location = New System.Drawing.Point(63, 200)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(53, 30)
        Me.btn7.TabIndex = 9
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn8.Location = New System.Drawing.Point(122, 200)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(53, 30)
        Me.btn8.TabIndex = 10
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn9.Location = New System.Drawing.Point(181, 200)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(53, 30)
        Me.btn9.TabIndex = 11
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnsumar
        '
        Me.btnsumar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsumar.Location = New System.Drawing.Point(240, 164)
        Me.btnsumar.Name = "btnsumar"
        Me.btnsumar.Size = New System.Drawing.Size(53, 30)
        Me.btnsumar.TabIndex = 12
        Me.btnsumar.Text = "+"
        Me.btnsumar.UseVisualStyleBackColor = True
        '
        'btnrestar
        '
        Me.btnrestar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrestar.Location = New System.Drawing.Point(240, 200)
        Me.btnrestar.Name = "btnrestar"
        Me.btnrestar.Size = New System.Drawing.Size(53, 30)
        Me.btnrestar.TabIndex = 13
        Me.btnrestar.Text = "-"
        Me.btnrestar.UseVisualStyleBackColor = True
        '
        'btndividir
        '
        Me.btndividir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndividir.Location = New System.Drawing.Point(240, 236)
        Me.btndividir.Name = "btndividir"
        Me.btndividir.Size = New System.Drawing.Size(53, 30)
        Me.btndividir.TabIndex = 14
        Me.btndividir.Text = "/"
        Me.btndividir.UseVisualStyleBackColor = True
        '
        'btnmultiplicar
        '
        Me.btnmultiplicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmultiplicar.Location = New System.Drawing.Point(240, 272)
        Me.btnmultiplicar.Name = "btnmultiplicar"
        Me.btnmultiplicar.Size = New System.Drawing.Size(53, 30)
        Me.btnmultiplicar.TabIndex = 15
        Me.btnmultiplicar.Text = "*"
        Me.btnmultiplicar.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.Location = New System.Drawing.Point(63, 164)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(53, 30)
        Me.Button16.TabIndex = 16
        Me.Button16.Text = "CE"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'btnborrartodo
        '
        Me.btnborrartodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrartodo.Location = New System.Drawing.Point(122, 164)
        Me.btnborrartodo.Name = "btnborrartodo"
        Me.btnborrartodo.Size = New System.Drawing.Size(53, 30)
        Me.btnborrartodo.TabIndex = 17
        Me.btnborrartodo.Text = "C"
        Me.btnborrartodo.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisplay.Location = New System.Drawing.Point(63, 90)
        Me.txtdisplay.MaxLength = 17
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(230, 29)
        Me.txtdisplay.TabIndex = 0
        Me.txtdisplay.Text = "0"
        Me.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblmuestra
        '
        Me.lblmuestra.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblmuestra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblmuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmuestra.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblmuestra.Location = New System.Drawing.Point(63, 69)
        Me.lblmuestra.MaxLength = 5
        Me.lblmuestra.Name = "lblmuestra"
        Me.lblmuestra.Size = New System.Drawing.Size(230, 15)
        Me.lblmuestra.TabIndex = 20
        Me.lblmuestra.Text = "0"
        Me.lblmuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(12, 370)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(230, 50)
        Me.Player.TabIndex = 21
        Me.Player.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnStop
        '
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.Location = New System.Drawing.Point(245, 33)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(48, 30)
        Me.btnStop.TabIndex = 22
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(63, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 30)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(152, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 30)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "PAUSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblHora.Location = New System.Drawing.Point(59, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(51, 21)
        Me.lblHora.TabIndex = 25
        Me.lblHora.Text = "hora"
        '
        'btnporcentaje
        '
        Me.btnporcentaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnporcentaje.Location = New System.Drawing.Point(181, 164)
        Me.btnporcentaje.Name = "btnporcentaje"
        Me.btnporcentaje.Size = New System.Drawing.Size(53, 30)
        Me.btnporcentaje.TabIndex = 26
        Me.btnporcentaje.Text = "%"
        Me.btnporcentaje.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(63, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 30)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "+/-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnINV
        '
        Me.btnINV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnINV.Location = New System.Drawing.Point(63, 128)
        Me.btnINV.Name = "btnINV"
        Me.btnINV.Size = New System.Drawing.Size(53, 30)
        Me.btnINV.TabIndex = 28
        Me.btnINV.Text = "INV"
        Me.btnINV.UseVisualStyleBackColor = True
        '
        'btnSEN
        '
        Me.btnSEN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSEN.Location = New System.Drawing.Point(122, 128)
        Me.btnSEN.Name = "btnSEN"
        Me.btnSEN.Size = New System.Drawing.Size(53, 30)
        Me.btnSEN.TabIndex = 29
        Me.btnSEN.Text = "SEN"
        Me.btnSEN.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCos.Location = New System.Drawing.Point(181, 128)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(53, 30)
        Me.btnCos.TabIndex = 30
        Me.btnCos.Text = "COS"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnTAN
        '
        Me.btnTAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTAN.Location = New System.Drawing.Point(240, 128)
        Me.btnTAN.Name = "btnTAN"
        Me.btnTAN.Size = New System.Drawing.Size(53, 30)
        Me.btnTAN.TabIndex = 31
        Me.btnTAN.Text = "TAN"
        Me.btnTAN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 362)
        Me.Controls.Add(Me.btnTAN)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSEN)
        Me.Controls.Add(Me.btnINV)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnporcentaje)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.lblmuestra)
        Me.Controls.Add(Me.btnborrartodo)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.btnmultiplicar)
        Me.Controls.Add(Me.btndividir)
        Me.Controls.Add(Me.btnrestar)
        Me.Controls.Add(Me.btnsumar)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnigual)
        Me.Controls.Add(Me.btnComa)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnComa As Button
    Friend WithEvents btnigual As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnsumar As Button
    Friend WithEvents btnrestar As Button
    Friend WithEvents btndividir As Button
    Friend WithEvents btnmultiplicar As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents btnborrartodo As Button
    Friend WithEvents txtdisplay As TextBox
    Friend WithEvents lblmuestra As TextBox
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStop As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents btnporcentaje As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnINV As Button
    Friend WithEvents btnSEN As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTAN As Button
End Class
