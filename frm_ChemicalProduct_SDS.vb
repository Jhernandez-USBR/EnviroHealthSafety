Public Class frm_ChemicalProduct_SDS

    Private Sub frm_ChemicalProduct_SDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.SDS' table. You can move, or remove it, as needed.
            Me.SDSTableAdapter.Fill(Me.EnviroHealthSafety_Data.SDS)
            'TODO: This line of code loads data into the 'EnviroHealthSafety_Data1.Chemical_Product' table. You can move, or remove it, as needed.
            Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Product)

            ChemicalProduct_SetProductID()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ChemicalProduct_SetProductID()
        Try
            Dim tempProductID As Integer
            tempProductID = mod_ChemicalProduct.GetCP_ProductID

            Me.SDSTableAdapter.FillByFilterProductID(Me.EnviroHealthSafety_Data.SDS, tempProductID)

            If Me.SDS_IDTextBox.Text = "" Or IsNothing(Me.SDS_IDTextBox.Text) Then
                Me.SDSBindingSource1.AddNew()
                Me.SDS_ActiveCheckBox.Checked = True
                Me.Product_IDComboBox.SelectedValue = tempProductID
            End If
            Me.ToolStripLabel1.Text = "SDS Card: " & Me.Product_IDComboBox.Text
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ValidateSDSCheckBox()
        Try
            If Me.SDS_ActiveCheckBox.CheckState = CheckState.Indeterminate Then
                'MsgBox("Uknowledge Check State = Intermediate")
                Me.SDS_ActiveCheckBox.CheckState = CheckState.Unchecked
                Me.SDS_ActiveCheckBox.Checked = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btn_SDSLink_Click(sender As Object, e As EventArgs) Handles btn_SDSLink.Click
        Try
            Process.Start(Me.SDS_LinkTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            ValidateSDSCheckBox()
            Me.Validate()
            Me.SDSBindingSource1.EndEdit()
            Me.SDSTableAdapter.Update(Me.EnviroHealthSafety_Data.SDS)
            MsgBox("SDS Record Saved")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Product_IDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class