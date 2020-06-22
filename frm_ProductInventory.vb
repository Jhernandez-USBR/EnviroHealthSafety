Public Class frm_ProductInventory


    Private Sub Chemical_ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Chemical_ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety_Data)

    End Sub

    Private Sub frm_ProductInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety_Data.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Product)

    End Sub

    Private Sub SearchProductName()
        Try
            Me.Chemical_ProductTableAdapter.FillBySearchProduct(Me.EnviroHealthSafety_Data.Chemical_Product, Me.txt_SearchProductName.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_SearchProduct_Click(sender As Object, e As EventArgs) Handles btn_SearchProduct.Click

        SearchProductName()
    End Sub

    Private Sub txt_SearchProductName_MouseEnter(sender As Object, e As EventArgs) Handles txt_SearchProductName.MouseEnter
        SearchProductName()
    End Sub



    Private Sub dgv_ProudtcList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProudtcList.CellDoubleClick
        Try
            Dim tempProductID As Object = dgv_ProudtcList.Rows(e.RowIndex).Cells(0).Value

            'MsgBox("Value through Rows.Cells.Value: " & BuildingID_Value)

            mod_ChemicalProduct.EditProductDetail(CInt(tempProductID))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class