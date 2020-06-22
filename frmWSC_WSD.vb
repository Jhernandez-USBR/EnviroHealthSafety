Public Class frmWSC_WSD
    Private Sub WSCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WSCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety_Data)

    End Sub

    Private Sub frmWSC_WSD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.WSC_WSD_WasteAnalysis' table. You can move, or remove it, as needed.
        Me.WSC_WSD_WasteAnalysisTableAdapter.Fill(Me.EnviroHealthSafety_Data.WSC_WSD_WasteAnalysis)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.WSC_WSD_UserKnowledge' table. You can move, or remove it, as needed.
        Me.WSC_WSD_UserKnowledgeTableAdapter.Fill(Me.EnviroHealthSafety_Data.WSC_WSD_UserKnowledge)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.WSC' table. You can move, or remove it, as needed.
        Me.WSCTableAdapter.Fill(Me.EnviroHealthSafety_Data.WSC)

        If Not (IsNothing(mod_WasteStreamCharacterization.mod_WSC_ID) Or mod_WasteStreamCharacterization.mod_WSC_ID = 0) Then

            Me.WSCBindingSource.Position = Me.WSCBindingSource.Find("WSC_ID", mod_WasteStreamCharacterization.mod_WSC_ID)

            If Me.checkbox_UserKnowledge.CheckState = CheckState.Checked Then
                'Me.checkbox_UserKnowledge.CheckState = CheckState.Checked
                Me.Panel_UserKnowledge.Visible = True
                Filterdgv_UserKnowledge()
            Else
                Me.Panel_UserKnowledge.Visible = False
            End If

            If Me.checkbox_WasteAnalysis.CheckState = CheckState.Checked Then
                Me.Panel_WasteAnalysis.Visible = True
                Filterdgv_WasteAnalysis()
            Else
                Me.Panel_WasteAnalysis.Visible = False
            End If
        Else
            Me.Panel_UserKnowledge.Visible = False
            Me.Panel_WasteAnalysis.Visible = False

        End If

    End Sub


    Private Sub Filterdgv_UserKnowledge()
        Try
            Me.WSC_WSD_UserKnowledgeTableAdapter.FillByFilterWSCID(Me.EnviroHealthSafety_Data.WSC_WSD_UserKnowledge, mod_WasteStreamCharacterization.mod_WSC_ID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Filterdgv_WasteAnalysis()
        Try
            Me.WSC_WSD_WasteAnalysisTableAdapter.FillByFilterWSCID(Me.EnviroHealthSafety_Data.WSC_WSD_WasteAnalysis, mod_WasteStreamCharacterization.mod_WSC_ID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub checkbox_UserKnowledge_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_UserKnowledge.CheckedChanged
        If Me.checkbox_UserKnowledge.CheckState = CheckState.Checked Then
            'Me.checkbox_UserKnowledge.CheckState = CheckState.Checked
            Me.Panel_UserKnowledge.Visible = True
            Filterdgv_UserKnowledge()
        Else
            Me.Panel_UserKnowledge.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frm_EHSMain.openMain_ChildForm(frmWSC_WSD_Identification, False)
    End Sub
End Class