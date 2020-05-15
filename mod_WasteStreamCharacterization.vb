Module mod_WasteStreamCharacterization

    Public Property mod_WSC_ID As Integer
    Public Property WSCPreviousForm_SearchWSC As Boolean
    Public Property WSCPreviousForm_EditDetails As Boolean
    Public Property WSCPreviousForm_Default As Boolean



    Public Sub Set_WSCID(subWSC_ID As Integer)
        Try
            mod_WSC_ID = subWSC_ID
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: Set_WSCID" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Function Get_WSCID() As Integer
        Try

            If IsNothing(mod_WSC_ID) Then
                MsgBox("Public Get WSC_ID has not set tempWSC_ID Public Property!")
                Set_WSCID(0)
            Else
                Return mod_WSC_ID
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: Get_WSCID" & vbCrLf & ex.Message)
        End Try

        Return mod_WSC_ID

    End Function


    Public Sub WSC_OpenWPD(tempWSCID As Integer)
        Try
            Set_WSCID(tempWSCID)
            frm_EHSMain.Panel_EHSMain_Child.Select()
            frm_EHSMain.openMain_ChildForm(New frmWSC_WPD, False)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: WSC_OpenWPD" & vbCrLf & ex.Message)
        End Try

    End Sub

    Public Sub Search_OpenWSCDetails(tempWSCID As Integer)
        Try
            Set_WSCID(tempWSCID)
            frm_EHSMain.Panel_EHSMain_Child.Select()

            frm_EHSMain.openMain_ChildForm(New frmWSC, False)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: Search_OpenWSCDetails" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub OpenWSC_PreviousForm(tempPreviousFormName As String)
        Try
            If tempPreviousFormName = "frmWSC_Search" Then
                WSCPreviousForm_SearchWSC = True
                WSCPreviousForm_EditDetails = False
                WSCPreviousForm_Default = False
            ElseIf tempPreviousFormName = "frmWSC_Edit" Then
                WSCPreviousForm_SearchWSC = False
                WSCPreviousForm_EditDetails = True
                WSCPreviousForm_Default = False
            Else
                WSCPreviousForm_SearchWSC = False
                WSCPreviousForm_EditDetails = True
                WSCPreviousForm_Default = False
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: OpenWSC_PreviousForm" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub New_OpenWSCDetails()
        Try
            Set_WSCID(0)
            frm_EHSMain.Panel_EHSMain_Child.Select()
            frm_EHSMain.openMain_ChildForm(New frmWSC, False)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Routine Name: New_OpenWSCDetails" & vbCrLf & ex.Message)
        End Try
    End Sub

End Module
