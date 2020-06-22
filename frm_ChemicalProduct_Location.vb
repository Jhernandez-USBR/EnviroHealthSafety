Public Class frm_ChemicalProduct_Location
    Private Sub frm_ChemicalProduct_Location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChemicalProduct_SetProductID()

    End Sub

    Private Sub dgv_ProductPhysicalLocation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProductPhysicalLocation.CellDoubleClick
        Dim tempProductLocationID_Value As Object = dgv_ProductPhysicalLocation.Rows(e.RowIndex).Cells(0).Value

        SetCP_ProductLocationID(tempProductLocationID_Value)

        frm_ChemicalProduct_Location_Detail.ShowDialog()
    End Sub


    Private Sub ChemicalProduct_SetProductID()
        Try
            Dim tempProductID As Integer
            tempProductID = mod_ChemicalProduct.GetCP_ProductID
            'MsgBox("General GetProductID: " & tempProductID)
            Me.Qry_ChemicalProduct_CurrentLocationTableAdapter.Fill(Me.EnviroHealthSafety_Data.qry_ChemicalProduct_CurrentLocation, tempProductID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class