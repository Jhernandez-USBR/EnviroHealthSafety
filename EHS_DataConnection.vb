Imports System.Data.SqlClient


Module EHS_DataConnection
    Public sql_String As String = GetConnectionString()
    Public connection As New SqlConnection(sql_String)
    Public cmd As SqlCommand
    Public data_Adapter As SqlDataAdapter
    Public data_Sheet As DataSet
    Public binding_Source As BindingSource
    Public sql_Query As String

    Public Function GetConnectionString() As String
        Return "SERVER=IBR4ucrdb103;DATABASE=EnvroHealthSafetydb;Integrated Security=True"
    End Function

End Module
