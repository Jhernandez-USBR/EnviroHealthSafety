Public Class frm_ChemicalProduct_General


    Private Sub ChemicalProduct_SetProductID()
        Try
            Dim tempProductID As Integer
            tempProductID = mod_ChemicalProduct.GetCP_ProductID
            'MsgBox("General GetProductID: " & tempProductID)
            Me.Qry_ChemicalProduct_SDSGeneralTableAdapter.Fill(Me.EnviroHealthSafety.qry_ChemicalProduct_SDSGeneral, tempProductID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frm_ChemicalProduct_General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChemicalProduct_SetProductID()
    End Sub

    Private Sub btn_ViewSDS_Click(sender As Object, e As EventArgs) Handles btn_ViewSDS.Click
        Try
            If (IsNothing(Me.txtSDS_NetworkPath.Text) Or Me.txtSDS_NetworkPath.Text = "") Then
                MsgBox("There is no Network Link / PDF associated with this SDS...",, "No SDS PDF on Network Drive!")
            Else
                Process.Start(Me.txtSDS_NetworkPath.Text)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_WebsiteOpen_Click(sender As Object, e As EventArgs) Handles btn_WebsiteOpen.Click

    End Sub


End Class