Public Class frmProduct_ResponsibleParty


    Private Sub frmProduct_ResponsibleParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Manufacturer' table. You can move, or remove it, as needed.
        Me.Chemical_ManufacturerTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Manufacturer)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Product)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_ResponsibleParty' table. You can move, or remove it, as needed.

        Try
            If mod_ChemicalProduct.CP_ProductResponsibleParty = 0 Or
                IsNothing(mod_ChemicalProduct.CP_ProductResponsibleParty) Then

                If (mod_ChemicalProduct.CP_ProductID = 0 Or IsNothing(mod_ChemicalProduct.CP_ProductID)) Then
                    Me.Chemical_ResponsiblePartyTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty)
                    Me.Chemical_ResponsiblePartyBindingSource.AddNew()
                    Me.Product_IDComboBox.SelectedValue = mod_ChemicalProduct.CP_ProductID
                Else
                    Me.Chemical_ResponsiblePartyTableAdapter.FillByProductID(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty, CP_ProductID)

                    If (Me.Manufacturer_IDComboBox.Text = "" Or IsNothing(Me.Manufacturer_IDComboBox.Text)) Then
                        Me.Chemical_ResponsiblePartyTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty)
                        Me.Chemical_ResponsiblePartyBindingSource.AddNew()
                        Me.Product_IDComboBox.SelectedValue = mod_ChemicalProduct.CP_ProductID
                    Else
                        RefreshManufacturerPanel()
                    End If
                End If
            Else
                Me.Chemical_ResponsiblePartyTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty)
                Me.Chemical_ResponsiblePartyBindingSource.Position = Me.Chemical_ResponsiblePartyBindingSource.Find(
                    "ResponsibleParty_ID", mod_ChemicalProduct.CP_ProductResponsibleParty)
            End If

            If Not (IsNothing(Me.Manufacturer_IDComboBox.ValueMember.ToString) Or Me.Manufacturer_IDComboBox.Text = "") Then
                ToggleManufacturerPanel(True)
            Else
                ToggleManufacturerPanel(False)
            End If

            If Not (IsNothing(Me.Product_IDComboBox.Text) Or Me.Product_IDComboBox.Text = "") Then
                Me.TStrip_lbl_HeaderTitle.Text = "Manufacturer: " & Me.Product_IDComboBox.Text
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("frmProduct_ResponsibleParty_Load " & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub RefreshManufacturerPanel()
        Try
            If Not (IsNothing(Me.Manufacturer_IDComboBox) Or Me.Manufacturer_IDComboBox.Text = "") Then
                'MsgBox("Refresh Manufacturer ID: " & Manufacturer_IDComboBox.SelectedValue)
                Me.ChemicalManufacturerBindingSource.Position = Me.ChemicalManufacturerBindingSource.Find(
                "Manufacturer_ID", CInt(Manufacturer_IDComboBox.SelectedValue.ToString()))
                ToggleManufacturerPanel(True)
            Else
                ToggleManufacturerPanel(False)
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("RefreshManufacturerPanel " & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub ToggleManufacturerPanel(toggle As Boolean)
        Try
            Me.Panel_ManufacturerDetails.Enabled = toggle
            Me.Panel_ManufacturerDetails.Visible = toggle
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("ToggleManufacturerPanel " & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub IconToolStripButton1_Click(sender As Object, e As EventArgs) Handles IconToolStripButton1.Click
        Try
            Me.Validate()
            Me.Chemical_ResponsiblePartyBindingSource.EndEdit()
            Me.Chemical_ResponsiblePartyTableAdapter.Update(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty)
            MsgBox("Save Record! - frmProduct_ResponsibleParty")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Error Saving Product Detail " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Manufacturer_IDComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles Manufacturer_IDComboBox.SelectedValueChanged
        RefreshManufacturerPanel()
    End Sub

    Private Sub btn_EditManufacturer_Click(sender As Object, e As EventArgs) Handles btn_EditManufacturer.Click
        If Not IsNothing(Manufacturer_IDComboBox.SelectedValue) Then
            mod_ChemicalProduct.Product_SelectedManufacturer(CInt(Manufacturer_IDComboBox.SelectedValue.ToString))
        End If
    End Sub
End Class