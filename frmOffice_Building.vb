Public Class frmOffice_Building
    Dim savedCursor As Windows.Forms.Cursor
    Private Sub TlkpOffice_BuildingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TlkpOffice_BuildingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpOffice_PhysicalLocation' table. You can move, or remove it, as needed.
            Me.TlkpOffice_PhysicalLocationTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice_PhysicalLocation)
            'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpOffice' table. You can move, or remove it, as needed.
            Me.TlkpOfficeTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice)
            'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpOffice_Building' table. You can move, or remove it, as needed.
            Me.TlkpOffice_BuildingTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice_Building)


            If Not IsNothing(mod_OfficeMaintenance.tempBuildingID) Then
                'MsgBox("mod_OfficeMaintenance.tempBuildingID = " & mod_OfficeMaintenance.tempBuildingID)
                Me.TlkpOffice_BuildingBindingSource.Position = Me.TlkpOffice_BuildingBindingSource.Find("OfficeBuilding_ID", mod_OfficeMaintenance.tempBuildingID)
            End If

            If Not IsNothing(Me.OfficeBuilding_IDTextBox.Text) Then
                'dgv_PhysicalLocationRefresh()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("TRY-Catch Form1_Load " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub dgv_PhysicalLocationRefresh()
        Try
            If Not (IsNothing(Me.OfficeBuilding_IDTextBox.Text) Or Me.OfficeBuilding_IDTextBox.Text = "") Then
                Me.TlkpOffice_PhysicalLocationTableAdapter.FillBy(Me.EnviroHealthSafety.tlkpOffice_PhysicalLocation, CInt(OfficeBuilding_IDTextBox.Text))
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("TRY-Catch dgv_PhysicalLocationRefresh " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub btn_BackToRegion_Click(sender As Object, e As EventArgs) Handles btn_BackToOffice.Click
        frm_EHSMain.showMain_ChildForm(frmOffice, True)
    End Sub

    Private Sub ToolStrip1_MouseEnter(sender As Object, e As EventArgs) Handles tStrip_OfficeBuilding.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub ToolStrip1_MouseLeave(sender As Object, e As EventArgs) Handles tStrip_OfficeBuilding.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing

    End Sub


    Private Sub dgv_PhysicalLocation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_PhysicalLocation.CellDoubleClick
        Try

            Dim PhysicalID_Value As Object = dgv_PhysicalLocation.Rows(e.RowIndex).Cells(0).Value

            'MsgBox("Value through Rows.Cells.Value: " & PhysicalID_Value)

            Region_SelectedPhysicalLocation(CInt(PhysicalID_Value))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("TRY-Catch dgv_PhysicalLocation_CellDoubleClick " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Office_IDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Office_IDComboBox.SelectedIndexChanged
        dgv_PhysicalLocationRefresh()
    End Sub


End Class