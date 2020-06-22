Public Class frmProduct_Detail

    Dim savedCursor As Windows.Forms.Cursor
    Private currentProductTab As Form
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety_Data.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Manufacturer' table. You can move, or remove it, as needed.
        Me.Chemical_ManufacturerTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Manufacturer)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_ResponsibleParty' table. You can move, or remove it, as needed.
        Me.Chemical_ResponsiblePartyTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Product)

        If (CP_ProductID = 0 Or IsNothing(CP_ProductID)) Then
            Me.Chemical_ProductBindingSource.AddNew()
            Me.Product_HazWasteCheckBox.Checked = False
            Me.Product_ApprovedCheckBox.Checked = False
            Me.Product_InputDateDateTimePicker.Value = DateTime.Now
            Me.Product_IssueDateDateTimePicker.Value = DateTime.Now
            Me.Product_RevisedDateDateTimePicker.Value = DateTime.Now
            Me.Product_VerifiedDateDateTimePicker.Value = DateTime.Now
        Else
            Me.Chemical_ProductBindingSource.Position = Me.Chemical_ProductBindingSource.Find("Product_ID", CP_ProductID)
            TabChange_ProductPanel(frm_ChemicalProduct_SDS, False)
            'frm_ChemicalProduct_SDS.Chemical
        End If

        Refresh_dgvSearchProductID()

    End Sub

    Private Sub Refresh_dgvSearchProductID()
        Try
            If Not (Me.Product_IDTextBox.Text = "" Or IsNothing(Me.Product_IDTextBox.Text)) Then
                Me.Chemical_ResponsiblePartyTableAdapter.FillByProductID(Me.EnviroHealthSafety_Data.Chemical_ResponsibleParty, CInt(Me.Product_IDTextBox.Text))
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgv_AssociatedManufacturer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            'Dim ResponsibleParty_Value As Object = dgv_AssociatedManufacturer.Rows(e.RowIndex).Cells(0).Value

            'MsgBox("Value through Rows.Cells.Value: " & BuildingID_Value)

            'mod_ChemicalProduct.OpenAssociatedResponsibleParty(CInt(ResponsibleParty_Value))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ValidateProduct_DetailData()

        If Me.Product_ApprovedCheckBox.CheckState = CheckState.Indeterminate Then
            'MsgBox("Uknowledge Check State = Intermediate")
            Me.Product_ApprovedCheckBox.CheckState = CheckState.Unchecked
            Me.Product_ApprovedCheckBox.Checked = False
        End If

        If Me.Product_HazWasteCheckBox.CheckState = CheckState.Indeterminate Then
            Me.Product_HazWasteCheckBox.CheckState = CheckState.Unchecked
            Me.Product_HazWasteCheckBox.Checked = True
        End If

        If (Me.Product_NameTextBox.Text = "" Or IsNothing(Product_NameTextBox.Text)) Then
            MsgBox("Missing Product Name!")
        End If
    End Sub

    Private Sub tStrip_btnSave_Click(sender As Object, e As EventArgs) Handles tStrip_btnSave.Click
        Try
            Me.ValidateProduct_DetailData()
            Me.Validate()
            Me.Chemical_ProductBindingSource.EndEdit()
            Me.Chemical_ProductTableAdapter.Update(Me.EnviroHealthSafety_Data.Chemical_Product)

            MsgBox("Save Record! - frm_ProductDetail")
            If (CInt(Product_IDTextBox.Text) = -1) Then
                Me.Chemical_ProductTableAdapter.FillByProductNameExact(Me.EnviroHealthSafety_Data.Chemical_Product, Me.Product_NameTextBox.Text)

                mod_ChemicalProduct.SetCP_ProductID(CInt(Me.Product_IDTextBox.Text))

                TabChange_ProductPanel(frm_ChemicalProduct_SDS, False)
            End If
            'Refresh Data

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Error Saving Product Detail " & vbCrLf & ex.Message)
        End Try
    End Sub


    Private Sub TStrip_ProductDetail_MouseEnter(sender As Object, e As EventArgs) Handles TStrip_ProductDetail.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub TStrip_ProductDetail_MouseLeave(sender As Object, e As EventArgs) Handles TStrip_ProductDetail.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub

    Private Sub TabChange_ProductPanel(TabFormName As Form, closeForm As Boolean)
        Try
            If Not (IsNothing(currentProductTab)) Then

                If closeForm Then
                    currentProductTab.Close()
                Else
                    currentProductTab.Hide()
                End If

            End If

            currentProductTab = TabFormName
            TabFormName.TopLevel = False
            TabFormName.FormBorderStyle = FormBorderStyle.None
            TabFormName.Anchor = AnchorStyles.Bottom
            TabFormName.Dock = DockStyle.Fill
            Panel_TabProductDetail.Controls.Add(TabFormName)
            Panel_TabProductDetail.Tag = TabFormName
            TabFormName.BringToFront()
            TabFormName.Show()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Error TabChange_ProductPanel " & vbCrLf & ex.Message)
        End Try
    End Sub


    Private Sub TStrip_btnPreviousForm_Click(sender As Object, e As EventArgs) Handles TStrip_btnPreviousForm.Click
        mod_ChemicalProduct.PreviousProductForm()
    End Sub

    Private Sub btn_tabManufacturer_Click(sender As Object, e As EventArgs) Handles btn_tabManufacturer.Click
        TabChange_ProductPanel(New frmProduct_ResponsibleParty, True)
    End Sub

    Private Sub TStrip_lblPrevious_Click(sender As Object, e As EventArgs) Handles TStrip_lblPrevious.Click
        mod_ChemicalProduct.PreviousProductForm()
    End Sub

    Private Sub btn_tabSDSCard_Click(sender As Object, e As EventArgs) Handles btn_tabSDSCard.Click
        TabChange_ProductPanel(New frm_ChemicalProduct_SDS, True)
    End Sub

    Private Sub btn_tabCurrentLocation_Click(sender As Object, e As EventArgs) Handles btn_tabCurrentLocation.Click
        TabChange_ProductPanel(New frm_ChemicalProduct_Location, True)
    End Sub
End Class