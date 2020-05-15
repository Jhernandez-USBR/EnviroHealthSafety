Public Class frmOffice
    Private Sub TlkpOfficeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TlkpOfficeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety)

    End Sub

    Dim savedCursor As Windows.Forms.Cursor
    Public Sub OpenSpecific_OfficeIDRecord(tempOffice As Integer)

        Try
            If Not IsNothing(tempOffice) Then
                Me.TlkpOfficeBindingSource.Position = Me.TlkpOfficeBindingSource.Find("Office_ID", tempOffice)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frm_Office_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice_Building' table. You can move, or remove it, as needed.
        Me.TlkpOffice_BuildingTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice_Building)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice_Type' table. You can move, or remove it, as needed.
        Me.TlkpOffice_TypeTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice_Type)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpRegion' table. You can move, or remove it, as needed.
        Me.TlkpRegionTableAdapter.Fill(Me.EnviroHealthSafety.tlkpRegion)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice' table. You can move, or remove it, as needed.
        Me.TlkpOfficeTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice)

        Try
            If Not IsNothing(mod_OfficeMaintenance.tempOfficeID) Then

                Me.TlkpOfficeBindingSource.Position = Me.TlkpOfficeBindingSource.Find("Office_ID", mod_OfficeMaintenance.tempOfficeID)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        DataGrid_OfficeBuildingRefresh()

    End Sub

    Private Sub DataGrid_OfficeBuildingRefresh()
        Try

            Me.TlkpOffice_BuildingTableAdapter.FillBy_OfficeBuildingFilter(Me.EnviroHealthSafety.tlkpOffice_Building, New System.Nullable(Of Integer)(CType(txtOffice_ID.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)
        DataGrid_OfficeBuildingRefresh()
    End Sub

    Private Sub txtOffice_ID_TextChanged(sender As Object, e As EventArgs) Handles txtOffice_ID.TextChanged
        DataGrid_OfficeBuildingRefresh()
    End Sub


    Private Sub dgv_OfficeBuilding_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_OfficeBuilding.CellDoubleClick

        Try
            Dim BuildingID_Value As Object = dgv_OfficeBuilding.Rows(e.RowIndex).Cells(0).Value

            'MsgBox("Value through Rows.Cells.Value: " & BuildingID_Value)

            Region_SelectedBuilding(CInt(BuildingID_Value))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tStrip_Office_Click(sender As Object, e As EventArgs) Handles btn_BackToRegion.Click
        frm_EHSMain.showMain_ChildForm(frm_Region, True)
    End Sub



    Private Sub tStrip_Office_MouseEnter(sender As Object, e As EventArgs) Handles tStrip_Office.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub tStrip_Office_MouseLeave(sender As Object, e As EventArgs) Handles tStrip_Office.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing

    End Sub

    Private Sub cmb_OfficeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_OfficeName.SelectedIndexChanged
        DataGrid_OfficeBuildingRefresh()
    End Sub

End Class