Imports System.Runtime.InteropServices

Public Class frm_EHSMain

    Public activeChildForm As Form = Nothing


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub



    Private Sub CustomizeDesign()

        Me.Panel_ProductSubmenu.Visible = False
        Me.Panel_WasteStreamSubMenu.Visible = False
        Me.Panel_AdministrativeSubMenu.Visible = False

    End Sub

    Private Sub HideSubmenu()

        If Panel_ProductSubmenu.Visible = True Then
            Panel_ProductSubmenu.Visible = False
        End If

        If Panel_WasteStreamSubMenu.Visible = True Then
            Panel_WasteStreamSubMenu.Visible = False
        End If

        If Panel_AdministrativeSubMenu.Visible = True Then
            Panel_AdministrativeSubMenu.Visible = False
        End If

    End Sub



    Private Sub btn_Product_Click(sender As Object, e As EventArgs) Handles btn_Product.Click
        If Panel_ProductSubmenu.Visible = True Then
            Panel_ProductSubmenu.Visible = False
        Else
            Call HideSubmenu()
            Panel_ProductSubmenu.Visible = True
        End If
    End Sub

    Private Sub btn_WasteStream_Click(sender As Object, e As EventArgs) Handles btn_WasteStream.Click
        If Panel_WasteStreamSubMenu.Visible = True Then
            Panel_WasteStreamSubMenu.Visible = False
        Else
            Call HideSubmenu()
            Panel_WasteStreamSubMenu.Visible = True
        End If
    End Sub

    Private Sub btn_Administrative_Click(sender As Object, e As EventArgs) Handles btn_Administrative.Click
        If Panel_AdministrativeSubMenu.Visible = True Then
            Panel_AdministrativeSubMenu.Visible = False
        Else
            Call HideSubmenu()
            Panel_AdministrativeSubMenu.Visible = True
        End If
    End Sub

    Public Sub openMain_ChildForm(childFormName As Form, closeForm As Boolean)

        If Not (IsNothing(activeChildForm)) Then

            If closeForm Then
                'MsgBox("OpenMain_ChildForm - CloseForm IF TRUE statement Statement being run")
                activeChildForm.Close()
            Else
                'MsgBox("OpenMain_ChildForm - CloseForm IF FALSE statement Statement being run")
                activeChildForm.Hide()
                'MsgBox("Active Child Form being hidden" & Me.activeChildForm.Text & "Hidden True: " & Me.activeChildForm.Visible.ToString)
            End If
            'MsgBox("OpenMain_ChildForm - After CloseForm IF statement Statement being run")

            activeChildForm = childFormName
            childFormName.TopLevel = False
            childFormName.FormBorderStyle = FormBorderStyle.None
            childFormName.Anchor = AnchorStyles.Bottom
            childFormName.Dock = DockStyle.Fill
            Panel_EHSMain_Child.Controls.Add(childFormName)
            Panel_EHSMain_Child.Tag = childFormName
            childFormName.BringToFront()
            childFormName.Show()
            lbl_HeaderText.Text = childFormName.Text

        Else
            'MsgBox("OpenMain_ChildForm - Else Statement being run")
            activeChildForm = childFormName
            childFormName.TopLevel = False
            childFormName.FormBorderStyle = FormBorderStyle.None
            childFormName.Dock = DockStyle.Fill
            Panel_EHSMain_Child.Controls.Add(childFormName)
            Panel_EHSMain_Child.Tag = childFormName
            childFormName.BringToFront()
            childFormName.Show()
            lbl_HeaderText.Text = childFormName.Text
        End If
    End Sub

    Public Sub showMain_ChildForm(activeFormName As Form, closeCurrentForm As Boolean)

        If closeCurrentForm Then
            activeChildForm.Close()
        Else
            activeChildForm.Hide()

        End If

        activeChildForm = activeFormName
        activeFormName.TopLevel = False
        activeFormName.FormBorderStyle = FormBorderStyle.None
        activeFormName.Anchor = AnchorStyles.Bottom
        activeFormName.Dock = DockStyle.Fill
        Panel_EHSMain_Child.Controls.Add(activeFormName)
        Panel_EHSMain_Child.Tag = activeFormName
        activeFormName.BringToFront()
        activeFormName.Show()
        lbl_HeaderText.Text = activeFormName.Text

    End Sub


    Private Sub btn_Product_SDSSearch_Click(sender As Object, e As EventArgs) Handles btn_Product_SDSSearch.Click

        openMain_ChildForm(New frm_SDSSearch, False)

        Call HideSubmenu()

    End Sub

    Private Sub btn_Product_ChemicalInventory_Click(sender As Object, e As EventArgs) Handles btn_Product_ChemicalInventory.Click
        openMain_ChildForm(New frm_ProductInventory, False)

        Call HideSubmenu()
    End Sub

    Private Sub btn_Product_NewProduct_Click(sender As Object, e As EventArgs) Handles btn_Product_NewProduct.Click
        mod_ChemicalProduct.NewProductDetail()
        Call HideSubmenu()
    End Sub

    Private Sub btn_Product_EditProduct_Click(sender As Object, e As EventArgs) Handles btn_Product_EditProduct.Click

        openMain_ChildForm(New frm_ChemicalProduct, True)

        Call HideSubmenu()
    End Sub

    Private Sub btn_WasteStream_1_Click(sender As Object, e As EventArgs) Handles btn_WasteStream_1.Click

        openMain_ChildForm(New frmWSC_Search, False)
        mod_WasteStreamCharacterization.mod_WSC_ID = 0
        Call HideSubmenu()
    End Sub

    Private Sub btn_WasteStream_2_Click(sender As Object, e As EventArgs) Handles btn_WasteStream_2.Click
        ' DO CODE ...
        ' -----------
        Call HideSubmenu()
    End Sub

    Private Sub btn_WasteStream_3_Click(sender As Object, e As EventArgs) Handles btn_WasteStream_3.Click
        'mod_WasteStreamCharacterization.OpenWSC_PreviousForm(Me.Name.ToString)
        New_OpenWSCDetails()
        Call HideSubmenu()
    End Sub

    Private Sub btn_WasteStream_4_Click(sender As Object, e As EventArgs) Handles btn_WasteStream_4.Click
        ' DO CODE ...
        ' -----------
        Call HideSubmenu()
    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        ' DO CODE ...
        ' -----------
        Call HideSubmenu()
    End Sub

    Private Sub btn_Administrative1_Click(sender As Object, e As EventArgs) Handles btn_Administrative1.Click
        openMain_ChildForm(New frm_Region, False)
        Call HideSubmenu()
    End Sub

    Private Sub btn_Administrative2_Click(sender As Object, e As EventArgs) Handles btn_Administrative2.Click



        Call HideSubmenu()
    End Sub

    Private Sub btn_Administrative3_Click(sender As Object, e As EventArgs) Handles btn_Administrative3.Click
        ' DO CODE ...
        ' -----------
        Call HideSubmenu()
    End Sub

    Private Sub btn_Administrative4_Click(sender As Object, e As EventArgs) Handles btn_Administrative4.Click
        ' DO CODE ...
        ' -----------
        Call HideSubmenu()
    End Sub

    Private Sub btn_Help_Click(sender As Object, e As EventArgs) Handles btn_Help.Click
        ' DO CODE ...
        ' -----------
        Call HideSubmenu()
    End Sub

    Private Sub frm_EHSMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_UserName.Text = "Welcome: " + SystemInformation.UserName
        txt_Date.Text = Format(Now, "Long Date")
        txt_Version.Text = "Version 1.0.1"
        mod_UserStartUp.LogUserOn()

    End Sub


    Private Sub frm_EHSMain_MinimumSizeChanged(sender As Object, e As EventArgs) Handles MyBase.MinimumSizeChanged
        Me.Panel_EHSMain_Child.AutoSize = True
    End Sub

    Private Sub Panel_EHSMain_Header_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_EHSMain_Header.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click


        Try
            For Each Form In My.Application.OpenForms
                If Form.name <> Me.Name Then
                    Form.Close()
                End If
            Next

            lbl_HeaderText.Text = "Home"
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_CloseDatabase_Click(sender As Object, e As EventArgs) Handles btn_CloseDatabase.Click
        Application.Exit()
    End Sub

    Private Sub btn_Maximize_Click(sender As Object, e As EventArgs) Handles btn_Maximize.Click

        If (WindowState = FormWindowState.Normal) Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click

        WindowState = FormWindowState.Minimized

    End Sub

    ' Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    ' End Of Drag Form

    Private Sub frm_EHSMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub


End Class

