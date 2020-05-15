Module mod_OfficeMaintenance

    Public Property tempRegionID As Integer
    Public Property tempOfficeID As Integer
    Public Property tempBuildingID As Integer
    Public Property tempPhysicalLocationID As Integer




    Public Sub setTempRegionID(uRegionID As Integer)
        If Not IsNothing(uRegionID) Then
            tempRegionID = uRegionID
        Else
            MsgBox("modOfficeMainentanence setTempRegionID was not set")
        End If
    End Sub

    Public Sub setTempOfficeID(uOfficeID As Integer)
        If Not IsNothing(uOfficeID) Then
            tempOfficeID = uOfficeID
        Else
            MsgBox("modOfficeMainentanence setTempOfficeID was not set")
        End If
    End Sub

    Public Sub setTempBuildingID(uBuildingID As Integer)
        If Not IsNothing(uBuildingID) Then
            tempBuildingID = uBuildingID
        Else
            MsgBox("modOfficeMainentanence setTempBuildingID was not set")
        End If
    End Sub

    Public Sub setTempPhysicalLocationID(uPhysicalLocationID As Integer)
        If Not IsNothing(uPhysicalLocationID) Then
            tempPhysicalLocationID = uPhysicalLocationID
        Else
            MsgBox("modOfficeMainentanence setTempPhysicalLocationID was not set")
        End If
    End Sub
    Public Sub Region_SelectedOffice(temp_OfficeID As Integer)

        setTempOfficeID(temp_OfficeID)

        'MsgBox("Temp Building ID: " & tempOfficeID)

        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frmOffice, False)

    End Sub

    Public Sub Region_SelectedBuilding(temp_BuildingID As Integer)

        setTempBuildingID(temp_BuildingID)

        'MsgBox("Temp Building ID: " & tempBuildingID)

        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frmOffice_Building, False)

    End Sub

    Public Sub Region_SelectedPhysicalLocation(temp_PhysicalLocationID As Integer)

        setTempPhysicalLocationID(temp_PhysicalLocationID)

        'MsgBox("Temp Physical Location ID: " & tempPhysicalLocationID)

        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frmOffice_PhysicalLocation, False)

    End Sub



End Module
