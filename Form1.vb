Imports System.ComponentModel
Imports System.Security.Cryptography
Imports Microsoft.Office.Interop.Excel



Public Class Form1

    ' Variables '
    Dim ExcelApp As New Microsoft.Office.Interop.Excel.Application
    Dim Libro As Workbook
    Dim Hoja1 As Worksheet
    Dim Final As Long

    Dim ExcelWorkbook As Workbook
    Dim ExcelWorksheet As Worksheet
    Dim ExcelRange As Range


    ' Al cargar el formulario, abrimos el archivo Excel '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Abrir el libro Excel '
        'Libro = ExcelApp.Workbooks.Open("\\COMEDFS02\Reporte Muestreo e Inspección\Formatos CCE\FDE\FORM.xlsx")
        'Hoja1 = Libro.Sheets("Hoja1")
    End Sub

    ' Función para obtener la última fila vacía '
    Private Function NReg(ByVal hoja As Worksheet, ByVal columna As Integer) As Long
        Dim ultimaFila As Long
        ultimaFila = hoja.Cells(hoja.Rows.Count, columna).End(XlDirection.xlUp).Row
        Return ultimaFila + 1 ' La siguiente fila vacía '
    End Function

    ' Evento de botón para agregar un registro '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Abrir excel '
        Libro = ExcelApp.Workbooks.Open("\\ comedfs02 \ Control calidad de empaque\REQUISITOS DE GESTION\INFORMACION ACTIVA\Nuevo.xlsx")
        Hoja1 = Libro.Sheets("Hoja1")
        Final = nReg(Hoja1, 1)

        ' Agregar un registro en la nueva fila '
        Hoja1.Cells(Final, 1).Value = TextBox1.Text 'Hace registro del lote

        Hoja1.Cells(Final, 2).Value = DateTimePicker1.Text 'Hace registro de la fecha realizacion DE
        Hoja1.Cells(Final, 3).Value = Txtdefecto1.Text ' Registro Defecto
        Hoja1.Cells(Final, 4).Value = Txtunidades2.Text ' Registro Unidades
        Hoja1.Cells(Final, 5).Value = TxTiposAql5.Text  'Hace resgistro de AQl
        Hoja1.Cells(Final, 6).Value = TextRe1.Text ' Registro AC
        Hoja1.Cells(Final, 7).Value = TextAc1.Text ' Registro RC
        Hoja1.Cells(Final, 8).Value = NotasDE.Text 'Hace registro de las observaciones  
        Hoja1.Cells(Final, 9).Value = ObserTxt.Text 'Hace registro de la nota para DE



        MsgBox("Registro agregado a la fila " & Final)
        Libro.Save()
        Libro.Close()
    End Sub

    ' Evento de botón para guardar el archivo y cerrar Excel '
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Guardar el archivo '
        Libro.Save()

        MsgBox("Los cambios han sido guardados en " & Libro.Name)
        ' Cerrar Excel '
        ExcelApp.Quit()
        ' Limpiar referencias '
        Libro = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Validar si los campos de usuario y contraseña están vacíos
        If String.IsNullOrEmpty(TextBox4.Text) Or String.IsNullOrEmpty(TextBox5.Text) Then
            MessageBox.Show("Por favor, ingrese tanto el usuario como la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' No continuar si los campos están vacíos
        End If

        Try
            Dim SAPguiApp As Object = Nothing
            Dim SAPguiAuto As Object = Nothing
            Dim Connection As Object = Nothing
            Dim session As Object = Nothing

            ' Verifica si SAP GUI está activo
            SAPguiAuto = GetObject("SAPGUI")
            If SAPguiAuto Is Nothing Then
                ' Abre SAP Logon si no está activo
                Dim WshShell As Object = CreateObject("WScript.Shell")
                WshShell.Exec("C:\Program Files (x86)\SAP\FrontEnd\SAPgui\saplogon.exe")

                ' Espera a que SAP Logon esté listo
                Do While Not WshShell.AppActivate("SAP Logon 750")
                    System.Threading.Thread.Sleep(1000)
                Loop

                ' Intenta conectar nuevamente
                SAPguiAuto = GetObject("SAPGUI")
                If SAPguiAuto Is Nothing Then
                    Throw New Exception("No se pudo iniciar SAP GUI.")
                End If
            End If

            ' Obtiene el motor de scripting de SAP GUI
            SAPguiApp = SAPguiAuto.GetScriptingEngine
            If SAPguiApp Is Nothing Then
                Throw New Exception("No se pudo obtener el motor de scripting de SAP GUI.")
            End If

            ' Abre la conexión a SAP
            'Connection = SAPguiApp.OpenConnection("PRD [COMERCIAL]", True)
            Connection = SAPguiApp.OpenConnection("QAS [CALIDAD]", True)
            If Connection Is Nothing Then
                Throw New Exception("No se pudo abrir la conexión a SAP.")
            End If

            ' Obtiene la sesión
            session = Connection.Children(0)
            If session Is Nothing Then
                Throw New Exception("No se pudo establecer la sesión en SAP.")
            End If

            ' Introduce las credenciales
            session.findById("wnd[0]/usr/txtRSYST-BNAME").text = TextBox4.Text
            session.findById("wnd[0]/usr/pwdRSYST-BCODE").text = TextBox5.Text
            session.findById("wnd[0]").sendVKey(0)

            ' Verifica si SAP muestra un mensaje de error (ventana de error)
            Try
                ' Espera un momento para ver si aparece el mensaje de error de SAP
                If session.findById("wnd[1]").Type = "GuiDialog" Then
                    MessageBox.Show("Nombre de usuario o clave de acceso incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox4.Clear() ' Borra el campo de usuario
                    TextBox5.Clear() ' Borra el campo de contraseña
                    Return ' Detiene la ejecución
                End If
            Catch ex As Exception
                ' Si no aparece el mensaje de error, se sigue con el flujo normal
            End Try

            ' Maneja múltiples sesiones abiertas
            If session.Children.Count > 1 Then
                session.findById("wnd[1]/usr/radMULTI_LOGON_OPT2").Select()
                session.findById("wnd[1]/usr/radMULTI_LOGON_OPT2").SetFocus()
                session.findById("wnd[1]/tbar[0]/btn[0]").Press()
            End If

            'MessageBox.Show("Conexión exitosa con SAP", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            session.findById("wnd[0]/tbar[0]/okcd").Text = "/nzqm25"
            session.findById("wnd[0]").sendVKey(0)
            session.findById("wnd[0]/usr/ctxtSO_WERKS-LOW").Text = "1000"
            session.findById("wnd[0]/usr/ctxtSO_FLOTE-LOW").Text = "17.01.2022"
            session.findById("wnd[0]/usr/ctxtSO_FLOTE-HIGH").Text = "31.12.2030"
            'session.findById("wnd[0]/usr/ctxtSO_MATNR-LOW").Text = TextBox1.Text



            'session.findById("wnd[0]/usr/ctxtSO_ART-LOW").Text = "*"

            'session.findById("wnd[0]/usr/btn%_SO_CHARG_%_APP_%-VALU_PUSH").press
            'session.findById("wnd[1]/tbar[0]/btn[16]").press
            'session.findById("wnd[1]/tbar[0]/btn[24]").press
            'session.findById("wnd[1]/tbar[0]/btn[8]").press

            'session.findById("wnd[0]/usr/ctxtSO_ART-LOW").Text = Range("K1").Value
            session.findById("wnd[0]/usr/ctxtSO_ART-LOW").text = ComboBox2.Text
            session.findById("wnd[0]/usr/ctxtSO_CHARG-LOW").Text = TextBox1.Text
            session.findById("wnd[0]/usr/ctxtP_LAYOUT").Text = "/INFORMEFDE"
            session.findById("wnd[0]/usr/ctxtP_LAYOUT").SetFocus
            session.findById("wnd[0]/usr/ctxtP_LAYOUT").caretPosition = 11
            session.findById("wnd[0]/tbar[1]/btn[8]").press

            session.findById("wnd[0]/mbar/menu[0]/menu[3]/menu[2]").Select
            session.findById("wnd[1]/usr/subSUBSCREEN_STEPLOOP:SAPLSPO5:0150/sub:SAPLSPO5:0150/radSPOPLI-SELFLAG[1,0]").Select
            session.findById("wnd[1]/tbar[0]/btn[0]").press
            'session.findById("wnd[1]/tbar[0]/btn[0]").press
            session.findById("wnd[1]/usr/ctxtDY_PATH").Text = "\\COMEDFS02\CONTROL CALIDAD DE EMPAQUE\REQUISITOS DE GESTION\INFORMACION ACTIVA\"
            session.findById("wnd[1]/usr/ctxtDY_FILENAME").Text = "Nuevo.XLS"
            session.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 1
            session.findById("wnd[1]/tbar[0]/btn[11]").press
            session.findById("wnd[0]/tbar[0]/btn[3]").press
            session.findById("wnd[0]/tbar[0]/btn[3]").press

            ''Main()
        Catch ex As Exception
            MessageBox.Show($"Error al conectar con SAP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Main()
    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim filePath As String = "\\comedfs02\Control calidad de empaque\REQUISITOS DE GESTION\INFORMACION ACTIVA\Nuevo.XLS"
        'ExcelApp = New Application With {
        '.Visible = True ' No mostrar la ventana de Excel
        ' }

        ' Abre el archivo de Excel
        ' ExcelWorkbook = ExcelApp.Workbooks.Open(filePath)
        'ExcelWorksheet.Rows("1:3").Delete
        Main()


    End Sub















    ' Evento de cierre del formulario '
    'Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    'Try
    ' Verificar si el libro tiene cambios no guardados '
    'If Not Libro.Saved Then
    'Dim Respuesta As MsgBoxResult = MsgBox("¿Desea guardar los cambios en " & Libro.Name & "?",
    '                                               vbExclamation + vbYesNo, "Microsoft Excel")
    'If Respuesta = MsgBoxResult.Yes Then
    '                Libro.Save()
    '               MsgBox("Los cambios han sido guardados.")
    'End If
    'End If
    'Catch ex As Exception
    '       MsgBox("Ocurrió un error al intentar guardar los cambios: " & ex.Message)
    'Finally
    '' Cerrar Excel '
    'If ExcelApp IsNot Nothing Then
    '           ExcelApp.Quit()
    '          Libro = Nothing
    '         ExcelApp = Nothing
    'End If
    'End Try
    'End Sub

End Class

