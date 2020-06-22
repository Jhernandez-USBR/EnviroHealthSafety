Public Class frm_Region
    Private Sub TlkpRegionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TlkpRegionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety_Data)

    End Sub

    Private Sub frm_Region_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data1.tlkpOffice_Type' table. You can move, or remove it, as needed.
        Me.TlkpOffice_TypeTableAdapter.Fill(Me.EnviroHealthSafety_Data1.tlkpOffice_Type)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpOffice' table. You can move, or remove it, as needed.
        Me.TlkpOfficeTableAdapter.Fill(Me.EnviroHealthSafety_Data.tlkpOffice)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpRegion' table. You can move, or remove it, as needed.
        Me.TlkpRegionTableAdapter.Fill(Me.EnviroHealthSafety_Data.tlkpRegion)

        DataGridView_OfficeRefresh()

    End Sub



    Private Sub DataGridView_OfficeRefresh()
        Try
            Me.TlkpOfficeTableAdapter.FillBy(Me.EnviroHealthSafety_Data.tlkpOffice, New System.Nullable(Of Integer)(CType(cmb_RegionName.SelectedValue.ToString, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cmb_RegionName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_RegionName.SelectedIndexChanged
        DataGridView_OfficeRefresh()
    End Sub

    Private Sub cmb_RegionName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_RegionName.SelectedValueChanged
        'DataGridView_OfficeRefresh()
    End Sub


    Private Sub dgv_AssociatedOffice_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AssociatedOffice.CellDoubleClick
        Try

            Dim OfficeID_Value As Object = dgv_AssociatedOffice.Rows(e.RowIndex).Cells(0).Value

            'MsgBox("Value through Rows.Cells.Value: " & OfficeID_Value)

            Region_SelectedOffice(CInt(OfficeID_Value))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_AssociatedOffice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AssociatedOffice.CellContentClick

    End Sub
End Class