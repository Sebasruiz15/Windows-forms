Imports Microsoft.Office.Interop.Excel

Module Module2
    Sub Main()
        ' Crear una instancia de la aplicación de Excel
        Dim excelApp As New Application
        Dim workbook As Workbook
        Dim sheet As Worksheet

        Try
            ' Abre el archivo de Excel
            workbook = excelApp.Workbooks.Open("\\comedfs02\Control Calidad de empaque\REQUISITOS DE GESTION\INFORMACION ACTIVA\fde_4.XLS")
            sheet = workbook.Hoja(1) ' Asumimos que estamos trabajando con la primera hoja

            ' Eliminar la segunda fila
            sheet.Rows("2:2").Delete()

            ' Congelar paneles en la celda A2
            sheet.Range("A2").Select()
            excelApp.ActiveWindow.FreezePanes = True

            ' Guardar el archivo
            workbook.SaveAs("\\comedfs02\Control Calidad de empaque\REQUISITOS DE GESTION\INFORMACION ACTIVA\fde_4.XLS")

            ' Cerrar el libro y Excel

            'ReadOnlyRecommended:=(False), CreateBackup:=(False)
            'Application.DisplayAlerts = False
            workbook.Close()
            excelApp.Quit()

        Catch ex As Exception
            ' Si ocurre algún error, mostrarlo
            Console.WriteLine("Error: " & ex.Message)
        Finally
            ' Liberar recursos
            ReleaseObject(excelApp)
            ReleaseObject(workbook)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            ' Liberar el objeto de Excel para evitar bloqueos
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module

