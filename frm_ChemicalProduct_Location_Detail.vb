Public Class frm_ChemicalProduct_Location_Detail

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
    End Sub
    Private Sub Chemical_ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Chemical_ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety_Data)

    End Sub

    Private Sub frm_ChemicalProduct_Location_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety_Data.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Location' table. You can move, or remove it, as needed.
        Me.Chemical_LocationTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Location)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.tlkpOffice_PhysicalLocation' table. You can move, or remove it, as needed.
        Me.TlkpOffice_PhysicalLocationTableAdapter.Fill(Me.EnviroHealthSafety_Data.tlkpOffice_PhysicalLocation)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Product)

        ChemicalProduct_SetPhysicalLocation()

    End Sub



    Private Sub ChemicalProduct_SetPhysicalLocation()
        Try
            If Not (IsNothing(mod_ChemicalProduct.CP_ProductLocationID) Or mod_ChemicalProduct.CP_ProductLocationID = 0) Then
                Dim tempProductLocationID As Integer
                tempProductLocationID = mod_ChemicalProduct.GetCP_ProductLocationID
                'MsgBox("General GetProductID: " & tempProductID)
                Me.Chemical_LocationTableAdapter.FillByFilterPhysicalLocationID(Me.EnviroHealthSafety_Data.Chemical_Location, tempProductLocationID)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class