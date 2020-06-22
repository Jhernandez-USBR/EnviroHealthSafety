Public Class frmWSC_Search
    Private Sub WSCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WSCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety_Data)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpOffice' table. You can move, or remove it, as needed.
        Me.TlkpOfficeTableAdapter.Fill(Me.EnviroHealthSafety_Data.tlkpOffice)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety_Data.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.WSC' table. You can move, or remove it, as needed.
        Me.WSCTableAdapter.Fill(Me.EnviroHealthSafety_Data.WSC)

    End Sub

    Private Sub Search_WSCReferenceName()
        Try
            Me.WSCTableAdapter.FillBySearchWSC(Me.EnviroHealthSafety_Data.WSC, Me.WSC_NameTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Search_WSCReferenceName()
    End Sub


    Private Sub dgv_WSCSearchResult_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_WSCSearchResult.CellDoubleClick
        Try
            Dim DGV_tempWSC As Object = dgv_WSCSearchResult.Rows(e.RowIndex).Cells(0).Value

            'MsgBox("Value through Rows.Cells.Value: " & DGV_tempWSC)
            mod_WasteStreamCharacterization.OpenWSC_PreviousForm(Me.Name.ToString)
            mod_WasteStreamCharacterization.Search_OpenWSCDetails(CInt(DGV_tempWSC))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btn_ClearWSCSearch_Click(sender As Object, e As EventArgs) Handles btn_ClearWSCSearch.Click

    End Sub

    Private Sub btn_NewWSC_Click(sender As Object, e As EventArgs) Handles btn_NewWSC.Click
        New_OpenWSCDetails()
    End Sub
End Class