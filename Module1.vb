Imports Microsoft.Office.Interop.Excel

Module Module1
    Public Function nReg(Hoja As Microsoft.Office.Interop.Excel.Worksheet, nFila As Long, nColumna As Long)
        nFila = 1
        nColumna = 1
        Do Until Hoja.Cells(nFila, nColumna).value = ""
            nFila = nFila + 1
        Loop
        Return nFila

    End Function
End Module
