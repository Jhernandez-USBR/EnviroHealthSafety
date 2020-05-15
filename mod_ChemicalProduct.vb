Module mod_ChemicalProduct

    Public Property CP_ProductID As Integer
    Public Property CP_ProductName As String
    Public Property CP_ProductHazardousWaste As Boolean
    Public Property CP_ProductApproved As Boolean
    Public Property CP_ProductApprover As Integer
    Public Property CP_ProductResponsibleParty As Integer
    Public Property CP_ProductLocationID
    Public Property CP_ManufacturerID As Integer

    Public Function GetApprover_Name(employee_ID As Integer)

        Dim userName As String = ""
        Return userName

    End Function

    Public Sub SetCP_ProductID(tempProductID As Integer)

        CP_ProductID = tempProductID
        'MsgBox("Product ID Set: " & CP_ProductID)
    End Sub

    Public Function GetCP_ProductLocationID() As Integer
        Return CP_ProductLocationID
    End Function

    Public Sub SetCP_ProductLocationID(tempProductLocationID As Integer)

        CP_ProductLocationID = tempProductLocationID
        'MsgBox("Product ID Set: " & CP_ProductID)
    End Sub

    Public Function GetCP_ProductID() As Integer
        Return CP_ProductID
    End Function

    Public Sub ChemcicalProduct_OpenMainForm(tempProductID As Integer)

        SetCP_ProductID(tempProductID)

        'MsgBox("Temp Physical Location ID: " & tempPhysicalLocationID)

        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frm_ChemicalProduct, False)

    End Sub

    Public Sub EditProductDetail(tempProductID As Integer)

        SetCP_ProductID(tempProductID)

        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frmProduct_Detail, False)

    End Sub

    Public Sub NewProductDetail()
        'Setting CP_Product_ID so when the form is open it knows to create new record
        SetCP_ProductID(0)

        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frmProduct_Detail, False)

    End Sub

    Public Sub NewAssociatedResponsibleParty(tempProductID As Integer)
        CP_ProductResponsibleParty = 0
        SetCP_ProductID(tempProductID)

        frm_EHSMain.Panel_EHSMain_Child.Select()
        frm_EHSMain.openMain_ChildForm(New frmProduct_ResponsibleParty, False)
    End Sub

    Public Sub OpenAssociatedResponsibleParty(tempResponsibleParty As Integer)
        CP_ProductResponsibleParty = tempResponsibleParty

        frm_EHSMain.Panel_EHSMain_Child.Select()
        frm_EHSMain.openMain_ChildForm(New frmProduct_ResponsibleParty, False)

    End Sub

    Public Sub PreviousProductForm()
        frm_EHSMain.showMain_ChildForm(frm_ProductInventory, True)
    End Sub
    Public Sub Product_SelectedManufacturer(temp_ManufacturerID As Integer)

        CP_ManufacturerID = temp_ManufacturerID

        frmProduct_Manufacturer.ShowDialog()

    End Sub
End Module
