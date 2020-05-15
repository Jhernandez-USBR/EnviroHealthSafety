Public Class frmWSC
    Dim savedCursor As Windows.Forms.Cursor


    Private Sub frm_WSC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice' table. You can move, or remove it, as needed.
        Me.TlkpOfficeTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.WSC' table. You can move, or remove it, as needed.
        Me.WSCTableAdapter.Fill(Me.EnviroHealthSafety.WSC)

        Try
            If Not (IsNothing(mod_WasteStreamCharacterization.mod_WSC_ID) Or (mod_WasteStreamCharacterization.mod_WSC_ID = 0)) Then
                'MsgBox("frmWSC_Load try isNOthing True")
                Me.WSCBindingSource.Position = Me.WSCBindingSource.Find("WSC_ID", mod_WasteStreamCharacterization.mod_WSC_ID)
            Else
                'MsgBox("frmWSC_Load try isNothing False")
                Me.WSCBindingSource.AddNew()

                Me.WSC_WDB_UKnowledgeCheckBox.Checked = True
                Me.WSC_WDB_WAnalysisCheckBox.Checked = True
                Me.WSC_ActiveCheckBox.Checked = True

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: frm_WSC_Load" & vbCrLf & ex.Message)

        End Try

        If (mod_WasteStreamCharacterization.WSCPreviousForm_SearchWSC) Then
            Me.tStrip_lbl_PathBackButton.Text = "Search WSC"

        ElseIf mod_WasteStreamCharacterization.WSCPreviousForm_EditDetails Then
            Me.tStrip_lbl_PathBackButton.Text = "Edit SDS"

        Else
            Me.tStrip_lbl_PathBackButton.Text = "Home"
        End If

    End Sub


    Private Sub btn_WSC_F1_Click(sender As Object, e As EventArgs) Handles btn_WSC_F1.Click

        If ((Me.WSC_IDTextBox.Text = "") Or IsNothing(WSC_IDTextBox.Text)) Then
            MsgBox("There is no WSC ID currently on thise record. Try saving the record first!")
        Else
            mod_WasteStreamCharacterization.WSC_OpenWPD(CInt(Me.WSC_IDTextBox.Text))
        End If


    End Sub

    Private Sub tStrip_WasteStreamCharacterization_MouseEnter(sender As Object, e As EventArgs) Handles tStrip_WasteStreamCharacterization.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub tStrip_WasteStreamCharacterization_MouseLeave(sender As Object, e As EventArgs) Handles tStrip_WasteStreamCharacterization.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub

    Private Sub btn_NewWSC_Click(sender As Object, e As EventArgs) Handles btn_NewWSC.Click
        Me.WSCBindingSource.AddNew()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If MessageBox.Show("Are you susre you want to delete this records?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.WSCBindingSource.RemoveCurrent()

        End If
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            Me.ValidateWSC_DetailData()
            Me.Validate()
            Me.WSCBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety)
            Me.Refresh()
            MsgBox("Record was saved")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: btn_Update_Click" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub btn_PreviousForm_Click(sender As Object, e As EventArgs) Handles btn_PreviousForm.Click
        If Me.tStrip_lbl_PathBackButton.Text = "Search WSC" Then
            frm_EHSMain.showMain_ChildForm(frmWSC_Search, True)
        ElseIf Me.tStrip_lbl_PathBackButton.Text = "Edit SDS" Then
            'frm_EHSMain.showMain_ChildForm(frmWSC_Search, True)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ValidateWSC_DetailData()

        If Me.WSC_WDB_UKnowledgeCheckBox.CheckState = CheckState.Indeterminate Then
            MsgBox("Uknowledge Check State = Intermediate")

            Me.WSC_WDB_UKnowledgeCheckBox.CheckState = CheckState.Unchecked

            Me.WSC_WDB_UKnowledgeCheckBox.Checked = False
        End If

        If Me.WSC_ActiveCheckBox.CheckState = CheckState.Indeterminate Then
            Me.WSC_ActiveCheckBox.CheckState = CheckState.Checked
            Me.WSC_ActiveCheckBox.Checked = True
        End If

        If Me.WSC_WDB_WAnalysisCheckBox.CheckState = CheckState.Indeterminate Then
            Me.WSC_WDB_WAnalysisCheckBox.CheckState = CheckState.Unchecked
            Me.WSC_WDB_WAnalysisCheckBox.Checked = False
        End If

        If Me.WCS_PCB_ContaminatedCheckBox.CheckState = CheckState.Indeterminate Then
            Me.WCS_PCB_ContaminatedCheckBox.CheckState = CheckState.Unchecked
            Me.WCS_PCB_ContaminatedCheckBox.Checked = False
        End If

    End Sub


End Class