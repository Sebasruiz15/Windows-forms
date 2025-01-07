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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbllote = New System.Windows.Forms.Label()
        Me.lblNotas = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NotasDE = New System.Windows.Forms.ComboBox()
        Me.ObserTxt = New System.Windows.Forms.TextBox()
        Me.lblobservaciones = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pass = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtdefecto1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.ablaql = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtunidades1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextRe5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextAc5 = New System.Windows.Forms.TextBox()
        Me.TextRe4 = New System.Windows.Forms.TextBox()
        Me.TextAc4 = New System.Windows.Forms.TextBox()
        Me.TextRe3 = New System.Windows.Forms.TextBox()
        Me.TextAc3 = New System.Windows.Forms.TextBox()
        Me.TextRe2 = New System.Windows.Forms.TextBox()
        Me.TextAc2 = New System.Windows.Forms.TextBox()
        Me.TextRe1 = New System.Windows.Forms.TextBox()
        Me.TextAc1 = New System.Windows.Forms.TextBox()
        Me.TxTiposAql5 = New System.Windows.Forms.TextBox()
        Me.TxTiposAql4 = New System.Windows.Forms.TextBox()
        Me.TxTiposAql3 = New System.Windows.Forms.TextBox()
        Me.TxTiposAql2 = New System.Windows.Forms.TextBox()
        Me.TxTiposAql1 = New System.Windows.Forms.TextBox()
        Me.Txtunidades5 = New System.Windows.Forms.TextBox()
        Me.Txtunidades4 = New System.Windows.Forms.TextBox()
        Me.Txtunidades3 = New System.Windows.Forms.TextBox()
        Me.Txtunidades2 = New System.Windows.Forms.TextBox()
        Me.Txtdefecto5 = New System.Windows.Forms.TextBox()
        Me.Txtdefecto4 = New System.Windows.Forms.TextBox()
        Me.Txtdefecto3 = New System.Windows.Forms.TextBox()
        Me.Txtdefecto2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(629, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar Sap"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'lbllote
        '
        Me.lbllote.AutoSize = True
        Me.lbllote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbllote.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllote.Location = New System.Drawing.Point(21, 126)
        Me.lbllote.Name = "lbllote"
        Me.lbllote.Size = New System.Drawing.Size(45, 21)
        Me.lbllote.TabIndex = 4
        Me.lbllote.Text = "Lote"
        '
        'lblNotas
        '
        Me.lblNotas.AutoSize = True
        Me.lblNotas.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotas.Location = New System.Drawing.Point(6, 384)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.Size = New System.Drawing.Size(279, 19)
        Me.lblNotas.TabIndex = 5
        Me.lblNotas.Text = "¿Cuál es la NOTA para este DE?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "10941908"
        '
        'NotasDE
        '
        Me.NotasDE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotasDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NotasDE.ForeColor = System.Drawing.Color.Black
        Me.NotasDE.FormattingEnabled = True
        Me.NotasDE.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.NotasDE.Items.AddRange(New Object() {"SE DEDEN DESCONTAR 20 UNIDADES PARA FUNCIONALES", "Se aprueba el material por concesión teniendo en cuenta los lineamientos de proce" &
                "dimiento", "Se rechazan las unidades reportadas en este informe que se encuentran existentes " &
                "en el inventario", "Se aprueba con Observaciòn con autorizaciòn de I+D o cliente"})
        Me.NotasDE.Location = New System.Drawing.Point(291, 382)
        Me.NotasDE.Name = "NotasDE"
        Me.NotasDE.Size = New System.Drawing.Size(479, 21)
        Me.NotasDE.TabIndex = 7
        '
        'ObserTxt
        '
        Me.ObserTxt.Location = New System.Drawing.Point(17, 461)
        Me.ObserTxt.Multiline = True
        Me.ObserTxt.Name = "ObserTxt"
        Me.ObserTxt.Size = New System.Drawing.Size(337, 38)
        Me.ObserTxt.TabIndex = 8
        '
        'lblobservaciones
        '
        Me.lblobservaciones.AutoSize = True
        Me.lblobservaciones.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobservaciones.Location = New System.Drawing.Point(21, 427)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(130, 21)
        Me.lblobservaciones.TabIndex = 9
        Me.lblobservaciones.Text = "Observaciones"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(377, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 22)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Buscar Sap"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(62, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(85, 20)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = "gllano"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(62, 53)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(85, 20)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.Text = "Enerodel2025*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "User"
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(10, 53)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(30, 16)
        Me.Pass.TabIndex = 16
        Me.Pass.Text = "Pass"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DateTimePicker1.Location = New System.Drawing.Point(556, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker1.TabIndex = 17
        Me.DateTimePicker1.Value = New Date(2025, 1, 7, 10, 35, 39, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prueba4.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(612, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Pass)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 81)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(369, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "RE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "AC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 32)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Unidades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defectousas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Defecto"
        '
        'Txtdefecto1
        '
        Me.Txtdefecto1.Location = New System.Drawing.Point(13, 69)
        Me.Txtdefecto1.Multiline = True
        Me.Txtdefecto1.Name = "Txtdefecto1"
        Me.Txtdefecto1.Size = New System.Drawing.Size(134, 20)
        Me.Txtdefecto1.TabIndex = 29
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(426, 147)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(426, 69)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 32
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(426, 95)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 33
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(426, 120)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 34
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(426, 172)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox6.TabIndex = 35
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'ablaql
        '
        Me.ablaql.AutoSize = True
        Me.ablaql.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ablaql.Font = New System.Drawing.Font("Microsoft Yi Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ablaql.Location = New System.Drawing.Point(256, 49)
        Me.ablaql.Name = "ablaql"
        Me.ablaql.Size = New System.Drawing.Size(66, 15)
        Me.ablaql.TabIndex = 36
        Me.ablaql.Text = "Tipo AQL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(410, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Aplica"
        '
        'Txtunidades1
        '
        Me.Txtunidades1.Location = New System.Drawing.Point(157, 68)
        Me.Txtunidades1.Multiline = True
        Me.Txtunidades1.Name = "Txtunidades1"
        Me.Txtunidades1.Size = New System.Drawing.Size(62, 20)
        Me.Txtunidades1.TabIndex = 51
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.TextRe5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextAc5)
        Me.GroupBox2.Controls.Add(Me.TextRe4)
        Me.GroupBox2.Controls.Add(Me.TextAc4)
        Me.GroupBox2.Controls.Add(Me.TextRe3)
        Me.GroupBox2.Controls.Add(Me.TextAc3)
        Me.GroupBox2.Controls.Add(Me.TextRe2)
        Me.GroupBox2.Controls.Add(Me.TextAc2)
        Me.GroupBox2.Controls.Add(Me.TextRe1)
        Me.GroupBox2.Controls.Add(Me.TextAc1)
        Me.GroupBox2.Controls.Add(Me.TxTiposAql5)
        Me.GroupBox2.Controls.Add(Me.TxTiposAql4)
        Me.GroupBox2.Controls.Add(Me.TxTiposAql3)
        Me.GroupBox2.Controls.Add(Me.TxTiposAql2)
        Me.GroupBox2.Controls.Add(Me.TxTiposAql1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txtunidades5)
        Me.GroupBox2.Controls.Add(Me.Txtunidades4)
        Me.GroupBox2.Controls.Add(Me.Txtunidades3)
        Me.GroupBox2.Controls.Add(Me.ablaql)
        Me.GroupBox2.Controls.Add(Me.Txtunidades2)
        Me.GroupBox2.Controls.Add(Me.Txtdefecto5)
        Me.GroupBox2.Controls.Add(Me.Txtdefecto4)
        Me.GroupBox2.Controls.Add(Me.Txtdefecto3)
        Me.GroupBox2.Controls.Add(Me.Txtdefecto2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.Txtunidades1)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.Txtdefecto1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 215)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBox2.Items.AddRange(New Object() {"Z01", "08", "09", "Z055", "Z04", "Z088"})
        Me.ComboBox2.Location = New System.Drawing.Point(254, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(47, 21)
        Me.ComboBox2.TabIndex = 59
        '
        'TextRe5
        '
        Me.TextRe5.Location = New System.Drawing.Point(369, 172)
        Me.TextRe5.Multiline = True
        Me.TextRe5.Name = "TextRe5"
        Me.TextRe5.Size = New System.Drawing.Size(31, 20)
        Me.TextRe5.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Cl.Insp"
        '
        'TextAc5
        '
        Me.TextAc5.Location = New System.Drawing.Point(332, 172)
        Me.TextAc5.Multiline = True
        Me.TextAc5.Name = "TextAc5"
        Me.TextAc5.Size = New System.Drawing.Size(31, 20)
        Me.TextAc5.TabIndex = 78
        '
        'TextRe4
        '
        Me.TextRe4.Location = New System.Drawing.Point(369, 147)
        Me.TextRe4.Multiline = True
        Me.TextRe4.Name = "TextRe4"
        Me.TextRe4.Size = New System.Drawing.Size(31, 20)
        Me.TextRe4.TabIndex = 77
        '
        'TextAc4
        '
        Me.TextAc4.Location = New System.Drawing.Point(332, 147)
        Me.TextAc4.Multiline = True
        Me.TextAc4.Name = "TextAc4"
        Me.TextAc4.Size = New System.Drawing.Size(31, 20)
        Me.TextAc4.TabIndex = 76
        '
        'TextRe3
        '
        Me.TextRe3.Location = New System.Drawing.Point(369, 120)
        Me.TextRe3.Multiline = True
        Me.TextRe3.Name = "TextRe3"
        Me.TextRe3.Size = New System.Drawing.Size(31, 20)
        Me.TextRe3.TabIndex = 75
        '
        'TextAc3
        '
        Me.TextAc3.Location = New System.Drawing.Point(332, 120)
        Me.TextAc3.Multiline = True
        Me.TextAc3.Name = "TextAc3"
        Me.TextAc3.Size = New System.Drawing.Size(31, 20)
        Me.TextAc3.TabIndex = 74
        '
        'TextRe2
        '
        Me.TextRe2.Location = New System.Drawing.Point(369, 94)
        Me.TextRe2.Multiline = True
        Me.TextRe2.Name = "TextRe2"
        Me.TextRe2.Size = New System.Drawing.Size(31, 20)
        Me.TextRe2.TabIndex = 73
        '
        'TextAc2
        '
        Me.TextAc2.Location = New System.Drawing.Point(332, 94)
        Me.TextAc2.Multiline = True
        Me.TextAc2.Name = "TextAc2"
        Me.TextAc2.Size = New System.Drawing.Size(31, 20)
        Me.TextAc2.TabIndex = 72
        '
        'TextRe1
        '
        Me.TextRe1.Location = New System.Drawing.Point(369, 69)
        Me.TextRe1.Multiline = True
        Me.TextRe1.Name = "TextRe1"
        Me.TextRe1.Size = New System.Drawing.Size(31, 20)
        Me.TextRe1.TabIndex = 71
        '
        'TextAc1
        '
        Me.TextAc1.Location = New System.Drawing.Point(332, 69)
        Me.TextAc1.Multiline = True
        Me.TextAc1.Name = "TextAc1"
        Me.TextAc1.Size = New System.Drawing.Size(31, 20)
        Me.TextAc1.TabIndex = 70
        '
        'TxTiposAql5
        '
        Me.TxTiposAql5.Location = New System.Drawing.Point(259, 172)
        Me.TxTiposAql5.Multiline = True
        Me.TxTiposAql5.Name = "TxTiposAql5"
        Me.TxTiposAql5.Size = New System.Drawing.Size(62, 20)
        Me.TxTiposAql5.TabIndex = 69
        '
        'TxTiposAql4
        '
        Me.TxTiposAql4.Location = New System.Drawing.Point(259, 147)
        Me.TxTiposAql4.Multiline = True
        Me.TxTiposAql4.Name = "TxTiposAql4"
        Me.TxTiposAql4.Size = New System.Drawing.Size(62, 20)
        Me.TxTiposAql4.TabIndex = 68
        '
        'TxTiposAql3
        '
        Me.TxTiposAql3.Location = New System.Drawing.Point(259, 120)
        Me.TxTiposAql3.Multiline = True
        Me.TxTiposAql3.Name = "TxTiposAql3"
        Me.TxTiposAql3.Size = New System.Drawing.Size(62, 20)
        Me.TxTiposAql3.TabIndex = 67
        '
        'TxTiposAql2
        '
        Me.TxTiposAql2.Location = New System.Drawing.Point(259, 94)
        Me.TxTiposAql2.Multiline = True
        Me.TxTiposAql2.Name = "TxTiposAql2"
        Me.TxTiposAql2.Size = New System.Drawing.Size(62, 20)
        Me.TxTiposAql2.TabIndex = 66
        '
        'TxTiposAql1
        '
        Me.TxTiposAql1.Location = New System.Drawing.Point(259, 68)
        Me.TxTiposAql1.Multiline = True
        Me.TxTiposAql1.Name = "TxTiposAql1"
        Me.TxTiposAql1.Size = New System.Drawing.Size(62, 20)
        Me.TxTiposAql1.TabIndex = 65
        '
        'Txtunidades5
        '
        Me.Txtunidades5.Location = New System.Drawing.Point(157, 172)
        Me.Txtunidades5.Multiline = True
        Me.Txtunidades5.Name = "Txtunidades5"
        Me.Txtunidades5.Size = New System.Drawing.Size(62, 20)
        Me.Txtunidades5.TabIndex = 64
        '
        'Txtunidades4
        '
        Me.Txtunidades4.Location = New System.Drawing.Point(157, 147)
        Me.Txtunidades4.Multiline = True
        Me.Txtunidades4.Name = "Txtunidades4"
        Me.Txtunidades4.Size = New System.Drawing.Size(62, 20)
        Me.Txtunidades4.TabIndex = 63
        '
        'Txtunidades3
        '
        Me.Txtunidades3.Location = New System.Drawing.Point(157, 120)
        Me.Txtunidades3.Multiline = True
        Me.Txtunidades3.Name = "Txtunidades3"
        Me.Txtunidades3.Size = New System.Drawing.Size(62, 20)
        Me.Txtunidades3.TabIndex = 62
        '
        'Txtunidades2
        '
        Me.Txtunidades2.Location = New System.Drawing.Point(157, 94)
        Me.Txtunidades2.Multiline = True
        Me.Txtunidades2.Name = "Txtunidades2"
        Me.Txtunidades2.Size = New System.Drawing.Size(62, 20)
        Me.Txtunidades2.TabIndex = 61
        '
        'Txtdefecto5
        '
        Me.Txtdefecto5.Location = New System.Drawing.Point(13, 172)
        Me.Txtdefecto5.Multiline = True
        Me.Txtdefecto5.Name = "Txtdefecto5"
        Me.Txtdefecto5.Size = New System.Drawing.Size(134, 20)
        Me.Txtdefecto5.TabIndex = 60
        '
        'Txtdefecto4
        '
        Me.Txtdefecto4.Location = New System.Drawing.Point(13, 147)
        Me.Txtdefecto4.Multiline = True
        Me.Txtdefecto4.Name = "Txtdefecto4"
        Me.Txtdefecto4.Size = New System.Drawing.Size(134, 20)
        Me.Txtdefecto4.TabIndex = 59
        '
        'Txtdefecto3
        '
        Me.Txtdefecto3.Location = New System.Drawing.Point(13, 121)
        Me.Txtdefecto3.Multiline = True
        Me.Txtdefecto3.Name = "Txtdefecto3"
        Me.Txtdefecto3.Size = New System.Drawing.Size(134, 20)
        Me.Txtdefecto3.TabIndex = 58
        '
        'Txtdefecto2
        '
        Me.Txtdefecto2.Location = New System.Drawing.Point(13, 95)
        Me.Txtdefecto2.Multiline = True
        Me.Txtdefecto2.Name = "Txtdefecto2"
        Me.Txtdefecto2.Size = New System.Drawing.Size(134, 20)
        Me.Txtdefecto2.TabIndex = 57
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(517, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 21)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(782, 559)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblobservaciones)
        Me.Controls.Add(Me.ObserTxt)
        Me.Controls.Add(Me.NotasDE)
        Me.Controls.Add(Me.lblNotas)
        Me.Controls.Add(Me.lbllote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Análisis FDE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbllote As Label
    Friend WithEvents lblNotas As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NotasDE As ComboBox
    Friend WithEvents ObserTxt As TextBox
    Friend WithEvents lblobservaciones As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Pass As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtdefecto1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents ablaql As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtunidades1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextAc1 As TextBox
    Friend WithEvents TxTiposAql5 As TextBox
    Friend WithEvents TxTiposAql4 As TextBox
    Friend WithEvents TxTiposAql3 As TextBox
    Friend WithEvents TxTiposAql2 As TextBox
    Friend WithEvents TxTiposAql1 As TextBox
    Friend WithEvents Txtunidades5 As TextBox
    Friend WithEvents Txtunidades4 As TextBox
    Friend WithEvents Txtunidades3 As TextBox
    Friend WithEvents Txtunidades2 As TextBox
    Friend WithEvents Txtdefecto5 As TextBox
    Friend WithEvents Txtdefecto4 As TextBox
    Friend WithEvents Txtdefecto3 As TextBox
    Friend WithEvents Txtdefecto2 As TextBox
    Friend WithEvents TextRe5 As TextBox
    Friend WithEvents TextAc5 As TextBox
    Friend WithEvents TextRe4 As TextBox
    Friend WithEvents TextAc4 As TextBox
    Friend WithEvents TextRe3 As TextBox
    Friend WithEvents TextAc3 As TextBox
    Friend WithEvents TextRe2 As TextBox
    Friend WithEvents TextAc2 As TextBox
    Friend WithEvents TextRe1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
End Class
