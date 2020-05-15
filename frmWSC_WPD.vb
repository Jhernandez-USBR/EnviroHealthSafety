Public Class frmWSC_WPD
    Dim savedCursor As Windows.Forms.Cursor
    Private Sub WSCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WSCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety)

    End Sub

    Private Sub frmWSC_WPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.WSC' table. You can move, or remove it, as needed.
        Me.WSCTableAdapter.Fill(Me.EnviroHealthSafety.WSC)

        Try
            If Not IsNothing(mod_WasteStreamCharacterization.mod_WSC_ID) Then

                Me.WSCBindingSource.Position = Me.WSCBindingSource.Find("WSC_ID", mod_WasteStreamCharacterization.mod_WSC_ID)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tStrip_WasteStreamCharacterization_MouseLeave(sender As Object, e As EventArgs) Handles tStrip_WasteStreamCharacterization.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub

    Private Sub tStrip_WasteStreamCharacterization_MouseEnter(sender As Object, e As EventArgs) Handles tStrip_WasteStreamCharacterization.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub btn_ReturnWSCDetail_Click(sender As Object, e As EventArgs) Handles btn_ReturnWSCDetail.Click
        frm_EHSMain.showMain_ChildForm(frmWSC, True)
    End Sub

    Private Sub btn_WSC_WPD_Click(sender As Object, e As EventArgs) Handles btn_WSC_WPD.Click
        frm_EHSMain.openMain_ChildForm(frmWSC_WSD, False)
    End Sub
End Class