Public Class frmWSC_WSD_Identification


    Private Sub frmWSC_WSD_Identification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpCHW_Toxic_Constituent' table. You can move, or remove it, as needed.
        Me.TlkpCHW_Toxic_ConstituentTableAdapter.Fill(Me.EnviroHealthSafety.tlkpCHW_Toxic_Constituent)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.WSC_CHW_ToxicConstituent' table. You can move, or remove it, as needed.
        Me.WSC_CHW_ToxicConstituentTableAdapter.Fill(Me.EnviroHealthSafety.WSC_CHW_ToxicConstituent)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.WSC_CHW' table. You can move, or remove it, as needed.
        Me.WSC_CHWTableAdapter.Fill(Me.EnviroHealthSafety.WSC_CHW)
        Me.WSC_LHW_PListTableAdapter.Fill(Me.EnviroHealthSafety.WSC_LHW_PList)
        Me.WSC_LHW_KListTableAdapter.Fill(Me.EnviroHealthSafety.WSC_LHW_KList)
        Me.TlkpLHW_PUTableAdapter.Fill(Me.EnviroHealthSafety.tlkpLHW_PU)
        Me.WSC_LHW_UListTableAdapter.Fill(Me.EnviroHealthSafety.WSC_LHW_UList)
        Me.TlkpLHW_FKTableAdapter.Fill(Me.EnviroHealthSafety.tlkpLHW_FK)
        Me.WSC_LHW_FListTableAdapter.Fill(Me.EnviroHealthSafety.WSC_LHW_FList)
        Me.WSC_LHWTableAdapter.Fill(Me.EnviroHealthSafety.WSC_LHW)
        Me.WSC_SW_261_2TableAdapter.Fill(Me.EnviroHealthSafety.WSC_SW_261_2)

        Dim Position261_2 As Integer
        Dim Position261_4 As Integer
        Dim PositionLHW As Integer
        'Dim PositionCHW As Integer

        Position261_2 = Me.WSC_SW_261_2BindingSource.Find("WSC_ID", mod_WasteStreamCharacterization.mod_WSC_ID)
        Position261_4 = Me.WSC_SWE_261_4BindingSource.Find("WSC_ID", mod_WasteStreamCharacterization.mod_WSC_ID)
        PositionLHW = Me.WSC_LHWBindingSource.Find("WSC_ID", mod_WasteStreamCharacterization.mod_WSC_ID)


        If Position261_2 = -1 Then
            Me.WSC_SW_261_2BindingSource.AddNew()
            Me.WSC_IDTextBox.Text = mod_WasteStreamCharacterization.mod_WSC_ID
            If Position261_4 = -1 Then
                Me.WSC_SWE_261_4BindingSource.AddNew()
                Me.WSC_IDTextBox1.Text = mod_WasteStreamCharacterization.mod_WSC_ID
            Else
                Me.WSC_SWE_261_4BindingSource.Position = Position261_4

            End If
        Else
            Me.WSC_SW_261_2BindingSource.Position = Position261_2

            If Position261_4 = -1 Then
                Me.WSC_SWE_261_4BindingSource.Position = Position261_4
            Else
                Me.WSC_SWE_261_4BindingSource.AddNew()
                Me.WSC_IDTextBox1.Text = mod_WasteStreamCharacterization.mod_WSC_ID
            End If

        End If

        Try
            If (Me.Solid_261_2CheckBox.Checked) Then

                Me.rbtn_261_2Yes.Checked = True

                'Load 261.4 Table
                If Not (Me.Excluded_S261_4vExemptCheckBox.Checked) Then
                    Me.rbtn_261_4No.Checked = True
                    Me.Panel_ListedHazardousWaste.Visible = True
                    Me.Panel_ListedHazardousWaste.BringToFront()
                    Me.Panel_Listed_Control.Visible = True
                    Me.Panel_Listed_Control.BringToFront()
                Else
                    Me.rbtn_261_2Yes.Checked = True
                    Me.Panel_ExcludedWaste_Detail.Visible = True
                End If
                Me.Panel_ExcludedWaste.Visible = True
                Me.Panel_SolidWaste.Visible = True
            Else
                Me.rbtn_261_2No.Checked = True
                Me.Panel_SolidWaste_Details.Visible = True
                Me.Panel_SolidWaste.Visible = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToggleRbtn_261_2(toggle As Boolean)
        Try
            If toggle Then

                If Me.Panel_SolidWaste_Details.Visible Then
                    Me.Panel_SolidWaste_Details.Visible = False
                End If

                If Not (Me.Solid_261_2CheckBox.Checked) Then
                    Me.Solid_261_2CheckBox.Checked = True
                End If

                If Not Me.Panel_ExcludedWaste.Visible Then
                    Me.Panel_ExcludedWaste.Visible = True
                End If
            Else

                If Not (Me.Panel_SolidWaste_Details.Visible) Then
                    Me.Panel_SolidWaste_Details.Visible = True
                End If

                If Me.Solid_261_2CheckBox.Checked Then
                    Me.Solid_261_2CheckBox.Checked = False
                End If

                If Me.Panel_ExcludedWaste.Visible Then
                    Me.Panel_ExcludedWaste.Visible = False
                    'If 261.4 record exists Delete it
                End If


            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub rbtn_261_2Yes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_261_2Yes.CheckedChanged
        Try
            If Me.rbtn_261_2Yes.Checked = True Then
                ToggleRbtn_261_2(True)
            Else
                ToggleRbtn_261_2(False)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub rbtn_261_2No_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_261_2No.CheckedChanged
        Try
            If Me.rbtn_261_2No.Checked = True Then
                ToggleRbtn_261_2(False)
            Else
                ToggleRbtn_261_2(True)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToggleRbtn_261_4(toggle As Boolean)
        Try
            If toggle Then

                If Not Me.Panel_ExcludedWaste_Detail.Visible Then

                    If Me.Panel_ListedHazardousWaste.Visible Then
                        Me.Panel_ListedHazardousWaste.Visible = False
                        Me.Panel_Listed_Control.Visible = False
                    End If

                    Me.Panel_ExcludedWaste_Detail.Visible = True
                    Me.Panel_ExcludedWaste_Detail.BringToFront()
                End If
            Else
                If Me.Panel_ExcludedWaste_Detail.Visible Then
                    Me.Panel_ExcludedWaste_Detail.Visible = False
                End If

                If Not Me.Panel_ListedHazardousWaste.Visible Then
                    Me.Panel_ListedHazardousWaste.Visible = True
                    Me.Panel_ListedHazardousWaste.BringToFront()

                    Me.Panel_Listed_Control.Visible = True
                    Me.Panel_Listed_Control.BringToFront()

                    Me.Panel_CharacteristicWaste.Visible = True
                    Me.Panel_CharacteristicWaste.BringToFront()

                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub rbtn_261_4Yes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_261_4Yes.CheckedChanged
        Try
            If Me.rbtn_261_4Yes.Checked = True Then
                ToggleRbtn_261_4(True)
            Else
                ToggleRbtn_261_4(False)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub rbtn_261_4No_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_261_4No.CheckedChanged
        Try
            If Me.rbtn_261_4No.Checked = True Then
                ToggleRbtn_261_4(False)
            Else
                ToggleRbtn_261_4(True)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub





    Private Sub Refresh_dgv_FListed()
        Try

            If Not (Me.WSC_LHW_IDTextBox.Text = "") Then
                MsgBox("Refresh dgv - F Listed")
                Me.WSC_LHW_FListTableAdapter.FillByFilterWSCID(Me.EnviroHealthSafety.WSC_LHW_FList, CInt(Me.WSC_LHW_IDTextBox.Text))
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FListedPanelShow(toggle As Boolean)
        Try
            If toggle Then
                Me.Panel_dgv_FListed.Visible = True
            Else
                If Me.Panel_dgv_FListed.Visible Then
                    'Delete Records if they exist
                    Me.Panel_dgv_FListed.Visible = False
                End If

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToggleRbtn_FListed(toggle As Boolean)
        Try
            If toggle Then
                Me.Panel_dgv_FListed.Visible = True
                Refresh_dgv_FListed()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_dgvViewFListed_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.WSC_LHW_FListCheckBox.Checked Then
            If Me.Panel_dgv_FListed.Visible Then
                Me.Panel_dgv_FListed.Visible = False
            Else
                Me.Panel_dgv_FListed.Visible = True
            End If
        End If

    End Sub

    Private Sub btn_dgvViewUListed_Click(sender As Object, e As EventArgs) Handles btn_dgvViewUListed.Click
        If Me.WSC_LHW_UListCheckBox.Checked Then
            If Me.Panel_dgv_UListed.Visible Then
                Me.Panel_dgv_UListed.Visible = False
            Else
                Me.Panel_dgv_UListed.Visible = True
            End If
        End If
    End Sub

    Private Sub btn_dgvViewKListed_Click(sender As Object, e As EventArgs) Handles btn_dgvViewKListed.Click
        If Me.WSC_LHW_KListCheckBox.Checked Then
            If Me.Panel_dgv_KListed.Visible Then
                Me.Panel_dgv_KListed.Visible = False
            Else
                Me.Panel_dgv_KListed.Visible = True
            End If
        End If
    End Sub

    Private Sub btn_dgvViewPListed_Click(sender As Object, e As EventArgs) Handles btn_dgvViewPListed.Click
        If Me.WSC_LHW_PListCheckBox.Checked Then
            If Me.Panel_dgv_PListed.Visible Then
                Me.Panel_dgv_PListed.Visible = False
            Else
                Me.Panel_dgv_PListed.Visible = True
            End If
        End If
    End Sub


End Class