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
        Libro = ExcelApp.Workbooks.Open("\\COMEDFS02\Reporte Muestreo e Inspección\Formatos CCE\FDE\AnálisisFDE.xlsx")
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
        Hoja1.Cells(Final, 9).Value = TxtObser.Text 'Hace registro de la nota para DE




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

        Dim pregunta = MsgBox("¿Tiene sección iniciada en SAP?", vbYesNo + vbQuestion, "CCE, PREBEL S.A.")
        If pregunta = vbNo Then
            MsgBox("Inicie SAP y vuelva a intentar")
        Else
            If TextBox1.Text = String.Empty Or ComboBox2.Text = String.Empty Then
                MsgBox("Campos obligatorios estan vacios")
            Else

                '' Validar si los campos de usuario y contraseña están vacíos
                'If String.IsNullOrEmpty(TextBox4.Text) Or String.IsNullOrEmpty(TextBox5.Text) Then
                '    MessageBox.Show("Por favor, ingrese tanto el usuario como la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    Return ' No continuar si los campos están vacíos
                'End If

                Try
                    Dim SAPguiApp As Object = Nothing
                    Dim SAPguiAuto As Object = Nothing
                    Dim Connection As Object = Nothing
                    Dim session As Object = Nothing

                    '' Verifica si SAP GUI está activo
                    'SAPguiAuto = GetObject("SAPGUI")
                    'If SAPguiAuto Is Nothing Then
                    '    ' Abre SAP Logon si no está activo
                    '    Dim WshShell As Object = CreateObject("WScript.Shell")
                    '    WshShell.Exec("C:\Program Files (x86)\SAP\FrontEnd\SAPgui\saplogon.exe")

                    '    ' Espera a que SAP Logon esté listo
                    '    Do While Not WshShell.AppActivate("SAP Logon 750")
                    '        System.Threading.Thread.Sleep(1000)
                    '    Loop

                    '    ' Intenta conectar nuevamente
                    '    SAPguiAuto = GetObject("SAPGUI")
                    '    If SAPguiAuto Is Nothing Then
                    '        Throw New Exception("No se pudo iniciar SAP GUI.")
                    '    End If
                    'End If

                    '' Obtiene el motor de scripting de SAP GUI
                    'SAPguiApp = SAPguiAuto.GetScriptingEngine
                    'If SAPguiApp Is Nothing Then
                    '    Throw New Exception("No se pudo obtener el motor de scripting de SAP GUI.")
                    'End If

                    '' Abre la conexión a SAP
                    ''Connection = SAPguiApp.OpenConnection("PRD [COMERCIAL]", True)
                    'Connection = SAPguiApp.OpenConnection("QAS [CALIDAD]", True)
                    'If Connection Is Nothing Then
                    '    Throw New Exception("No se pudo abrir la conexión a SAP.")
                    'End If

                    '' Obtiene la sesión
                    'session = Connection.Children(0)
                    'If session Is Nothing Then
                    '    Throw New Exception("No se pudo establecer la sesión en SAP.")
                    'End If

                    '' Introduce las credenciales
                    'session.findById("wnd[0]/usr/txtRSYST-BNAME").text = TextBox4.Text
                    'session.findById("wnd[0]/usr/pwdRSYST-BCODE").text = TextBox5.Text
                    'session.findById("wnd[0]").sendVKey(0)

                    '' Verifica si SAP muestra un mensaje de error (ventana de error)
                    'Try
                    '    ' Espera un momento para ver si aparece el mensaje de error de SAP
                    '    If session.findById("wnd[1]").Type = "GuiDialog" Then
                    '        MessageBox.Show("Nombre de usuario o clave de acceso incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '        TextBox4.Clear() ' Borra el campo de usuario
                    '        TextBox5.Clear() ' Borra el campo de contraseña
                    '        Return ' Detiene la ejecución
                    '    End If
                    'Catch ex As Exception
                    '    ' Si no aparece el mensaje de error, se sigue con el flujo normal
                    'End Try

                    '' Maneja múltiples sesiones abiertas
                    'If session.Children.Count > 1 Then
                    '    session.findById("wnd[1]/usr/radMULTI_LOGON_OPT2").Select()
                    '    session.findById("wnd[1]/usr/radMULTI_LOGON_OPT2").SetFocus()
                    '    session.findById("wnd[1]/tbar[0]/btn[0]").Press()
                    'End If

                    'MessageBox.Show("Conexión exitosa con SAP", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If SAPguiApp Is Nothing Then
                        SAPguiAuto = GetObject("SAPGUI") ' Nos conectamos a la sesión de SAP en curso
                        SAPguiApp = SAPguiAuto.GetScriptingEngine
                    End If

                    ' Obtener la conexión activa
                    If Connection Is Nothing Then
                        Connection = SAPguiApp.Children(0)
                    End If

                    ' Obtener la sesión activa
                    If session Is Nothing Then
                        session = Connection.Children(0)
                    End If

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
                    session.findById("wnd[1]/usr/ctxtDY_FILENAME").Text = "Nuevo1.XLS"
                    session.findById("wnd[1]/usr/ctxtDY_FILENAME").caretPosition = 1
                    session.findById("wnd[1]/tbar[0]/btn[11]").press
                    session.findById("wnd[0]/tbar[0]/btn[3]").press
                    session.findById("wnd[0]/tbar[0]/btn[3]").press

                    ''Main()
                Catch ex As Exception
                    MessageBox.Show($"Error al conectar con SAP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Main()
            End If
        End If
    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim defecto1, unidades1, unidadesins1, aql1, re1 As String
        'Dim defecto1, aql1, re1 As String
        'Dim unidades1, unidadesins1 As Integer
        Dim defecto2, unidades2, unidadesins2, aql2, re2 As String
        Dim defecto3, unidades3, unidadesins3, aql3, re3 As String
        Dim defecto4, unidades4, unidadesins4, aql4, re4 As String
        Dim defecto5, unidades5, unidadesins5, aql5, re5 As String
        Dim notafinal1, notafinal2, notafinal3, notafinal4, notafinal5 As String
        If Aplica1.Checked Then
            defecto1 = Txtdefecto1.Text
            unidades1 = Txtunidades1.Text
            unidadesins1 = TxtInspec1.Text
            aql1 = TxTiposAql1.Text
            re1 = TextRe1.Text
            notafinal1 = (defecto1 & ": " & unidades1 & "/" & unidadesins1 & ", " & aql1 & ", se rechaza con  " & re1 & " unidad(es). " & vbCrLf)
        End If

        If Aplica2.Checked Then
            defecto2 = (Txtdefecto2.Text)
            unidades2 = Txtunidades2.Text
            unidadesins2 = TxtInspec2.Text
            aql2 = TxTiposAql2.Text
            re2 = TextRe2.Text
            notafinal2 = (defecto2 & ": " & unidades2 & "/" & unidadesins2 & ", " & aql2 & ", se rechaza con  " & re2 & " unidad(es). " & vbCrLf)
        End If

        If Aplica3.Checked Then
            defecto3 = Txtdefecto3.Text
            unidades3 = Txtunidades3.Text
            unidadesins3 = TxtInspec3.Text
            aql3 = TxTiposAql3.Text
            re3 = TextRe3.Text
            notafinal3 = (defecto3 & ": " & unidades3 & "/" & unidadesins3 & ", " & aql3 & ", se rechaza con  " & re3 & " unidad(es). " & vbCrLf)
        End If

        If Aplica4.Checked Then
            defecto4 = Txtdefecto4.Text
            unidades4 = Txtunidades4.Text
            unidadesins4 = TxtInspec4.Text
            aql4 = TxTiposAql4.Text
            re4 = TextRe4.Text
            notafinal4 = (defecto4 & ": " & unidades4 & "/" & unidadesins4 & ", " & aql4 & ", se rechaza con  " & re4 & " unidad(es). " & vbCrLf)
        End If

        If Aplica5.Checked Then
            defecto5 = Txtdefecto5.Text
            unidades5 = Txtunidades5.Text
            unidadesins5 = TxtInspec5.Text
            aql5 = TxTiposAql5.Text
            re5 = TextRe5.Text
            notafinal5 = (defecto5 & ": " & unidades5 & "/" & unidadesins5 & ", " & aql5 & ", se rechaza con  " & re5 & " unidad(es). " & vbCrLf)
        End If


        If Aplica1.Checked Or Aplica2.Checked Or Aplica3.Checked Or Aplica4.Checked Or Aplica5.Checked Then
            If NotasDE.Text = String.Empty Or TxtObser.Text = String.Empty Then
                MsgBox("Campos obligatorios vacios... Notas u Observaciónes")
            Else
                Dim notafinal As String
                notafinal = ("El material de empaque no cumple con la(s) siguiente(s) característica(s)." & vbCrLf _
                & (notafinal1) _
                & (notafinal2) _
                & (notafinal3) _
                & (notafinal4) _
                & (notafinal5) _
                & TxtObser.Text & ". " & vbCrLf _
                & NotasDE.Text) & ". "
                TxtNotaFInal.Text = notafinal

            End If
        Else
            MsgBox("No hay defectos seleccionados.")
        End If

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

