Public Class frmOffice_PhysicalLocation

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub
    Private Sub TlkpOffice_PhysicalLocationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TlkpOffice_PhysicalLocationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety)

    End Sub

    Public Sub openSpecificPhysicalLocation(tempLocationID As Integer)


    End Sub

    Private Sub frmOffice_PhysicalLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety.Chemical_Product)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.Chemical_Location' table. You can move, or remove it, as needed.
        Me.Chemical_LocationTableAdapter.Fill(Me.EnviroHealthSafety.Chemical_Location)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice_Building' table. You can move, or remove it, as needed.
        Me.TlkpOffice_BuildingTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice_Building)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice_PhysicalLocation' table. You can move, or remove it, as needed.
        Me.TlkpOffice_PhysicalLocationTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice_PhysicalLocation)

        Try
            If Not IsNothing(mod_OfficeMaintenance.tempPhysicalLocationID) Then
                Me.TlkpOffice_PhysicalLocationBindingSource.Position = Me.TlkpOffice_PhysicalLocationBindingSource.Find("PhysicalLocation_ID", mod_OfficeMaintenance.tempPhysicalLocationID)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        DataGridChemicalProductRefresh()

    End Sub

    Private Sub IconToolStripButton2_Click(sender As Object, e As EventArgs) Handles IconToolStripButton2.Click

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PhysicalLocation_DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhysicalLocation_DescriptionTextBox.TextChanged

    End Sub
    Private Sub DataGridChemicalProductRefresh()
        Try
            Me.Chemical_LocationTableAdapter.FillByPhysicalLocationFilter(Me.EnviroHealthSafety.Chemical_Location, New System.Nullable(Of Integer)(CType(Me.txtPhysicalLocation_ID.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class