Imports System.Data.SqlClient
Public Class frm_SDSResult

    Public Property searchSQLString As String


    Public Sub setSearchSQLString(searchSQL As String)
        searchSQLString = searchSQL
    End Sub


    Private Sub frm_SDSResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.Chemical_Product' table. You can move, or remove it, as needed.
        Me.Chemical_ProductTableAdapter.Fill(Me.EnviroHealthSafety_Data.Chemical_Product)
        'TODO: This line of code loads data into the 'EnviroHealthSafety_Data.SDS' table. You can move, or remove it, as needed.
        'Me.SDSTableAdapter.Fill(Me.EnviroHealthSafety_Data.SDS)

        On Error GoTo Err_ErrorHandler

        connection.Open()

        Dim search_Name As String = getSearchSQLString()
        Dim search_Manufacturer As String = ""
        Dim search_SDSNumber As String = ""

        'MsgBox(getSearchSQLString())
        Dim varname1 = ""
        varname1 = varname1 & "SELECT Chemical_Product.Product_ID, Chemical_Product.Product_Name, SDS.SDS_Number, SDS.SDS_ProductCode, Chemical_Manufacturer.Manufacturer_Name " & vbCrLf
        varname1 = varname1 & "FROM     Chemical_ResponsibleParty, Chemical_Manufacturer, SDS, Chemical_Product " & vbCrLf
        varname1 = varname1 & "WHERE  Chemical_ResponsibleParty.Manufacturer_ID = Chemical_Manufacturer.Manufacturer_ID AND SDS.Product_ID = Chemical_Product.Product_ID AND " & search_Name
        MsgBox(varname1)

        sql_Query = varname1

        'MsgBox("SQL Query" & sql_Query)

        Using cmd = New SqlCommand(sql_Query, connection)
            Using data_Adapter = New SqlDataAdapter(cmd)
                data_Sheet = New DataSet
                data_Adapter.Fill(data_Sheet, "Product")

                dgv_SDSResult.DataSource = data_Sheet.Tables("Product")

                binding_Source = New BindingSource
                binding_Source.DataSource = data_Sheet.Tables("Product")
            End Using
        End Using
        connection.Close()


        ' General Error Handler
        '---------------------------------------------
Exit_ErrorHandler:                          ' Label to resume after error.
        Exit Sub                                ' Exit before error handler.

Err_ErrorHandler:                           ' Label to jump to on error.
        MsgBox(Err.Number & Err.Description)    ' Place error handling here.
        Resume Exit_ErrorHandler                ' Pick up again and quit.
        '---------------------------------------------

    End Sub

    Private Sub frm_SDSResult_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(getSearchSQLString())
    End Sub

    Private Sub dgv_SDSResult_DoubleClick(sender As Object, e As EventArgs) Handles dgv_SDSResult.DoubleClick

    End Sub

    Private Sub dgv_SDSResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SDSResult.CellContentClick

    End Sub
End Class