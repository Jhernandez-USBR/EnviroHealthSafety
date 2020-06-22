Public Class frm_SDSSearch
    Private Sub frm_SDSSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        Call txtSearchBox_Clear()

    End Sub
    Private Sub txtSearchBox_Clear()

        On Error GoTo Err_ErrorHandler

        Me.txt_SearchSubstance.Text = "Enter substance name"
        Me.txt_SearchManufacturer.Text = "Enter manufacturer name"
        Me.txt_SearchSDSNo.Text = "Enter SDS or Product ID"

        Txt_SearchSubstance_Disable(False)
        Txt_SearchManufacturer_Disable(False)
        Txt_SearchSDSNo_Disable(False)

        ' General Error Handler
        '---------------------------------------------
Exit_ErrorHandler:                          ' Label to resume after error.
        Exit Sub                                ' Exit before error handler.

Err_ErrorHandler:                           ' Label to jump to on error.
        MsgBox(Err.Number & Err.Description)    ' Place error handling here.
        Resume Exit_ErrorHandler                ' Pick up again and quit.
        '---------------------------------------------
    End Sub

    Private Sub btn_SDSClear_Click(sender As Object, e As EventArgs) Handles btn_SDSClear.Click
        Call txtSearchBox_Clear()
    End Sub

    Private Sub btn_SDSSearch_Click(sender As Object, e As EventArgs) Handles btn_SDSSearch.Click
        On Error GoTo Err_ErrorHandler

        'Call search_SDSFilter(strFilter)
        If Not (Me.txt_SearchSubstance.Text = "Enter substance name" Or Me.txt_SearchSubstance.Text = "") Then
            SearchSubstance()
        ElseIf Not (Me.txt_SearchManufacturer.Text = "Enter manufacturer name" Or Me.txt_SearchManufacturer.Text = "") Then
            SearchManufacturer()
        ElseIf Not (Me.txt_SearchSDSNo.Text = "Enter SDS or Product ID" Or Me.txt_SearchSDSNo.Text = "") Then
            SearchSDSNumber()
        Else
            SearchDefault()
        End If


        ' General Error Handler
        '---------------------------------------------
Exit_ErrorHandler:                          ' Label to resume after error.
        Exit Sub                                ' Exit before error handler.

Err_ErrorHandler:                           ' Label to jump to on error.
        MsgBox(Err.Number & Err.Description)     ' Place error handling here.
        Resume Exit_ErrorHandler                ' Pick up again and quit.
        '---------------------------------------------
    End Sub

    Private Sub Txt_SearchSubstance_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchSubstance.TextChanged

    End Sub

    Private Sub Txt_SearchSubstance_Click(sender As Object, e As EventArgs) Handles txt_SearchSubstance.Click
        If txt_SearchSubstance.Text = "Enter substance name" Then
            txt_SearchSubstance.Text = ""
        End If
    End Sub

    Private Sub Txt_SearchSubstance_Leave(sender As Object, e As EventArgs) Handles txt_SearchSubstance.Leave
        If txt_SearchSubstance.Text = "" Then
            txt_SearchSubstance.Text = "Enter substance name"
            Txt_SearchManufacturer_Disable(False)
            Txt_SearchSDSNo_Disable(False)
        Else
            Txt_SearchManufacturer_Disable(True)
            Txt_SearchSDSNo_Disable(True)
        End If
    End Sub

    Private Sub Txt_SearchManufacturer_Disable(disableTextBox As Boolean)

        If disableTextBox Then
            txt_SearchManufacturer.Enabled = False
        Else
            txt_SearchManufacturer.Enabled = True
        End If

    End Sub
    Private Sub Txt_SearchSubstance_Disable(disableTextBox As Boolean)

        If disableTextBox Then
            txt_SearchSubstance.Enabled = False

        Else
            txt_SearchSubstance.Enabled = True
        End If

    End Sub
    Private Sub Txt_SearchSDSNo_Disable(disableTextBox As Boolean)

        If disableTextBox Then
            txt_SearchSDSNo.Enabled = False

        Else
            txt_SearchSDSNo.Enabled = True
        End If

    End Sub

    Private Sub Txt_SearchManufacturer_Click(sender As Object, e As EventArgs) Handles txt_SearchManufacturer.Click
        If txt_SearchManufacturer.Text = "Enter manufacturer name" Then
            txt_SearchManufacturer.Text = ""
        End If
    End Sub

    Private Sub Txt_SearchManufacturer_Leave(sender As Object, e As EventArgs) Handles txt_SearchManufacturer.Leave
        If txt_SearchManufacturer.Text = "" Then
            txt_SearchManufacturer.Text = "Enter manufacturer name"
            Txt_SearchSubstance_Disable(False)
            Txt_SearchSDSNo_Disable(False)
        Else
            Txt_SearchSubstance_Disable(True)
            Txt_SearchSDSNo_Disable(True)
        End If
    End Sub

    Private Sub Txt_SearchSDSNo_Click(sender As Object, e As EventArgs) Handles txt_SearchSDSNo.Click
        If txt_SearchSDSNo.Text = "Enter SDS or Product ID" Then
            txt_SearchSDSNo.Text = ""
        End If
    End Sub

    Private Sub Txt_SearchSDSNo_Leave(sender As Object, e As EventArgs) Handles txt_SearchSDSNo.Leave
        If txt_SearchSDSNo.Text = "" Then
            txt_SearchSDSNo.Text = "Enter SDS or Product ID"
            Txt_SearchSubstance_Disable(False)
            Txt_SearchManufacturer_Disable(False)
        Else
            Txt_SearchSubstance_Disable(True)
            Txt_SearchManufacturer_Disable(True)
        End If
    End Sub


    Private Sub SearchSubstance()
        Try
            Me.Qry_SearchProductManufacturerTableAdapter.FillBySearchProductName(Me.EnviroHealthSafety_Data.qry_SearchProductManufacturer, txt_SearchSubstance.Text
                                                                               )
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchManufacturer()
        Try
            Me.Qry_SearchProductManufacturerTableAdapter.FillBySearchByManufacturer(Me.EnviroHealthSafety_Data.qry_SearchProductManufacturer, txt_SearchManufacturer.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SearchSDSNumber()
        Try
            Me.Qry_SearchProductManufacturerTableAdapter.FillBySearchSDSNumber(Me.EnviroHealthSafety_Data.qry_SearchProductManufacturer, txt_SearchSDSNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SearchDefault()
        Try
            Me.Qry_SearchProductManufacturerTableAdapter.Fill(Me.EnviroHealthSafety_Data.qry_SearchProductManufacturer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgv_ProductListResult_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ProductListResult.CellDoubleClick
        Try
            Dim tempProductID_Value As Object = dgv_ProductListResult.Rows(e.RowIndex).Cells(0).Value

            ChemcicalProduct_OpenMainForm(Convert.ToInt32(tempProductID_Value))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class