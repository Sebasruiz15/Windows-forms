Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class Form2
    ' Declaración de los objetos de Excel
    Dim ExcelApp As Application
    Dim ExcelWorkbook As Workbook
    Dim ExcelWorksheet As Worksheet
    Dim ExcelRange As Range

    ' Ruta del archivo de Excel
    Dim filePath As String = "\\comedfs02\Control calidad de empaque\REQUISITOS DE GESTION\INFORMACION ACTIVA\Nuevo.XLS"

    ' Método que se ejecutará al abrir el archivo Excel
    Sub OpenExcelFile()
        ' Inicializa la aplicación de Excel
        ExcelApp = New Application With {
            .Visible = False ' No mostrar la ventana de Excel
        }

        Try
            ' Abre el archivo de Excel
            ExcelWorkbook = ExcelApp.Workbooks.Open(filePath)

            ' Selecciona la primera hoja de Excel
            ExcelWorksheet = CType(ExcelWorkbook.Sheets(1), Worksheet)

            ' Obtiene el rango de celdas que contiene datos
            ExcelRange = ExcelWorksheet.UsedRange

            ' Aquí puedes trabajar con los datos de Excel (por ejemplo, leer valores)
            ' Ejemplo: Leer el valor de la celda A1
            Dim cellValue As String = ExcelRange.Cells(1, 1).Value.ToString()
            MessageBox.Show("Valor de la celda A1: " & cellValue)

        Catch ex As Exception
            MessageBox.Show("Error al abrir el archivo Excel: " & ex.Message)
        Finally
            ' Cierra el archivo Excel y libera los recursos
            CloseExcel()
        End Try
    End Sub

    ' Función para cerrar y liberar los objetos Excel
    Private Sub CloseExcel()
        ' Cerrar el archivo Excel
        If ExcelWorkbook IsNot Nothing Then
            ExcelWorkbook.Close(False) ' No guardar los cambios
            ReleaseComObject(ExcelWorkbook)
        End If

        ' Cerrar la aplicación de Excel
        If ExcelApp IsNot Nothing Then
            ExcelApp.Quit()
            ReleaseComObject(ExcelApp)
        End If

        ' Liberar los objetos ExcelRange y ExcelWorksheet
        If ExcelRange IsNot Nothing Then ReleaseComObject(ExcelRange)
        If ExcelWorksheet IsNot Nothing Then ReleaseComObject(ExcelWorksheet)

        ' Forzar la recolección de basura para liberar memoria
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    ' Función para liberar objetos COM y evitar fugas de memoria
    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    ' Event handler para el botón o evento que ejecutará la apertura de Excel
    'Private Sub btnOpenExcel_Click(sender As Object, e As EventArgs) Handles btnOpenExcel.Click
    ' OpenExcelFile()
    ' End Sub
End Class
