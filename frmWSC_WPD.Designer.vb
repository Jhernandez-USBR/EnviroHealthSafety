<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWSC_WPD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WSC_DescriptionLabel As System.Windows.Forms.Label
        Dim WSC_WasteGenerationLabel As System.Windows.Forms.Label
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.WSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSCTableAdapter = New EnviroHealthSafetyTableAdapters.WSCTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.WSC_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_WasteGenerationTextBox = New System.Windows.Forms.TextBox()
        Me.tStrip_WasteStreamCharacterization = New System.Windows.Forms.ToolStrip()
        Me.btn_ReturnWSCDetail = New FontAwesome.Sharp.IconToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_WSC_WPD = New FontAwesome.Sharp.IconButton()
        WSC_DescriptionLabel = New System.Windows.Forms.Label()
        WSC_WasteGenerationLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tStrip_WasteStreamCharacterization.SuspendLayout()
        Me.SuspendLayout()
        '
        'WSC_DescriptionLabel
        '
        WSC_DescriptionLabel.AutoSize = True
        WSC_DescriptionLabel.Location = New System.Drawing.Point(8, 64)
        WSC_DescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WSC_DescriptionLabel.Name = "WSC_DescriptionLabel"
        WSC_DescriptionLabel.Size = New System.Drawing.Size(416, 21)
        WSC_DescriptionLabel.TabIndex = 3
        WSC_DescriptionLabel.Text = "WSC Description (including chemical/physical description):"
        '
        'WSC_WasteGenerationLabel
        '
        WSC_WasteGenerationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        WSC_WasteGenerationLabel.AutoSize = True
        WSC_WasteGenerationLabel.Location = New System.Drawing.Point(13, 286)
        WSC_WasteGenerationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WSC_WasteGenerationLabel.Name = "WSC_WasteGenerationLabel"
        WSC_WasteGenerationLabel.Size = New System.Drawing.Size(215, 21)
        WSC_WasteGenerationLabel.TabIndex = 5
        WSC_WasteGenerationLabel.Text = "Process generating the waste:"
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WSCBindingSource
        '
        Me.WSCBindingSource.DataMember = "WSC"
        Me.WSCBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'WSCTableAdapter
        '
        Me.WSCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Nothing
        Me.TableAdapterManager.LibraryTableAdapter = Nothing
        Me.TableAdapterManager.SDSTableAdapter = Nothing
        Me.TableAdapterManager.sysdiagramsTableAdapter = Nothing
        Me.TableAdapterManager.tlkpCHW_Toxic_CategoryTableAdapter = Nothing
        Me.TableAdapterManager.tlkpCHW_Toxic_ConstituentTableAdapter = Nothing
        Me.TableAdapterManager.tlkpEmployee_TitleTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHazard_ClassTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHSC_HealthHazardTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHSC_PhysicalHazardTableAdapter = Nothing
        Me.TableAdapterManager.tlkpLHW_FKTableAdapter = Nothing
        Me.TableAdapterManager.tlkpLHW_PUTableAdapter = Nothing
        Me.TableAdapterManager.tlkpLibrary_DocumentTypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_BuildingTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_DivisionTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_GroupTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_PhysicalLocationTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_TypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOfficeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpRCRA_TypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpRegionTableAdapter = Nothing
        Me.TableAdapterManager.tlkpUTS_ConstituentTableAdapter = Nothing
        Me.TableAdapterManager.trace_xe_action_mapTableAdapter = Nothing
        Me.TableAdapterManager.trace_xe_event_mapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnviroHealthSafetyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WSC_CHW_ToxicConstituentTableAdapter = Nothing
        Me.TableAdapterManager.WSC_CHWTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_FListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_KListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_PListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_UListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHWTableAdapter = Nothing
        Me.TableAdapterManager.WSC_RCRA_DeterminationTableAdapter = Nothing
        Me.TableAdapterManager.WSC_SupportingDocumentTableAdapter = Nothing
        Me.TableAdapterManager.WSC_SW_261_2TableAdapter = Nothing
        Me.TableAdapterManager.WSC_SWE_261_4TableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSD_UserKnowledgeTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSD_WasteAnalysisTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTD_UHCListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTDTableAdapter = Nothing
        Me.TableAdapterManager.WSCTableAdapter = Me.WSCTableAdapter
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Nothing
        '
        'WSC_IDTextBox
        '
        Me.WSC_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSCBindingSource, "WSC_ID", True))
        Me.WSC_IDTextBox.Location = New System.Drawing.Point(673, 58)
        Me.WSC_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WSC_IDTextBox.Name = "WSC_IDTextBox"
        Me.WSC_IDTextBox.Size = New System.Drawing.Size(46, 29)
        Me.WSC_IDTextBox.TabIndex = 2
        Me.WSC_IDTextBox.Visible = False
        '
        'WSC_DescriptionTextBox
        '
        Me.WSC_DescriptionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSCBindingSource, "WSC_Description", True))
        Me.WSC_DescriptionTextBox.Location = New System.Drawing.Point(18, 99)
        Me.WSC_DescriptionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WSC_DescriptionTextBox.Multiline = True
        Me.WSC_DescriptionTextBox.Name = "WSC_DescriptionTextBox"
        Me.WSC_DescriptionTextBox.Size = New System.Drawing.Size(700, 175)
        Me.WSC_DescriptionTextBox.TabIndex = 4
        '
        'WSC_WasteGenerationTextBox
        '
        Me.WSC_WasteGenerationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_WasteGenerationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSCBindingSource, "WSC_WasteGeneration", True))
        Me.WSC_WasteGenerationTextBox.Location = New System.Drawing.Point(19, 319)
        Me.WSC_WasteGenerationTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WSC_WasteGenerationTextBox.Multiline = True
        Me.WSC_WasteGenerationTextBox.Name = "WSC_WasteGenerationTextBox"
        Me.WSC_WasteGenerationTextBox.Size = New System.Drawing.Size(700, 175)
        Me.WSC_WasteGenerationTextBox.TabIndex = 6
        '
        'tStrip_WasteStreamCharacterization
        '
        Me.tStrip_WasteStreamCharacterization.AutoSize = False
        Me.tStrip_WasteStreamCharacterization.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tStrip_WasteStreamCharacterization.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tStrip_WasteStreamCharacterization.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tStrip_WasteStreamCharacterization.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ReturnWSCDetail, Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.tStrip_WasteStreamCharacterization.Location = New System.Drawing.Point(0, 0)
        Me.tStrip_WasteStreamCharacterization.Name = "tStrip_WasteStreamCharacterization"
        Me.tStrip_WasteStreamCharacterization.Size = New System.Drawing.Size(734, 40)
        Me.tStrip_WasteStreamCharacterization.TabIndex = 32
        Me.tStrip_WasteStreamCharacterization.Text = "ToolStrip1"
        '
        'btn_ReturnWSCDetail
        '
        Me.btn_ReturnWSCDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_ReturnWSCDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_ReturnWSCDetail.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_ReturnWSCDetail.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.btn_ReturnWSCDetail.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_ReturnWSCDetail.IconSize = 35
        Me.btn_ReturnWSCDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ReturnWSCDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ReturnWSCDetail.Name = "btn_ReturnWSCDetail"
        Me.btn_ReturnWSCDetail.Rotation = 0R
        Me.btn_ReturnWSCDetail.Size = New System.Drawing.Size(24, 40)
        Me.btn_ReturnWSCDetail.Text = "IconToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 37)
        Me.ToolStripLabel1.Text = "Details <"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(60, 37)
        Me.ToolStripLabel2.Text = "Process"
        '
        'btn_WSC_WPD
        '
        Me.btn_WSC_WPD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_WSC_WPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_WSC_WPD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WSC_WPD.FlatAppearance.BorderSize = 0
        Me.btn_WSC_WPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WSC_WPD.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_WSC_WPD.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_WSC_WPD.ForeColor = System.Drawing.Color.White
        Me.btn_WSC_WPD.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_WSC_WPD.IconColor = System.Drawing.Color.Black
        Me.btn_WSC_WPD.IconSize = 16
        Me.btn_WSC_WPD.Location = New System.Drawing.Point(18, 507)
        Me.btn_WSC_WPD.Name = "btn_WSC_WPD"
        Me.btn_WSC_WPD.Rotation = 0R
        Me.btn_WSC_WPD.Size = New System.Drawing.Size(700, 35)
        Me.btn_WSC_WPD.TabIndex = 33
        Me.btn_WSC_WPD.Text = "Next: Waste Stream Determination"
        Me.btn_WSC_WPD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_WSC_WPD.UseVisualStyleBackColor = False
        '
        'frmWSC_WPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.btn_WSC_WPD)
        Me.Controls.Add(Me.tStrip_WasteStreamCharacterization)
        Me.Controls.Add(WSC_WasteGenerationLabel)
        Me.Controls.Add(Me.WSC_WasteGenerationTextBox)
        Me.Controls.Add(WSC_DescriptionLabel)
        Me.Controls.Add(Me.WSC_DescriptionTextBox)
        Me.Controls.Add(Me.WSC_IDTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmWSC_WPD"
        Me.Text = "A. Wate process and description"
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tStrip_WasteStreamCharacterization.ResumeLayout(False)
        Me.tStrip_WasteStreamCharacterization.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents WSCBindingSource As BindingSource
    Friend WithEvents WSCTableAdapter As EnviroHealthSafetyTableAdapters.WSCTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents WSC_IDTextBox As TextBox
    Friend WithEvents WSC_DescriptionTextBox As TextBox
    Friend WithEvents WSC_WasteGenerationTextBox As TextBox
    Friend WithEvents tStrip_WasteStreamCharacterization As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_ReturnWSCDetail As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btn_WSC_WPD As FontAwesome.Sharp.IconButton
End Class
