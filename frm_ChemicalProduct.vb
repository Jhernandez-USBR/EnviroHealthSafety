Imports System.Data.SqlClient

Public Class frm_ChemicalProduct
    Dim savedCursor As Windows.Forms.Cursor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub


    Private activeChildForm As Form = Nothing
    Private Sub frm_ChemicalProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.ztbl_Employee' table. You can move, or remove it, as needed.
        Me.Ztbl_EmployeeTableAdapter.Fill(Me.EnviroHealthSafety.ztbl_Employee)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety.Chemical_Product)

        Try
            If Not IsNothing(mod_ChemicalProduct.CP_ProductID) Then

                Me.ChemicalProductBindingSource.Position = Me.ChemicalProductBindingSource.Find("Product_ID", mod_ChemicalProduct.CP_ProductID)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If Not IsNothing(txt_ProductID.Text) Then
            mod_ChemicalProduct.SetCP_ProductID(CInt(txt_ProductID.Text))
        End If

        If Me.txt_Approved.Text = "True" Then
            Me.txt_Approved.Text = "Yes"
        Else
            Me.txt_Approved.Text = "No"
        End If

        If Me.txt_HazardousWaste.Text = "True" Then
            Me.txt_HazardousWaste.Text = "Yes"
        Else
            Me.txt_HazardousWaste.Text = "No"
        End If

        openSDS_ChildForm(frm_ChemicalProduct_General, True)
    End Sub

    Private Sub frm_ChemicalProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        connection.Close()
    End Sub

    Private Sub btn_SDSGeneral_Click(sender As Object, e As EventArgs) Handles btn_SDSGeneral.Click
        openSDS_ChildForm(New frm_ChemicalProduct_General, False)
    End Sub

    Public Sub openSDS_ChildForm(childFormName As Form, closeForm As Boolean)

        If Not (IsNothing(activeChildForm)) Then
            If closeForm Then
                activeChildForm.Close()
            Else
                activeChildForm.Hide()
            End If
            activeChildForm = childFormName
            childFormName.TopLevel = False
            childFormName.FormBorderStyle = FormBorderStyle.None
            childFormName.Anchor = AnchorStyles.Bottom
            childFormName.Dock = DockStyle.Fill
            panel_ChemicalProductChild.Controls.Add(childFormName)
            panel_ChemicalProductChild.Tag = childFormName
            childFormName.BringToFront()
            childFormName.Show()
        Else
            activeChildForm = childFormName
            childFormName.TopLevel = False
            childFormName.FormBorderStyle = FormBorderStyle.None
            childFormName.Dock = DockStyle.Fill
            panel_ChemicalProductChild.Controls.Add(childFormName)
            panel_ChemicalProductChild.Tag = childFormName
            childFormName.BringToFront()
            childFormName.Show()
        End If
    End Sub

    Private Sub btn_SDSOther_Click(sender As Object, e As EventArgs) Handles btn_SDSOther.Click
        openSDS_ChildForm(New frm_ChemicalProduct_SDS, True)
    End Sub

    Private Sub btn_CurrentLocation_Click(sender As Object, e As EventArgs) Handles btn_CurrentLocation.Click
        openSDS_ChildForm(New frm_ChemicalProduct_Location, True)
    End Sub

    Private Sub btn_LibraryCard_Click(sender As Object, e As EventArgs) Handles btn_LibraryCard.Click
        openSDS_ChildForm(New frm_ChemicalProduct_Library, True)
    End Sub

    Private Sub Chemical_ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ChemicalProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnviroHealthSafety)

    End Sub


    Public Function GetProduct_ID() As Integer
        MsgBox(txt_ProductID.Text)

        Return CInt(txt_ProductID.Text)

    End Function


    Private Sub btn_BackSearchProduct_Click(sender As Object, e As EventArgs) Handles btn_BackSearchProduct.Click
        frm_EHSMain.showMain_ChildForm(frm_SDSSearch, True)
    End Sub


    Private Sub tStrip_Office_MouseEnter(sender As Object, e As EventArgs) Handles tStrip_Office.MouseEnter
        If savedCursor Is Nothing Then
            savedCursor = Me.Cursor
            Me.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub tStrip_Office_MouseLeave(sender As Object, e As EventArgs) Handles tStrip_Office.MouseLeave
        Me.Cursor = savedCursor
        savedCursor = Nothing
    End Sub
End Class