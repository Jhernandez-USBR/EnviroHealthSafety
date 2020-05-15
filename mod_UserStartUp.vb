Imports System.Data.SqlClient

Module mod_UserStartUp
    Public Property UserName As String
    Public Property UserID As Integer

    Public Sub LogUserOn()

        SetUserID()

        Dim sqlLogUser As String

        sqlLogUser = ""
        sqlLogUser = sqlLogUser & "INSERT INTO [EnvroHealthSafetydb].[dbo].[ztbl_Dev_LoginHistory] ([UserID], [Login_Date], [Login_Time]) VALUES (" & UserID & ", '" & Date.Now & "', '" & DateTime.Now & "')"

        Dim con As New SqlConnection(GetConnectionString())
        Dim cmd As New SqlCommand

        Try

            cmd = New SqlCommand(sqlLogUser, con)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetUserID()
        Dim con As New SqlConnection(GetConnectionString())
        Dim cmd As New SqlCommand

        UserName = GetUserName()

        Try
            Dim sqlSetUserID As String

            sqlSetUserID = ""
            sqlSetUserID = sqlSetUserID & "SELECT TOP 1 Employee_ID, Employee_Email " & vbCrLf
            sqlSetUserID = sqlSetUserID & "FROM     EnvroHealthSafetydb.dbo.ztbl_Employee " & vbCrLf
            sqlSetUserID = sqlSetUserID & "WHERE  (Employee_Email = '" & UserName & "')"

            'MsgBox("SQL Statement" & varname1)

            cmd = New SqlCommand(sqlSetUserID, con)
            con.Open()
            UserID = cmd.ExecuteScalar
            cmd.Dispose()
            con.Close()

            If IsNothing(UserID) Then
                MsgBox("User: " & UserName & vbCrLf &
                       "Attemping to access Enviornmental Health & Safety Database" & vbCrLf &
                       "User Does not have profile in Employee Table! Contact Database Administrator")
                Application.Exit()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function GetUserName() As String
        Return SystemInformation.UserName.ToString
    End Function

End Module
