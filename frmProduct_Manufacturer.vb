Public Class frmProduct_Manufacturer

    Private Property dataChanged As Boolean
    Dim savedCursor As Windows.Forms.Cursor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
    End Sub
    Private Sub frmProduct_Manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Manufacturer' table. You can move, or remove it, as needed.
        Me.Chemical_ManufacturerTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Manufacturer)

        If Not (IsNothing(mod_ChemicalProduct.CP_ManufacturerID) Or mod_ChemicalProduct.CP_ManufacturerID = 0) Then
            Me.Chemical_ManufacturerBindingSource.Position = Me.Chemical_ManufacturerBindingSource.Find("Manufacturer_ID", mod_ChemicalProduct.CP_ManufacturerID)
            Me.TStrip_lbl_HeaderText.Text = Me.Manufacturer_NameTextBox.Text
        Else
            Me.Chemical_ManufacturerBindingSource.AddNew()
            Me.TStrip_lbl_HeaderText.Text = "New Manufacturer"
        End If

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Me.ValidateManufacturerDetail()
        Me.Validate()
        Me.Chemical_ManufacturerBindingSource.EndEdit()
        Me.Chemical_ManufacturerTableAdapter.Update(Me.EnviroHealthSafety_Data.Chemical_Manufacturer)
    End Sub

    Private Sub ValidateManufacturerDetail()
        If Me.Manufacturer_NameTextBox.Text = "" Then
            MsgBox("Missing Manufacturer Name!" & vbCrLf & "Can not save/update record until Name has been inputted!")
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Dispose()
    End Sub


    Private Sub IconToolStripButton1_MouseEnter(sender As Object, e As EventArgs) Handles btn_Undo.MouseEnter, btn_Save.MouseEnter, btn_Close.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub IconToolStripButton1_MouseLeave(sender As Object, e As EventArgs) Handles btn_Undo.MouseLeave, btn_Save.MouseLeave, btn_Close.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub
End Class