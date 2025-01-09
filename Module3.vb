Imports ClosedXML.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports OfficeOpenXml
Imports NPOI.HSSF.UserModel
Imports NPOI.SS.UserModel
Imports NPOI
Imports DocumentFormat.OpenXml.Drawing

Module Module3
    Sub Main()
        ' Iniciar una nueva instancia de Excel
        Dim excelApp As New Excel.Application()
        'Dim worksheet As Excel.Worksheet
        excelApp.Visible = False  ' Hacer visible la aplicación de Excel
        ' Abrir un libro de trabajo (reemplaza la ruta por la del archivo que deseas)
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Open("\\comedfs02\Control calidad de empaque\REQUISITOS DE GESTION\INFORMACION ACTIVA\Nuevo.XLS")
        Dim ws As Excel.Worksheet = CType(workbook.ActiveSheet, Excel.Worksheet)

        ' Copiar la columna N desde la primera fila hasta la última fila con datos
        Dim lastRow As Integer = ws.Cells(ws.Rows.Count, "N").End(Excel.XlDirection.xlUp).Row
        Dim columnN As Excel.Range = ws.Range("L6:N" & lastRow)
        columnN.Copy()

        ' Crear una nueva hoja después de la hoja activa
        Dim newSheet As Excel.Worksheet = CType(workbook.Sheets.Add(After:=ws), Excel.Worksheet)

        ' Pegar el contenido copiado en la nueva hoja
        newSheet.Paste()

        ' Eliminar duplicados en el rango A1:A17 de la nueva hoja
        Dim range As Excel.Range = newSheet.Range("A1:C170")
        range.RemoveDuplicates(1, Excel.XlYesNoGuess.xlNo)

        Dim ws2 As Excel.Worksheet = CType(workbook.ActiveSheet, Excel.Worksheet)

        'Codigo para traer informacion del Excel al Textbox
        Dim valorC1 As String = ws2.Range("C1").Value
        Dim valorC2 As String = ws2.Range("C2").Value
        Dim valorC3 As String = ws2.Range("C3").Value
        Dim valorC4 As String = ws2.Range("C4").Value
        Dim valorC5 As String = ws2.Range("C5").Value

        ' Crear una instancia del formulario y asignar los valores de Excel a los TextBox
        'Dim form As New Form1()
        Dim form As Form1 = Application.OpenForms.OfType(Of Form1)().FirstOrDefault()
        form.Txtdefecto1.Text = valorC1
        form.Txtdefecto2.Text = valorC2
        form.Txtdefecto3.Text = valorC3
        form.Txtdefecto4.Text = valorC4
        form.Txtdefecto5.Text = valorC5
        form.Hide()
        form.Show()



        Dim contador As Long
        Dim i As Long

        ' Establecer la hoja de trabajo activa


        ' Inicializar el contador
        contador = 0

        ' Recorrer las primeras 10 celdas de la columna C (de C1 a C10)
        For i = 1 To 10
            ' Verificar si la celda en la columna C no está vacía
            If ws2.Cells(i, "C").Value <> "" Then
                contador = contador + 1
            End If
        Next i


        ' Guardar y cerrar el libro
        'workbook.Save()
        'workbook.Close()
        'excelApp.Quit()



        Dim SAPguiApp As Object = Nothing
        Dim SAPguiAuto As Object = Nothing
        Dim Connection As Object = Nothing
        Dim session As Object = Nothing


        'Try
        ' Intentamos obtener la instancia de SAP GUI
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

        ' Si tenemos un objeto WScript (esto generalmente se usa en scripts VBS), conectamos a los eventos
        'If IsObject(WScript) Then
        'WScript.ConnectObject(session, "on")
        'WScript.ConnectObject(SAPguiApp, "on")
        'End If





        session.findById("wnd[0]").maximize
        session.findById("wnd[0]/tbar[0]/okcd").text = "/nQA33"
        session.findById("wnd[0]").sendVKey(0)
        session.findById("wnd[0]/usr/radP_NO_UD").select
        session.findById("wnd[0]/usr/ctxtQL_ENSTD-LOW").text = ""
        session.findById("wnd[0]/usr/ctxtQL_ENSTD-HIGH").text = ""
        session.findById("wnd[0]/usr/ctxtQL_MATNR-LOW").text = ""
        session.findById("wnd[0]/usr/ctxtQL_CHARG-LOW").text = form.TextBox1.Text
        session.findById("wnd[0]/usr/radP_NO_UD").setFocus
        session.findById("wnd[0]/tbar[1]/btn[8]").press
        session.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").currentCellColumn = ""
        session.findById("wnd[0]/usr/cntlGRID1/shellcont/shell").selectedRows = "0"
        session.findById("wnd[0]/tbar[1]/btn[41]").press
        session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK").select

        Dim parte1, parte2, Tamano1 As String

        If contador > 0 Then

            parte1 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-ANZFEHLEH[9,0]").text
            parte2 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-PRUEFUMF[14,0]").text

            ' Eliminar los últimos 4 dígitos de cada parte (si la longitud lo permite)
            If Len(parte1) > 4 Then
                parte1 = Left(parte1, Len(parte1) - 4)
            End If

            If Len(parte2) > 4 Then
                parte2 = Left(parte2, Len(parte2) - 4)
            End If

            form.Txtunidades1.Text = parte1
            form.TxtInspec1.Text = parte2

            parte1 = ""
            parte2 = ""
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,0]").setFocus
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,0]").press
            session.findById("wnd[0]/tbar[1]/btn[42]").press
            form.TextRe1.Text = session.findById("wnd[1]/usr/txtQAQEE1-RUECKWEZ").Text
            form.TextAc1.Text = session.findById("wnd[1]/usr/txtQAQEE1-ANNAHMEZ").Text
            Tamano1 = session.findById("wnd[1]/usr/txtQAMKR-SOLLSTPUMF").Text


            session.findById("wnd[1]").close
            session.findById("wnd[0]/tbar[0]/btn[3]").press

        End If

        If contador > 1 Then

            parte1 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-ANZFEHLEH[9,1]").text
            parte2 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-PRUEFUMF[14,1]").text

            ' Eliminar los últimos 4 dígitos de cada parte (si la longitud lo permite)
            If Len(parte1) > 4 Then
                parte1 = Left(parte1, Len(parte1) - 4)
            End If

            If Len(parte2) > 4 Then
                parte2 = Left(parte2, Len(parte2) - 4)
            End If

            form.Txtunidades2.Text = parte1
            form.TxtInspec2.Text = parte2

            parte1 = ""
            parte2 = ""

            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,1]").setFocus
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,1]").press
            session.findById("wnd[0]/tbar[1]/btn[42]").press
            form.TextRe2.Text = session.findById("wnd[1]/usr/txtQAQEE1-RUECKWEZ").Text
            form.TextAc2.Text = session.findById("wnd[1]/usr/txtQAQEE1-ANNAHMEZ").Text
            Tamano1 = session.findById("wnd[1]/usr/txtQAMKR-SOLLSTPUMF").Text
            session.findById("wnd[1]").close
            session.findById("wnd[0]/tbar[0]/btn[3]").press


        End If
        If contador > 2 Then

            parte1 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-ANZFEHLEH[9,2]").text
            parte2 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-PRUEFUMF[14,2]").text

            ' Eliminar los últimos 4 dígitos de cada parte (si la longitud lo permite)
            If Len(parte1) > 4 Then
                parte1 = Left(parte1, Len(parte1) - 4)
            End If

            If Len(parte2) > 4 Then
                parte2 = Left(parte2, Len(parte2) - 4)
            End If

            form.Txtunidades3.Text = parte1
            form.TxtInspec3.Text = parte2
            parte1 = ""
            parte2 = ""

            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,2]").setFocus
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,2]").press
            session.findById("wnd[0]/tbar[1]/btn[42]").press
            form.TextRe3.Text = session.findById("wnd[1]/usr/txtQAQEE1-RUECKWEZ").Text
            form.TextAc3.Text = session.findById("wnd[1]/usr/txtQAQEE1-ANNAHMEZ").Text
            Tamano1 = session.findById("wnd[1]/usr/txtQAMKR-SOLLSTPUMF").Text
            session.findById("wnd[1]").close
            session.findById("wnd[0]/tbar[0]/btn[3]").press


        End If
        If contador > 3 Then

            parte1 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-ANZFEHLEH[9,3]").text
            parte2 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-PRUEFUMF[14,3]").text

            ' Eliminar los últimos 4 dígitos de cada parte (si la longitud lo permite)
            If Len(parte1) > 4 Then
                parte1 = Left(parte1, Len(parte1) - 4)
            End If

            If Len(parte2) > 4 Then
                parte2 = Left(parte2, Len(parte2) - 4)
            End If

            form.Txtunidades4.Text = parte1
            form.TxtInspec4.Text = parte2
            parte1 = ""
            parte2 = ""

            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,3]").setFocus
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,3]").press
            session.findById("wnd[0]/tbar[1]/btn[42]").press
            form.TextRe4.Text = session.findById("wnd[1]/usr/txtQAQEE1-RUECKWEZ").Text
            form.TextAc4.Text = session.findById("wnd[1]/usr/txtQAQEE1-ANNAHMEZ").Text
            Tamano1 = session.findById("wnd[1]/usr/txtQAMKR-SOLLSTPUMF").Text
            session.findById("wnd[1]").close
            session.findById("wnd[0]/tbar[0]/btn[3]").press


        End If
        If contador > 4 Then

            parte1 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-ANZFEHLEH[9,4]").text
            parte2 = session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/txtQAMKR-PRUEFUMF[14,4]").text

            ' Eliminar los últimos 4 dígitos de cada parte (si la longitud lo permite)
            If Len(parte1) > 4 Then
                parte1 = Left(parte1, Len(parte1) - 4)
            End If

            If Len(parte2) > 4 Then
                parte2 = Left(parte2, Len(parte2) - 4)
            End If

            form.Txtunidades5.Text = parte1
            form.TxtInspec5.Text = parte2
            parte1 = ""
            parte2 = ""
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,4]").setFocus
            session.findById("wnd[0]/usr/tabsUD_DATA/tabpPLMK/ssubSUB_UD_DATA:SAPMQEVA:0101/tblSAPMQEVAMERKMALE/btn*QAMKR-MERKNR[0,4]").press
            session.findById("wnd[0]/tbar[1]/btn[42]").press
            form.TextRe5.Text = session.findById("wnd[1]/usr/txtQAQEE1-RUECKWEZ").Text
            form.TextAc5.Text = session.findById("wnd[1]/usr/txtQAQEE1-ANNAHMEZ").Text
            Tamano1 = session.findById("wnd[1]/usr/txtQAMKR-SOLLSTPUMF").Text
            session.findById("wnd[1]").close
            session.findById("wnd[0]/tbar[0]/btn[3]").press


        End If
        ' End Try


        'Abre tabla de AQL 

        Dim excelApp1 As New Excel.Application()
        excelApp1.Visible = True
        Dim workbook2 As Excel.Workbook = excelApp1.Workbooks.Open("\\comedfs02\Reporte Muestreo e Inspección\Formatos CCE\FDE\TablaAQL1.xlsx", [ReadOnly]:=True)
        Dim ws1 As Excel.Worksheet = CType(workbook2.ActiveSheet, Excel.Worksheet)


        'Valida Primera fila 


        If form.TxtInspec1.Text <> String.Empty Then
            Dim fila As Long
            fila = 3

            ' Recorremos las filas
            Do While True
                ' Obtenemos el valor de la celda en la columna B
                Dim cellValue As Object = workbook2.Sheets("Hoja2").Range("B" & fila).Value

                ' Verificamos si la celda tiene un valor válido (no es Nothing y no es error)
                If IsNothing(cellValue) OrElse IsError(cellValue) Then
                    Exit Do
                End If

                ' Inicializamos la cadena que contendrá el valor convertido
                Dim cellValueStr As String = String.Empty

                ' Si el valor de la celda es un número (Double), lo convertimos a String
                If TypeOf cellValue Is Double Then
                    cellValueStr = cellValue.ToString()
                    ' Si el valor de la celda es una cadena, lo asignamos directamente
                ElseIf TypeOf cellValue Is String Then
                    cellValueStr = CStr(cellValue)
                    ' Si el valor de la celda es una fecha, la convertimos a String con un formato adecuado
                ElseIf TypeOf cellValue Is Date Then
                    cellValueStr = CType(cellValue, Date).ToString("yyyy-MM-dd")
                End If

                ' Comparamos el valor de la celda con el texto del formulario
                If cellValueStr = form.TxtInspec1.Text Then

                    If workbook2.Sheets("Hoja2").Range("C" & fila).Value = form.TextAc1.Text And workbook2.Sheets("Hoja2").Range("d" & fila).Value = form.TextRe1.Text Then

                        form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("C1").Value
                    Else
                        If workbook2.Sheets("Hoja2").Range("E" & fila).Value = form.TextAc1.Text And workbook2.Sheets("Hoja2").Range("F" & fila).Value = form.TextRe1.Text Then

                            form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("E1").Value
                        Else
                            If workbook2.Sheets("Hoja2").Range("G" & fila).Value = form.TextAc1.Text And workbook2.Sheets("Hoja2").Range("H" & fila).Value = form.TextRe1.Text Then

                                form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("G1").Value
                            Else
                                If workbook2.Sheets("Hoja2").Range("I" & fila).Value = form.TextAc1.Text And workbook2.Sheets("Hoja2").Range("J" & fila).Value = form.TextRe1.Text Then

                                    form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("I1").Value
                                Else
                                    If workbook2.Sheets("Hoja2").Range("K" & fila).Value = form.TextAc1.Text And workbook2.Sheets("Hoja2").Range("L" & fila).Value = form.TextRe1.Text Then

                                        form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("K1").Value
                                    End If
                                End If
                            End If
                        End If
                    End If


                    Exit Do
                    End If

                    ' Incrementamos la fila
                    fila += 1
            Loop
        End If

        'Valida Segunda fila 

        If form.TxtInspec2.Text <> String.Empty Then
            Dim fila As Long
            fila = 3

            ' Recorremos las filas
            Do While True
                ' Obtenemos el valor de la celda en la columna B
                Dim cellValue As Object = workbook2.Sheets("Hoja2").Range("B" & fila).Value

                ' Verificamos si la celda tiene un valor válido (no es Nothing y no es error)
                If IsNothing(cellValue) OrElse IsError(cellValue) Then
                    Exit Do
                End If

                ' Inicializamos la cadena que contendrá el valor convertido
                Dim cellValueStr As String = String.Empty

                ' Si el valor de la celda es un número (Double), lo convertimos a String
                If TypeOf cellValue Is Double Then
                    cellValueStr = cellValue.ToString()
                    ' Si el valor de la celda es una cadena, lo asignamos directamente
                ElseIf TypeOf cellValue Is String Then
                    cellValueStr = CStr(cellValue)
                    ' Si el valor de la celda es una fecha, la convertimos a String con un formato adecuado
                ElseIf TypeOf cellValue Is Date Then
                    cellValueStr = CType(cellValue, Date).ToString("yyyy-MM-dd")
                End If

                ' Comparamos el valor de la celda con el texto del formulario
                If cellValueStr = form.TxtInspec2.Text Then

                    If workbook2.Sheets("Hoja2").Range("C" & fila).Value = form.TextAc2.Text And workbook2.Sheets("Hoja2").Range("d" & fila).Value = form.TextRe2.Text Then

                        form.TxTiposAql2.Text = workbook2.Sheets("Hoja2").Range("C1").Value
                    Else
                        If workbook2.Sheets("Hoja2").Range("E" & fila).Value = form.TextAc2.Text And workbook2.Sheets("Hoja2").Range("F" & fila).Value = form.TextRe2.Text Then

                            form.TxTiposAql2.Text = workbook2.Sheets("Hoja2").Range("E1").Value
                        Else
                            If workbook2.Sheets("Hoja2").Range("G" & fila).Value = form.TextAc2.Text And workbook2.Sheets("Hoja2").Range("H" & fila).Value = form.TextRe2.Text Then

                                form.TxTiposAql2.Text = workbook2.Sheets("Hoja2").Range("G1").Value
                            Else
                                If workbook2.Sheets("Hoja2").Range("I" & fila).Value = form.TextAc2.Text And workbook2.Sheets("Hoja2").Range("J" & fila).Value = form.TextRe2.Text Then

                                    form.TxTiposAql2.Text = workbook2.Sheets("Hoja2").Range("I1").Value
                                Else
                                    If workbook2.Sheets("Hoja2").Range("K" & fila).Value = form.TextAc2.Text And workbook2.Sheets("Hoja2").Range("L" & fila).Value = form.TextRe2.Text Then

                                        form.TxTiposAql2.Text = workbook2.Sheets("Hoja2").Range("K1").Value
                                    End If
                                End If
                            End If
                        End If
                    End If


                    Exit Do
                End If

                ' Incrementamos la fila
                fila += 1
            Loop
        End If


        'Valida Ter fila 

        If form.TxtInspec3.Text <> String.Empty Then
            Dim fila As Long
            fila = 3

            ' Recorremos las filas
            Do While True
                ' Obtenemos el valor de la celda en la columna B
                Dim cellValue As Object = workbook2.Sheets("Hoja2").Range("B" & fila).Value

                ' Verificamos si la celda tiene un valor válido (no es Nothing y no es error)
                If IsNothing(cellValue) OrElse IsError(cellValue) Then
                    Exit Do
                End If

                ' Inicializamos la cadena que contendrá el valor convertido
                Dim cellValueStr As String = String.Empty

                ' Si el valor de la celda es un número (Double), lo convertimos a String
                If TypeOf cellValue Is Double Then
                    cellValueStr = cellValue.ToString()
                    ' Si el valor de la celda es una cadena, lo asignamos directamente
                ElseIf TypeOf cellValue Is String Then
                    cellValueStr = CStr(cellValue)
                    ' Si el valor de la celda es una fecha, la convertimos a String con un formato adecuado
                ElseIf TypeOf cellValue Is Date Then
                    cellValueStr = CType(cellValue, Date).ToString("yyyy-MM-dd")
                End If

                ' Comparamos el valor de la celda con el texto del formulario
                If cellValueStr = form.TxtInspec3.Text Then

                    If workbook2.Sheets("Hoja2").Range("C" & fila).Value = form.TextAc3.Text And workbook2.Sheets("Hoja2").Range("d" & fila).Value = form.TextRe3.Text Then

                        form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("C1").Value
                    Else
                        If workbook2.Sheets("Hoja2").Range("E" & fila).Value = form.TextAc3.Text And workbook2.Sheets("Hoja2").Range("F" & fila).Value = form.TextRe3.Text Then

                            form.TxTiposAql3.Text = workbook2.Sheets("Hoja2").Range("E1").Value
                        Else
                            If workbook2.Sheets("Hoja2").Range("G" & fila).Value = form.TextAc3.Text And workbook2.Sheets("Hoja2").Range("H" & fila).Value = form.TextRe3.Text Then

                                form.TxTiposAql3.Text = workbook2.Sheets("Hoja2").Range("G1").Value
                            Else
                                If workbook2.Sheets("Hoja2").Range("I" & fila).Value = form.TextAc3.Text And workbook2.Sheets("Hoja2").Range("J" & fila).Value = form.TextRe3.Text Then

                                    form.TxTiposAql1.Text = workbook2.Sheets("Hoja2").Range("I1").Value
                                Else
                                    If workbook2.Sheets("Hoja2").Range("K" & fila).Value = form.TextAc3.Text And workbook2.Sheets("Hoja2").Range("L" & fila).Value = form.TextRe3.Text Then

                                        form.TxTiposAql3.Text = workbook2.Sheets("Hoja2").Range("K1").Value
                                    End If
                                End If
                            End If
                        End If
                    End If


                    Exit Do
                End If

                ' Incrementamos la fila
                fila += 1
            Loop
        End If



        'valida 4 fila 

        If form.TxtInspec4.Text <> String.Empty Then
            Dim fila As Long
            fila = 3

            ' Recorremos las filas
            Do While True
                ' Obtenemos el valor de la celda en la columna B
                Dim cellValue As Object = workbook2.Sheets("Hoja2").Range("B" & fila).Value

                ' Verificamos si la celda tiene un valor válido (no es Nothing y no es error)
                If IsNothing(cellValue) OrElse IsError(cellValue) Then
                    Exit Do
                End If

                ' Inicializamos la cadena que contendrá el valor convertido
                Dim cellValueStr As String = String.Empty

                ' Si el valor de la celda es un número (Double), lo convertimos a String
                If TypeOf cellValue Is Double Then
                    cellValueStr = cellValue.ToString()
                    ' Si el valor de la celda es una cadena, lo asignamos directamente
                ElseIf TypeOf cellValue Is String Then
                    cellValueStr = CStr(cellValue)
                    ' Si el valor de la celda es una fecha, la convertimos a String con un formato adecuado
                ElseIf TypeOf cellValue Is Date Then
                    cellValueStr = CType(cellValue, Date).ToString("yyyy-MM-dd")
                End If

                ' Comparamos el valor de la celda con el texto del formulario
                If cellValueStr = form.TxtInspec4.Text Then

                    If workbook2.Sheets("Hoja2").Range("C" & fila).Value = form.TextAc4.Text And workbook2.Sheets("Hoja2").Range("d" & fila).Value = form.TextRe4.Text Then

                        form.TxTiposAql4.Text = workbook2.Sheets("Hoja2").Range("C1").Value
                    Else
                        If workbook2.Sheets("Hoja2").Range("E" & fila).Value = form.TextAc4.Text And workbook2.Sheets("Hoja2").Range("F" & fila).Value = form.TextRe4.Text Then

                            form.TxTiposAql4.Text = workbook2.Sheets("Hoja2").Range("E1").Value
                        Else
                            If workbook2.Sheets("Hoja2").Range("G" & fila).Value = form.TextAc4.Text And workbook2.Sheets("Hoja2").Range("H" & fila).Value = form.TextRe4.Text Then

                                form.TxTiposAql4.Text = workbook2.Sheets("Hoja2").Range("G1").Value
                            Else
                                If workbook2.Sheets("Hoja2").Range("I" & fila).Value = form.TextAc4.Text And workbook2.Sheets("Hoja2").Range("J" & fila).Value = form.TextRe4.Text Then

                                    form.TxTiposAql4.Text = workbook2.Sheets("Hoja2").Range("I1").Value
                                Else
                                    If workbook2.Sheets("Hoja2").Range("K" & fila).Value = form.TextAc4.Text And workbook2.Sheets("Hoja2").Range("L" & fila).Value = form.TextRe4.Text Then

                                        form.TxTiposAql4.Text = workbook2.Sheets("Hoja2").Range("K1").Value
                                    End If
                                End If
                            End If
                        End If
                    End If


                    Exit Do
                End If

                ' Incrementamos la fila
                fila += 1
            Loop
        End If

        'Valida 5 fila 

        If form.TxtInspec5.Text <> String.Empty Then
            Dim fila As Long
            fila = 3

            ' Recorremos las filas
            Do While True
                ' Obtenemos el valor de la celda en la columna B
                Dim cellValue As Object = workbook2.Sheets("Hoja2").Range("B" & fila).Value

                ' Verificamos si la celda tiene un valor válido (no es Nothing y no es error)
                If IsNothing(cellValue) OrElse IsError(cellValue) Then
                    Exit Do
                End If

                ' Inicializamos la cadena que contendrá el valor convertido
                Dim cellValueStr As String = String.Empty

                ' Si el valor de la celda es un número (Double), lo convertimos a String
                If TypeOf cellValue Is Double Then
                    cellValueStr = cellValue.ToString()
                    ' Si el valor de la celda es una cadena, lo asignamos directamente
                ElseIf TypeOf cellValue Is String Then
                    cellValueStr = CStr(cellValue)
                    ' Si el valor de la celda es una fecha, la convertimos a String con un formato adecuado
                ElseIf TypeOf cellValue Is Date Then
                    cellValueStr = CType(cellValue, Date).ToString("yyyy-MM-dd")
                End If

                ' Comparamos el valor de la celda con el texto del formulario
                If cellValueStr = form.TxtInspec5.Text Then

                    If workbook2.Sheets("Hoja2").Range("C" & fila).Value = form.TextAc5.Text And workbook2.Sheets("Hoja2").Range("d" & fila).Value = form.TextRe5.Text Then

                        form.TxTiposAql5.Text = workbook2.Sheets("Hoja2").Range("C1").Value
                    Else
                        If workbook2.Sheets("Hoja2").Range("E" & fila).Value = form.TextAc5.Text And workbook2.Sheets("Hoja2").Range("F" & fila).Value = form.TextRe5.Text Then

                            form.TxTiposAql5.Text = workbook2.Sheets("Hoja2").Range("E1").Value
                        Else
                            If workbook2.Sheets("Hoja2").Range("G" & fila).Value = form.TextAc1.Text And workbook2.Sheets("Hoja2").Range("H" & fila).Value = form.TextRe1.Text Then

                                form.TxTiposAql5.Text = workbook2.Sheets("Hoja2").Range("G1").Value
                            Else
                                If workbook2.Sheets("Hoja2").Range("I" & fila).Value = form.TextAc5.Text And workbook2.Sheets("Hoja2").Range("J" & fila).Value = form.TextRe5.Text Then

                                    form.TxTiposAql5.Text = workbook2.Sheets("Hoja2").Range("I1").Value
                                Else
                                    If workbook2.Sheets("Hoja2").Range("K" & fila).Value = form.TextAc5.Text And workbook2.Sheets("Hoja2").Range("L" & fila).Value = form.TextRe5.Text Then

                                        form.TxTiposAql5.Text = workbook2.Sheets("Hoja2").Range("K1").Value
                                    End If
                                End If
                            End If
                        End If
                    End If


                    Exit Do
                End If

                ' Incrementamos la fila
                fila += 1
            Loop
        End If




        ' Liberar objetos COM para evitar fugas de memoria

        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook2)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(ws)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(ws1)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(newSheet)






    End Sub
End Module
