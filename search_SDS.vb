Module search_SDS

    Public Property searchString As String


    Public Function getSearchSQLString() As String
        If Not IsNothing(searchString) Then
            Return searchString
        Else
            Return ""
        End If
    End Function


    Public Sub search_SDSFilter(strFilter As String)

        searchString = strFilter
        'Set Forcus on the Child Panel of the Main Forms
        frm_EHSMain.Panel_EHSMain_Child.Select()

        frm_EHSMain.openMain_ChildForm(New frm_SDSResult, False)

    End Sub




End Module
