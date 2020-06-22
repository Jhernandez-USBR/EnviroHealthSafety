<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWSC_WSD_Identification
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
        Dim Solid_261_2_NCitationLabel As System.Windows.Forms.Label
        Dim Solid_261_2_NDescriptionLabel As System.Windows.Forms.Label
        Dim Solid_261_2_NTypeLabel As System.Windows.Forms.Label
        Dim Excluded_S261_4vExemptLabel As System.Windows.Forms.Label
        Dim Excluded_S261_4vExempt_YCitationLabel As System.Windows.Forms.Label
        Dim Excluded_S261_4vExempt_YDescriptionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim WSC_LHW_IDLabel As System.Windows.Forms.Label
        Dim WSC_LHW_FListLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim WSC_CHW_IgnitableLabel As System.Windows.Forms.Label
        Dim WSC_CHW_Ignitable_NoteLabel As System.Windows.Forms.Label
        Dim WSC_CHW_CorrosiveLabel As System.Windows.Forms.Label
        Dim WSC_CHW_ReactiveLabel As System.Windows.Forms.Label
        Dim WCS_CHW_ToxicLabel As System.Windows.Forms.Label
        Me.Solid261_2_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_SW_261_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.WSC_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Solid_261_2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Solid_261_2_NCitationTextBox = New System.Windows.Forms.TextBox()
        Me.Solid_261_2_NDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.rbtn_261_2Yes = New System.Windows.Forms.RadioButton()
        Me.rbtn_261_2No = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_SolidWaste = New System.Windows.Forms.Panel()
        Me.Panel_ExcludedWaste = New System.Windows.Forms.Panel()
        Me.rbtn_261_4No = New System.Windows.Forms.RadioButton()
        Me.Excluded_S261_4_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_SWE_261_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbtn_261_4Yes = New System.Windows.Forms.RadioButton()
        Me.WSC_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Excluded_S261_4vExemptCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel_Listed_Control = New System.Windows.Forms.Panel()
        Me.Panel_dgv_UListed = New System.Windows.Forms.Panel()
        Me.dgv_UList = New System.Windows.Forms.DataGridView()
        Me.WSCLHWUListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCLHWIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHWPUListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHW_PUList_HWN = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TlkpLHWPUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LHW_PUList_AbstractNo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LHW_PUList_Substance = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.WSCLHWUListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel_Listed_UList = New System.Windows.Forms.Panel()
        Me.btn_dgvViewUListed = New System.Windows.Forms.Button()
        Me.rbtn_Listed_UYes = New System.Windows.Forms.RadioButton()
        Me.WSC_LHW_UListCheckBox = New System.Windows.Forms.CheckBox()
        Me.WSC_LHWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbtn_Listed_UNo = New System.Windows.Forms.RadioButton()
        Me.WSC_LHW_UList_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.Panel_dgv_PListed = New System.Windows.Forms.Panel()
        Me.dgv_PList = New System.Windows.Forms.DataGridView()
        Me.WSCLHWPListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHWPUListIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCLHWIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHW_PList_HWN = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LHW_PList_CAN = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LHW_PList_Substance = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.WSCLHWPListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel_Listed_PList = New System.Windows.Forms.Panel()
        Me.btn_dgvViewPListed = New System.Windows.Forms.Button()
        Me.rbtn_Listed_PYes = New System.Windows.Forms.RadioButton()
        Me.rbtn_Listed_PNo = New System.Windows.Forms.RadioButton()
        Me.WSC_LHW_PList_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_LHW_PListCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel_dgv_KListed = New System.Windows.Forms.Panel()
        Me.dgv_KList = New System.Windows.Forms.DataGridView()
        Me.WSCLHWKListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHWKListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCLHWIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHW_KList_HWN = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TlkpLHWFKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LHW_KList_Description = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.WSCLHWKListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel_Listed_KList = New System.Windows.Forms.Panel()
        Me.btn_dgvViewKListed = New System.Windows.Forms.Button()
        Me.rbtn_Listed_KYes = New System.Windows.Forms.RadioButton()
        Me.rbtn_Listed_KNo = New System.Windows.Forms.RadioButton()
        Me.WSC_LHW_KList_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_LHW_KListCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel_dgv_FListed = New System.Windows.Forms.Panel()
        Me.dgv_FList = New System.Windows.Forms.DataGridView()
        Me.WSCLHWFListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LHWFListIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FList_Description = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.WSCLHWIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCLHWFListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel_Listed_FList = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WSC_LHW_FList_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_LHW_FListCheckBox = New System.Windows.Forms.CheckBox()
        Me.rbtn_Listed_FYes = New System.Windows.Forms.RadioButton()
        Me.rbtn_Listed_FNo = New System.Windows.Forms.RadioButton()
        Me.Panel_ListedHazardousWaste = New System.Windows.Forms.Panel()
        Me.WSC_LHW_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_IDTextBox2 = New System.Windows.Forms.TextBox()
        Me.Excluded_S261_4vExempt_YCitationTextBox = New System.Windows.Forms.TextBox()
        Me.Excluded_S261_4vExempt_YDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel_SolidWaste_Details = New System.Windows.Forms.Panel()
        Me.Panel_ExcludedWaste_Detail = New System.Windows.Forms.Panel()
        Me.WSC_SW_261_2TableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_SW_261_2TableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.WSC_LHWTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_LHWTableAdapter()
        Me.WSC_SWE_261_4TableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_SWE_261_4TableAdapter()
        Me.WSC_LHW_FListTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_LHW_FListTableAdapter()
        Me.WSC_LHW_UListTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_LHW_UListTableAdapter()
        Me.WSCLHWUListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TlkpLHW_PUTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpLHW_PUTableAdapter()
        Me.WSC_LHW_KListTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_LHW_KListTableAdapter()
        Me.WSC_LHW_PListTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_LHW_PListTableAdapter()
        Me.Panel_CharacteristicWaste = New System.Windows.Forms.Panel()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.lbl_CHW_HeaderText = New System.Windows.Forms.Label()
        Me.WSC_CHW_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_CHWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSC_CHW_IgnitableCheckBox = New System.Windows.Forms.CheckBox()
        Me.WSC_CHW_Ignitable_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_CHW_CorrosiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.WSC_CHW_Corrosive_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_CHW_ReactiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.WSC_CHW_Reactive_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WCS_CHW_ToxicCheckBox = New System.Windows.Forms.CheckBox()
        Me.WCS_CHW_Toxic_NoteTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_IDTextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel_ChacteristicWaste_Toxic = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCCHWIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToxicConstituentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToxicConstituent_HWN = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TlkpCHWToxicConstituentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToxicConstituent_Contaminant = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCCHWToxicConstituentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSC_CHWTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_CHWTableAdapter()
        Me.WSC_CHW_ToxicConstituentTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_CHW_ToxicConstituentTableAdapter()
        Me.TlkpCHW_Toxic_ConstituentTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpCHW_Toxic_ConstituentTableAdapter()
        Me.TlkpLHW_FKTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpLHW_FKTableAdapter()
        Solid_261_2_NCitationLabel = New System.Windows.Forms.Label()
        Solid_261_2_NDescriptionLabel = New System.Windows.Forms.Label()
        Solid_261_2_NTypeLabel = New System.Windows.Forms.Label()
        Excluded_S261_4vExemptLabel = New System.Windows.Forms.Label()
        Excluded_S261_4vExempt_YCitationLabel = New System.Windows.Forms.Label()
        Excluded_S261_4vExempt_YDescriptionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        WSC_LHW_IDLabel = New System.Windows.Forms.Label()
        WSC_LHW_FListLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        WSC_CHW_IgnitableLabel = New System.Windows.Forms.Label()
        WSC_CHW_Ignitable_NoteLabel = New System.Windows.Forms.Label()
        WSC_CHW_CorrosiveLabel = New System.Windows.Forms.Label()
        WSC_CHW_ReactiveLabel = New System.Windows.Forms.Label()
        WCS_CHW_ToxicLabel = New System.Windows.Forms.Label()
        CType(Me.WSC_SW_261_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_SolidWaste.SuspendLayout()
        Me.Panel_ExcludedWaste.SuspendLayout()
        CType(Me.WSC_SWE_261_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Listed_Control.SuspendLayout()
        Me.Panel_dgv_UListed.SuspendLayout()
        CType(Me.dgv_UList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpLHWPUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCLHWUListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Listed_UList.SuspendLayout()
        CType(Me.WSC_LHWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_dgv_PListed.SuspendLayout()
        CType(Me.dgv_PList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCLHWPListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Listed_PList.SuspendLayout()
        Me.Panel_dgv_KListed.SuspendLayout()
        CType(Me.dgv_KList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpLHWFKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCLHWKListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Listed_KList.SuspendLayout()
        Me.Panel_dgv_FListed.SuspendLayout()
        CType(Me.dgv_FList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCLHWFListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Listed_FList.SuspendLayout()
        Me.Panel_ListedHazardousWaste.SuspendLayout()
        Me.Panel_SolidWaste_Details.SuspendLayout()
        Me.Panel_ExcludedWaste_Detail.SuspendLayout()
        CType(Me.WSCLHWUListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_CharacteristicWaste.SuspendLayout()
        CType(Me.WSC_CHWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ChacteristicWaste_Toxic.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpCHWToxicConstituentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCCHWToxicConstituentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Solid_261_2_NCitationLabel
        '
        Solid_261_2_NCitationLabel.AutoSize = True
        Solid_261_2_NCitationLabel.Location = New System.Drawing.Point(25, 40)
        Solid_261_2_NCitationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Solid_261_2_NCitationLabel.Name = "Solid_261_2_NCitationLabel"
        Solid_261_2_NCitationLabel.Size = New System.Drawing.Size(185, 28)
        Solid_261_2_NCitationLabel.TabIndex = 7
        Solid_261_2_NCitationLabel.Text = "Regulatory Citation:"
        '
        'Solid_261_2_NDescriptionLabel
        '
        Solid_261_2_NDescriptionLabel.AutoSize = True
        Solid_261_2_NDescriptionLabel.Location = New System.Drawing.Point(23, 108)
        Solid_261_2_NDescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Solid_261_2_NDescriptionLabel.Name = "Solid_261_2_NDescriptionLabel"
        Solid_261_2_NDescriptionLabel.Size = New System.Drawing.Size(116, 28)
        Solid_261_2_NDescriptionLabel.TabIndex = 9
        Solid_261_2_NDescriptionLabel.Text = "Description:"
        '
        'Solid_261_2_NTypeLabel
        '
        Solid_261_2_NTypeLabel.AutoSize = True
        Solid_261_2_NTypeLabel.Location = New System.Drawing.Point(25, 12)
        Solid_261_2_NTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Solid_261_2_NTypeLabel.Name = "Solid_261_2_NTypeLabel"
        Solid_261_2_NTypeLabel.Size = New System.Drawing.Size(641, 28)
        Solid_261_2_NTypeLabel.TabIndex = 11
        Solid_261_2_NTypeLabel.Text = "If no, specify exclusion or exemption by regulatory citation and describe:"
        '
        'Excluded_S261_4vExemptLabel
        '
        Excluded_S261_4vExemptLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Excluded_S261_4vExemptLabel.AutoSize = True
        Excluded_S261_4vExemptLabel.Location = New System.Drawing.Point(215, 9)
        Excluded_S261_4vExemptLabel.Name = "Excluded_S261_4vExemptLabel"
        Excluded_S261_4vExemptLabel.Size = New System.Drawing.Size(792, 28)
        Excluded_S261_4vExemptLabel.TabIndex = 22
        Excluded_S261_4vExemptLabel.Text = "Is the solid waste excluded under §261.4 or exempt from regulation as a hazardous" &
    " waste?"
        '
        'Excluded_S261_4vExempt_YCitationLabel
        '
        Excluded_S261_4vExempt_YCitationLabel.AutoSize = True
        Excluded_S261_4vExempt_YCitationLabel.Location = New System.Drawing.Point(41, 41)
        Excluded_S261_4vExempt_YCitationLabel.Name = "Excluded_S261_4vExempt_YCitationLabel"
        Excluded_S261_4vExempt_YCitationLabel.Size = New System.Drawing.Size(185, 28)
        Excluded_S261_4vExempt_YCitationLabel.TabIndex = 26
        Excluded_S261_4vExempt_YCitationLabel.Text = "Regulatory Citation:"
        '
        'Excluded_S261_4vExempt_YDescriptionLabel
        '
        Excluded_S261_4vExempt_YDescriptionLabel.AutoSize = True
        Excluded_S261_4vExempt_YDescriptionLabel.Location = New System.Drawing.Point(42, 113)
        Excluded_S261_4vExempt_YDescriptionLabel.Name = "Excluded_S261_4vExempt_YDescriptionLabel"
        Excluded_S261_4vExempt_YDescriptionLabel.Size = New System.Drawing.Size(116, 28)
        Excluded_S261_4vExempt_YDescriptionLabel.TabIndex = 28
        Excluded_S261_4vExempt_YDescriptionLabel.Text = "Description:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(42, 13)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(646, 28)
        Label2.TabIndex = 12
        Label2.Text = "If yes, specify exclusion or exemption by regulatory citation and describe:"
        '
        'WSC_LHW_IDLabel
        '
        WSC_LHW_IDLabel.AutoSize = True
        WSC_LHW_IDLabel.Location = New System.Drawing.Point(13, 10)
        WSC_LHW_IDLabel.Name = "WSC_LHW_IDLabel"
        WSC_LHW_IDLabel.Size = New System.Drawing.Size(602, 28)
        WSC_LHW_IDLabel.TabIndex = 0
        WSC_LHW_IDLabel.Text = "Is the waste a listed hazardous waste? (Detail rationale, as necessary)"
        '
        'WSC_LHW_FListLabel
        '
        WSC_LHW_FListLabel.AutoSize = True
        WSC_LHW_FListLabel.Location = New System.Drawing.Point(215, 7)
        WSC_LHW_FListLabel.Name = "WSC_LHW_FListLabel"
        WSC_LHW_FListLabel.Size = New System.Drawing.Size(193, 28)
        WSC_LHW_FListLabel.TabIndex = 2
        WSC_LHW_FListLabel.Text = "F-Listed per  §261.31"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(234, -29)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(193, 28)
        Label3.TabIndex = 23
        Label3.Text = "F-Listed per  §261.31"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(215, 8)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(215, 28)
        Label4.TabIndex = 26
        Label4.Text = "U-Listed per  §261.33(f)"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(215, 8)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(221, 28)
        Label6.TabIndex = 28
        Label6.Text = "P-Listed per  §261.33 (e)"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(215, 8)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(195, 28)
        Label5.TabIndex = 27
        Label5.Text = "K-Listed per  §261.32"
        '
        'WSC_CHW_IgnitableLabel
        '
        WSC_CHW_IgnitableLabel.AutoSize = True
        WSC_CHW_IgnitableLabel.Location = New System.Drawing.Point(213, 41)
        WSC_CHW_IgnitableLabel.Name = "WSC_CHW_IgnitableLabel"
        WSC_CHW_IgnitableLabel.Size = New System.Drawing.Size(260, 28)
        WSC_CHW_IgnitableLabel.TabIndex = 3
        WSC_CHW_IgnitableLabel.Text = "Ignitable (D001) per §261.21"
        '
        'WSC_CHW_Ignitable_NoteLabel
        '
        WSC_CHW_Ignitable_NoteLabel.AutoSize = True
        WSC_CHW_Ignitable_NoteLabel.Location = New System.Drawing.Point(44, 217)
        WSC_CHW_Ignitable_NoteLabel.Name = "WSC_CHW_Ignitable_NoteLabel"
        WSC_CHW_Ignitable_NoteLabel.Size = New System.Drawing.Size(0, 28)
        WSC_CHW_Ignitable_NoteLabel.TabIndex = 5
        '
        'WSC_CHW_CorrosiveLabel
        '
        WSC_CHW_CorrosiveLabel.AutoSize = True
        WSC_CHW_CorrosiveLabel.Location = New System.Drawing.Point(209, 112)
        WSC_CHW_CorrosiveLabel.Name = "WSC_CHW_CorrosiveLabel"
        WSC_CHW_CorrosiveLabel.Size = New System.Drawing.Size(266, 28)
        WSC_CHW_CorrosiveLabel.TabIndex = 7
        WSC_CHW_CorrosiveLabel.Text = "Corrosive (D002) per §261.22"
        '
        'WSC_CHW_ReactiveLabel
        '
        WSC_CHW_ReactiveLabel.AutoSize = True
        WSC_CHW_ReactiveLabel.Location = New System.Drawing.Point(213, 182)
        WSC_CHW_ReactiveLabel.Name = "WSC_CHW_ReactiveLabel"
        WSC_CHW_ReactiveLabel.Size = New System.Drawing.Size(255, 28)
        WSC_CHW_ReactiveLabel.TabIndex = 11
        WSC_CHW_ReactiveLabel.Text = "Reactive (D003) per §261.23"
        '
        'WCS_CHW_ToxicLabel
        '
        WCS_CHW_ToxicLabel.AutoSize = True
        WCS_CHW_ToxicLabel.Location = New System.Drawing.Point(213, 252)
        WCS_CHW_ToxicLabel.Name = "WCS_CHW_ToxicLabel"
        WCS_CHW_ToxicLabel.Size = New System.Drawing.Size(516, 28)
        WCS_CHW_ToxicLabel.TabIndex = 15
        WCS_CHW_ToxicLabel.Text = "Toxic (D004-D043) per §261.24 (select constituents below)"
        '
        'Solid261_2_IDTextBox
        '
        Me.Solid261_2_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Solid261_2_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SW_261_2BindingSource, "Solid261_2_ID", True))
        Me.Solid261_2_IDTextBox.Location = New System.Drawing.Point(791, 8)
        Me.Solid261_2_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Solid261_2_IDTextBox.Name = "Solid261_2_IDTextBox"
        Me.Solid261_2_IDTextBox.Size = New System.Drawing.Size(43, 34)
        Me.Solid261_2_IDTextBox.TabIndex = 2
        '
        'WSC_SW_261_2BindingSource
        '
        Me.WSC_SW_261_2BindingSource.DataMember = "WSC_SW_261_2"
        Me.WSC_SW_261_2BindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WSC_IDTextBox
        '
        Me.WSC_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SW_261_2BindingSource, "WSC_ID", True))
        Me.WSC_IDTextBox.Location = New System.Drawing.Point(747, 8)
        Me.WSC_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WSC_IDTextBox.Name = "WSC_IDTextBox"
        Me.WSC_IDTextBox.Size = New System.Drawing.Size(36, 34)
        Me.WSC_IDTextBox.TabIndex = 4
        '
        'Solid_261_2CheckBox
        '
        Me.Solid_261_2CheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Solid_261_2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_SW_261_2BindingSource, "Solid_261_2", True))
        Me.Solid_261_2CheckBox.Location = New System.Drawing.Point(713, 8)
        Me.Solid_261_2CheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Solid_261_2CheckBox.Name = "Solid_261_2CheckBox"
        Me.Solid_261_2CheckBox.Size = New System.Drawing.Size(26, 28)
        Me.Solid_261_2CheckBox.TabIndex = 6
        Me.Solid_261_2CheckBox.Text = "§261.2"
        Me.Solid_261_2CheckBox.UseVisualStyleBackColor = True
        '
        'Solid_261_2_NCitationTextBox
        '
        Me.Solid_261_2_NCitationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Solid_261_2_NCitationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SW_261_2BindingSource, "Solid_261_2_NCitation", True))
        Me.Solid_261_2_NCitationTextBox.Location = New System.Drawing.Point(45, 71)
        Me.Solid_261_2_NCitationTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Solid_261_2_NCitationTextBox.Name = "Solid_261_2_NCitationTextBox"
        Me.Solid_261_2_NCitationTextBox.Size = New System.Drawing.Size(746, 34)
        Me.Solid_261_2_NCitationTextBox.TabIndex = 8
        '
        'Solid_261_2_NDescriptionTextBox
        '
        Me.Solid_261_2_NDescriptionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Solid_261_2_NDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SW_261_2BindingSource, "Solid_261_2_NDescription", True))
        Me.Solid_261_2_NDescriptionTextBox.Location = New System.Drawing.Point(45, 139)
        Me.Solid_261_2_NDescriptionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Solid_261_2_NDescriptionTextBox.Multiline = True
        Me.Solid_261_2_NDescriptionTextBox.Name = "Solid_261_2_NDescriptionTextBox"
        Me.Solid_261_2_NDescriptionTextBox.Size = New System.Drawing.Size(746, 85)
        Me.Solid_261_2_NDescriptionTextBox.TabIndex = 10
        '
        'rbtn_261_2Yes
        '
        Me.rbtn_261_2Yes.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_261_2Yes.Location = New System.Drawing.Point(45, 5)
        Me.rbtn_261_2Yes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtn_261_2Yes.Name = "rbtn_261_2Yes"
        Me.rbtn_261_2Yes.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_261_2Yes.TabIndex = 14
        Me.rbtn_261_2Yes.TabStop = True
        Me.rbtn_261_2Yes.UseVisualStyleBackColor = False
        '
        'rbtn_261_2No
        '
        Me.rbtn_261_2No.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_261_2No.Location = New System.Drawing.Point(128, 5)
        Me.rbtn_261_2No.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtn_261_2No.Name = "rbtn_261_2No"
        Me.rbtn_261_2No.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_261_2No.TabIndex = 15
        Me.rbtn_261_2No.TabStop = True
        Me.rbtn_261_2No.Text = "No"
        Me.rbtn_261_2No.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Is the waste a ""solid waste"" according to §261.2?"
        '
        'Panel_SolidWaste
        '
        Me.Panel_SolidWaste.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_SolidWaste.Controls.Add(Me.Label1)
        Me.Panel_SolidWaste.Controls.Add(Me.rbtn_261_2No)
        Me.Panel_SolidWaste.Controls.Add(Me.rbtn_261_2Yes)
        Me.Panel_SolidWaste.Controls.Add(Me.Solid261_2_IDTextBox)
        Me.Panel_SolidWaste.Controls.Add(Me.WSC_IDTextBox)
        Me.Panel_SolidWaste.Controls.Add(Me.Solid_261_2CheckBox)
        Me.Panel_SolidWaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_SolidWaste.Location = New System.Drawing.Point(0, 0)
        Me.Panel_SolidWaste.Name = "Panel_SolidWaste"
        Me.Panel_SolidWaste.Size = New System.Drawing.Size(840, 50)
        Me.Panel_SolidWaste.TabIndex = 17
        '
        'Panel_ExcludedWaste
        '
        Me.Panel_ExcludedWaste.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_ExcludedWaste.Controls.Add(Excluded_S261_4vExemptLabel)
        Me.Panel_ExcludedWaste.Controls.Add(Me.rbtn_261_4No)
        Me.Panel_ExcludedWaste.Controls.Add(Me.Excluded_S261_4_IDTextBox)
        Me.Panel_ExcludedWaste.Controls.Add(Me.rbtn_261_4Yes)
        Me.Panel_ExcludedWaste.Controls.Add(Me.WSC_IDTextBox1)
        Me.Panel_ExcludedWaste.Controls.Add(Me.Excluded_S261_4vExemptCheckBox)
        Me.Panel_ExcludedWaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ExcludedWaste.Location = New System.Drawing.Point(0, 300)
        Me.Panel_ExcludedWaste.Name = "Panel_ExcludedWaste"
        Me.Panel_ExcludedWaste.Size = New System.Drawing.Size(840, 50)
        Me.Panel_ExcludedWaste.TabIndex = 18
        Me.Panel_ExcludedWaste.Visible = False
        '
        'rbtn_261_4No
        '
        Me.rbtn_261_4No.Location = New System.Drawing.Point(131, 9)
        Me.rbtn_261_4No.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtn_261_4No.Name = "rbtn_261_4No"
        Me.rbtn_261_4No.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_261_4No.TabIndex = 18
        Me.rbtn_261_4No.TabStop = True
        Me.rbtn_261_4No.Text = "No"
        Me.rbtn_261_4No.UseVisualStyleBackColor = True
        '
        'Excluded_S261_4_IDTextBox
        '
        Me.Excluded_S261_4_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Excluded_S261_4_IDTextBox.BackColor = System.Drawing.Color.Maroon
        Me.Excluded_S261_4_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SWE_261_4BindingSource, "Excluded_S261_4_ID", True))
        Me.Excluded_S261_4_IDTextBox.Location = New System.Drawing.Point(791, 7)
        Me.Excluded_S261_4_IDTextBox.Name = "Excluded_S261_4_IDTextBox"
        Me.Excluded_S261_4_IDTextBox.Size = New System.Drawing.Size(10, 34)
        Me.Excluded_S261_4_IDTextBox.TabIndex = 21
        Me.Excluded_S261_4_IDTextBox.Visible = False
        '
        'WSC_SWE_261_4BindingSource
        '
        Me.WSC_SWE_261_4BindingSource.DataMember = "WSC_SWE_261_4"
        Me.WSC_SWE_261_4BindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'rbtn_261_4Yes
        '
        Me.rbtn_261_4Yes.Location = New System.Drawing.Point(45, 9)
        Me.rbtn_261_4Yes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtn_261_4Yes.Name = "rbtn_261_4Yes"
        Me.rbtn_261_4Yes.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_261_4Yes.TabIndex = 17
        Me.rbtn_261_4Yes.TabStop = True
        Me.rbtn_261_4Yes.Text = "Yes"
        Me.rbtn_261_4Yes.UseVisualStyleBackColor = True
        '
        'WSC_IDTextBox1
        '
        Me.WSC_IDTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_IDTextBox1.BackColor = System.Drawing.Color.Maroon
        Me.WSC_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SWE_261_4BindingSource, "WSC_ID", True))
        Me.WSC_IDTextBox1.Location = New System.Drawing.Point(774, 7)
        Me.WSC_IDTextBox1.Name = "WSC_IDTextBox1"
        Me.WSC_IDTextBox1.Size = New System.Drawing.Size(10, 34)
        Me.WSC_IDTextBox1.TabIndex = 31
        Me.WSC_IDTextBox1.Visible = False
        '
        'Excluded_S261_4vExemptCheckBox
        '
        Me.Excluded_S261_4vExemptCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Excluded_S261_4vExemptCheckBox.BackColor = System.Drawing.Color.Maroon
        Me.Excluded_S261_4vExemptCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_SWE_261_4BindingSource, "Excluded_S261_4vExempt", True))
        Me.Excluded_S261_4vExemptCheckBox.Location = New System.Drawing.Point(806, 7)
        Me.Excluded_S261_4vExemptCheckBox.Name = "Excluded_S261_4vExemptCheckBox"
        Me.Excluded_S261_4vExemptCheckBox.Size = New System.Drawing.Size(10, 34)
        Me.Excluded_S261_4vExemptCheckBox.TabIndex = 23
        Me.Excluded_S261_4vExemptCheckBox.Text = "§261.4"
        Me.Excluded_S261_4vExemptCheckBox.UseVisualStyleBackColor = False
        Me.Excluded_S261_4vExemptCheckBox.Visible = False
        '
        'Panel_Listed_Control
        '
        Me.Panel_Listed_Control.AutoScroll = True
        Me.Panel_Listed_Control.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_dgv_UListed)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_Listed_UList)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_dgv_PListed)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_Listed_PList)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_dgv_KListed)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_Listed_KList)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_dgv_FListed)
        Me.Panel_Listed_Control.Controls.Add(Me.Panel_Listed_FList)
        Me.Panel_Listed_Control.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Listed_Control.Location = New System.Drawing.Point(0, 649)
        Me.Panel_Listed_Control.Name = "Panel_Listed_Control"
        Me.Panel_Listed_Control.Size = New System.Drawing.Size(840, 400)
        Me.Panel_Listed_Control.TabIndex = 19
        Me.Panel_Listed_Control.Visible = False
        '
        'Panel_dgv_UListed
        '
        Me.Panel_dgv_UListed.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_dgv_UListed.Controls.Add(Me.dgv_UList)
        Me.Panel_dgv_UListed.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_dgv_UListed.Location = New System.Drawing.Point(0, 1000)
        Me.Panel_dgv_UListed.Name = "Panel_dgv_UListed"
        Me.Panel_dgv_UListed.Size = New System.Drawing.Size(819, 200)
        Me.Panel_dgv_UListed.TabIndex = 35
        Me.Panel_dgv_UListed.Visible = False
        '
        'dgv_UList
        '
        Me.dgv_UList.AllowUserToAddRows = False
        Me.dgv_UList.AllowUserToDeleteRows = False
        Me.dgv_UList.AutoGenerateColumns = False
        Me.dgv_UList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_UList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_UList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_UList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WSCLHWUListIDDataGridViewTextBoxColumn, Me.WSCLHWIDDataGridViewTextBoxColumn1, Me.LHWPUListIDDataGridViewTextBoxColumn, Me.LHW_PUList_HWN, Me.LHW_PUList_AbstractNo, Me.LHW_PUList_Substance})
        Me.dgv_UList.DataSource = Me.WSCLHWUListBindingSource
        Me.dgv_UList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_UList.Location = New System.Drawing.Point(0, 0)
        Me.dgv_UList.Name = "dgv_UList"
        Me.dgv_UList.ReadOnly = True
        Me.dgv_UList.RowHeadersWidth = 51
        Me.dgv_UList.RowTemplate.Height = 24
        Me.dgv_UList.Size = New System.Drawing.Size(819, 200)
        Me.dgv_UList.TabIndex = 33
        '
        'WSCLHWUListIDDataGridViewTextBoxColumn
        '
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_LHW_UList_ID"
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.HeaderText = "WSC_LHW_UList_ID"
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.Name = "WSCLHWUListIDDataGridViewTextBoxColumn"
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCLHWUListIDDataGridViewTextBoxColumn.Width = 211
        '
        'WSCLHWIDDataGridViewTextBoxColumn1
        '
        Me.WSCLHWIDDataGridViewTextBoxColumn1.DataPropertyName = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn1.HeaderText = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.WSCLHWIDDataGridViewTextBoxColumn1.Name = "WSCLHWIDDataGridViewTextBoxColumn1"
        Me.WSCLHWIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WSCLHWIDDataGridViewTextBoxColumn1.Visible = False
        Me.WSCLHWIDDataGridViewTextBoxColumn1.Width = 160
        '
        'LHWPUListIDDataGridViewTextBoxColumn
        '
        Me.LHWPUListIDDataGridViewTextBoxColumn.DataPropertyName = "LHW_PUList_ID"
        Me.LHWPUListIDDataGridViewTextBoxColumn.HeaderText = "LHW_PUList_ID"
        Me.LHWPUListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LHWPUListIDDataGridViewTextBoxColumn.Name = "LHWPUListIDDataGridViewTextBoxColumn"
        Me.LHWPUListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LHWPUListIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LHWPUListIDDataGridViewTextBoxColumn.Visible = False
        Me.LHWPUListIDDataGridViewTextBoxColumn.Width = 172
        '
        'LHW_PUList_HWN
        '
        Me.LHW_PUList_HWN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LHW_PUList_HWN.DataPropertyName = "LHW_PUList_ID"
        Me.LHW_PUList_HWN.DataSource = Me.TlkpLHWPUBindingSource
        Me.LHW_PUList_HWN.DisplayMember = "Listed_PU_HWN"
        Me.LHW_PUList_HWN.DisplayStyleForCurrentCellOnly = True
        Me.LHW_PUList_HWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_PUList_HWN.HeaderText = "Hazardous Waste No."
        Me.LHW_PUList_HWN.MinimumWidth = 6
        Me.LHW_PUList_HWN.Name = "LHW_PUList_HWN"
        Me.LHW_PUList_HWN.ReadOnly = True
        Me.LHW_PUList_HWN.ValueMember = "Listed_PU_ID"
        Me.LHW_PUList_HWN.Width = 157
        '
        'TlkpLHWPUBindingSource
        '
        Me.TlkpLHWPUBindingSource.DataMember = "tlkpLHW_PU"
        Me.TlkpLHWPUBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'LHW_PUList_AbstractNo
        '
        Me.LHW_PUList_AbstractNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LHW_PUList_AbstractNo.DataPropertyName = "LHW_PUList_ID"
        Me.LHW_PUList_AbstractNo.DataSource = Me.TlkpLHWPUBindingSource
        Me.LHW_PUList_AbstractNo.DisplayMember = "Listed_PU_CAN"
        Me.LHW_PUList_AbstractNo.DisplayStyleForCurrentCellOnly = True
        Me.LHW_PUList_AbstractNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_PUList_AbstractNo.HeaderText = "Chemical Abstract No."
        Me.LHW_PUList_AbstractNo.MinimumWidth = 6
        Me.LHW_PUList_AbstractNo.Name = "LHW_PUList_AbstractNo"
        Me.LHW_PUList_AbstractNo.ReadOnly = True
        Me.LHW_PUList_AbstractNo.ValueMember = "Listed_PU_ID"
        Me.LHW_PUList_AbstractNo.Width = 162
        '
        'LHW_PUList_Substance
        '
        Me.LHW_PUList_Substance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LHW_PUList_Substance.DataPropertyName = "LHW_PUList_ID"
        Me.LHW_PUList_Substance.DataSource = Me.TlkpLHWPUBindingSource
        Me.LHW_PUList_Substance.DisplayMember = "Listed_PU_Substance"
        Me.LHW_PUList_Substance.DisplayStyleForCurrentCellOnly = True
        Me.LHW_PUList_Substance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_PUList_Substance.HeaderText = "Substance"
        Me.LHW_PUList_Substance.MinimumWidth = 6
        Me.LHW_PUList_Substance.Name = "LHW_PUList_Substance"
        Me.LHW_PUList_Substance.ReadOnly = True
        Me.LHW_PUList_Substance.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LHW_PUList_Substance.ValueMember = "Listed_PU_ID"
        '
        'WSCLHWUListBindingSource
        '
        Me.WSCLHWUListBindingSource.DataMember = "WSC_LHW_UList"
        Me.WSCLHWUListBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Panel_Listed_UList
        '
        Me.Panel_Listed_UList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Listed_UList.Controls.Add(Me.btn_dgvViewUListed)
        Me.Panel_Listed_UList.Controls.Add(Label4)
        Me.Panel_Listed_UList.Controls.Add(Label3)
        Me.Panel_Listed_UList.Controls.Add(Me.rbtn_Listed_UYes)
        Me.Panel_Listed_UList.Controls.Add(Me.WSC_LHW_UListCheckBox)
        Me.Panel_Listed_UList.Controls.Add(Me.rbtn_Listed_UNo)
        Me.Panel_Listed_UList.Controls.Add(Me.WSC_LHW_UList_NoteTextBox)
        Me.Panel_Listed_UList.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Listed_UList.Location = New System.Drawing.Point(0, 900)
        Me.Panel_Listed_UList.Name = "Panel_Listed_UList"
        Me.Panel_Listed_UList.Size = New System.Drawing.Size(819, 100)
        Me.Panel_Listed_UList.TabIndex = 28
        '
        'btn_dgvViewUListed
        '
        Me.btn_dgvViewUListed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dgvViewUListed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_dgvViewUListed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dgvViewUListed.FlatAppearance.BorderSize = 0
        Me.btn_dgvViewUListed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dgvViewUListed.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dgvViewUListed.ForeColor = System.Drawing.Color.White
        Me.btn_dgvViewUListed.Location = New System.Drawing.Point(641, 6)
        Me.btn_dgvViewUListed.Name = "btn_dgvViewUListed"
        Me.btn_dgvViewUListed.Size = New System.Drawing.Size(150, 30)
        Me.btn_dgvViewUListed.TabIndex = 27
        Me.btn_dgvViewUListed.Text = "View U-Listed"
        Me.btn_dgvViewUListed.UseVisualStyleBackColor = False
        '
        'rbtn_Listed_UYes
        '
        Me.rbtn_Listed_UYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_UYes.Location = New System.Drawing.Point(45, 7)
        Me.rbtn_Listed_UYes.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_UYes.Name = "rbtn_Listed_UYes"
        Me.rbtn_Listed_UYes.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_UYes.TabIndex = 24
        Me.rbtn_Listed_UYes.TabStop = True
        Me.rbtn_Listed_UYes.Text = "Yes"
        Me.rbtn_Listed_UYes.UseVisualStyleBackColor = True
        '
        'WSC_LHW_UListCheckBox
        '
        Me.WSC_LHW_UListCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_UListCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_LHWBindingSource, "WSC_LHW_UList", True))
        Me.WSC_LHW_UListCheckBox.Location = New System.Drawing.Point(11, 55)
        Me.WSC_LHW_UListCheckBox.Name = "WSC_LHW_UListCheckBox"
        Me.WSC_LHW_UListCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.WSC_LHW_UListCheckBox.TabIndex = 15
        Me.WSC_LHW_UListCheckBox.UseVisualStyleBackColor = True
        '
        'WSC_LHWBindingSource
        '
        Me.WSC_LHWBindingSource.DataMember = "WSC_LHW"
        Me.WSC_LHWBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'rbtn_Listed_UNo
        '
        Me.rbtn_Listed_UNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_UNo.Location = New System.Drawing.Point(128, 7)
        Me.rbtn_Listed_UNo.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_UNo.Name = "rbtn_Listed_UNo"
        Me.rbtn_Listed_UNo.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_UNo.TabIndex = 25
        Me.rbtn_Listed_UNo.TabStop = True
        Me.rbtn_Listed_UNo.Text = "No"
        Me.rbtn_Listed_UNo.UseVisualStyleBackColor = True
        '
        'WSC_LHW_UList_NoteTextBox
        '
        Me.WSC_LHW_UList_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_UList_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_LHWBindingSource, "WSC_LHW_UList_Note", True))
        Me.WSC_LHW_UList_NoteTextBox.Location = New System.Drawing.Point(45, 40)
        Me.WSC_LHW_UList_NoteTextBox.Multiline = True
        Me.WSC_LHW_UList_NoteTextBox.Name = "WSC_LHW_UList_NoteTextBox"
        Me.WSC_LHW_UList_NoteTextBox.Size = New System.Drawing.Size(746, 50)
        Me.WSC_LHW_UList_NoteTextBox.TabIndex = 17
        '
        'Panel_dgv_PListed
        '
        Me.Panel_dgv_PListed.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_dgv_PListed.Controls.Add(Me.dgv_PList)
        Me.Panel_dgv_PListed.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_dgv_PListed.Location = New System.Drawing.Point(0, 700)
        Me.Panel_dgv_PListed.Name = "Panel_dgv_PListed"
        Me.Panel_dgv_PListed.Size = New System.Drawing.Size(819, 200)
        Me.Panel_dgv_PListed.TabIndex = 36
        Me.Panel_dgv_PListed.Visible = False
        '
        'dgv_PList
        '
        Me.dgv_PList.AllowUserToAddRows = False
        Me.dgv_PList.AllowUserToDeleteRows = False
        Me.dgv_PList.AllowUserToOrderColumns = True
        Me.dgv_PList.AutoGenerateColumns = False
        Me.dgv_PList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_PList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_PList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WSCLHWPListIDDataGridViewTextBoxColumn, Me.LHWPUListIDDataGridViewTextBoxColumn1, Me.WSCLHWIDDataGridViewTextBoxColumn3, Me.LHW_PList_HWN, Me.LHW_PList_CAN, Me.LHW_PList_Substance})
        Me.dgv_PList.DataSource = Me.WSCLHWPListBindingSource
        Me.dgv_PList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_PList.Location = New System.Drawing.Point(0, 0)
        Me.dgv_PList.Name = "dgv_PList"
        Me.dgv_PList.ReadOnly = True
        Me.dgv_PList.RowHeadersWidth = 51
        Me.dgv_PList.RowTemplate.Height = 24
        Me.dgv_PList.Size = New System.Drawing.Size(819, 200)
        Me.dgv_PList.TabIndex = 32
        '
        'WSCLHWPListIDDataGridViewTextBoxColumn
        '
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_LHW_PList_ID"
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.HeaderText = "WSC_LHW_PList_ID"
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.Name = "WSCLHWPListIDDataGridViewTextBoxColumn"
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCLHWPListIDDataGridViewTextBoxColumn.Width = 125
        '
        'LHWPUListIDDataGridViewTextBoxColumn1
        '
        Me.LHWPUListIDDataGridViewTextBoxColumn1.DataPropertyName = "LHW_PUList_ID"
        Me.LHWPUListIDDataGridViewTextBoxColumn1.HeaderText = "LHW_PUList_ID"
        Me.LHWPUListIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.LHWPUListIDDataGridViewTextBoxColumn1.Name = "LHWPUListIDDataGridViewTextBoxColumn1"
        Me.LHWPUListIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LHWPUListIDDataGridViewTextBoxColumn1.Visible = False
        Me.LHWPUListIDDataGridViewTextBoxColumn1.Width = 125
        '
        'WSCLHWIDDataGridViewTextBoxColumn3
        '
        Me.WSCLHWIDDataGridViewTextBoxColumn3.DataPropertyName = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn3.HeaderText = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.WSCLHWIDDataGridViewTextBoxColumn3.Name = "WSCLHWIDDataGridViewTextBoxColumn3"
        Me.WSCLHWIDDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WSCLHWIDDataGridViewTextBoxColumn3.Visible = False
        Me.WSCLHWIDDataGridViewTextBoxColumn3.Width = 125
        '
        'LHW_PList_HWN
        '
        Me.LHW_PList_HWN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LHW_PList_HWN.DataPropertyName = "LHW_PUList_ID"
        Me.LHW_PList_HWN.DataSource = Me.TlkpLHWPUBindingSource
        Me.LHW_PList_HWN.DisplayMember = "Listed_PU_HWN"
        Me.LHW_PList_HWN.DisplayStyleForCurrentCellOnly = True
        Me.LHW_PList_HWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_PList_HWN.HeaderText = "Hazardous Waste No."
        Me.LHW_PList_HWN.MinimumWidth = 6
        Me.LHW_PList_HWN.Name = "LHW_PList_HWN"
        Me.LHW_PList_HWN.ReadOnly = True
        Me.LHW_PList_HWN.ValueMember = "Listed_PU_ID"
        Me.LHW_PList_HWN.Width = 157
        '
        'LHW_PList_CAN
        '
        Me.LHW_PList_CAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LHW_PList_CAN.DataPropertyName = "LHW_PUList_ID"
        Me.LHW_PList_CAN.DataSource = Me.TlkpLHWPUBindingSource
        Me.LHW_PList_CAN.DisplayMember = "Listed_PU_CAN"
        Me.LHW_PList_CAN.DisplayStyleForCurrentCellOnly = True
        Me.LHW_PList_CAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_PList_CAN.HeaderText = "Chemical Abstract No."
        Me.LHW_PList_CAN.MinimumWidth = 6
        Me.LHW_PList_CAN.Name = "LHW_PList_CAN"
        Me.LHW_PList_CAN.ReadOnly = True
        Me.LHW_PList_CAN.ValueMember = "Listed_PU_ID"
        Me.LHW_PList_CAN.Width = 162
        '
        'LHW_PList_Substance
        '
        Me.LHW_PList_Substance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LHW_PList_Substance.DataPropertyName = "LHW_PUList_ID"
        Me.LHW_PList_Substance.DataSource = Me.TlkpLHWPUBindingSource
        Me.LHW_PList_Substance.DisplayMember = "Listed_PU_Substance"
        Me.LHW_PList_Substance.DisplayStyleForCurrentCellOnly = True
        Me.LHW_PList_Substance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_PList_Substance.HeaderText = "Substance"
        Me.LHW_PList_Substance.MinimumWidth = 6
        Me.LHW_PList_Substance.Name = "LHW_PList_Substance"
        Me.LHW_PList_Substance.ReadOnly = True
        Me.LHW_PList_Substance.ValueMember = "Listed_PU_ID"
        '
        'WSCLHWPListBindingSource
        '
        Me.WSCLHWPListBindingSource.DataMember = "WSC_LHW_PList"
        Me.WSCLHWPListBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Panel_Listed_PList
        '
        Me.Panel_Listed_PList.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Listed_PList.Controls.Add(Me.btn_dgvViewPListed)
        Me.Panel_Listed_PList.Controls.Add(Me.rbtn_Listed_PYes)
        Me.Panel_Listed_PList.Controls.Add(Me.rbtn_Listed_PNo)
        Me.Panel_Listed_PList.Controls.Add(Label6)
        Me.Panel_Listed_PList.Controls.Add(Me.WSC_LHW_PList_NoteTextBox)
        Me.Panel_Listed_PList.Controls.Add(Me.WSC_LHW_PListCheckBox)
        Me.Panel_Listed_PList.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Listed_PList.Location = New System.Drawing.Point(0, 600)
        Me.Panel_Listed_PList.Name = "Panel_Listed_PList"
        Me.Panel_Listed_PList.Size = New System.Drawing.Size(819, 100)
        Me.Panel_Listed_PList.TabIndex = 29
        '
        'btn_dgvViewPListed
        '
        Me.btn_dgvViewPListed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dgvViewPListed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_dgvViewPListed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dgvViewPListed.FlatAppearance.BorderSize = 0
        Me.btn_dgvViewPListed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dgvViewPListed.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dgvViewPListed.ForeColor = System.Drawing.Color.White
        Me.btn_dgvViewPListed.Location = New System.Drawing.Point(641, 6)
        Me.btn_dgvViewPListed.Name = "btn_dgvViewPListed"
        Me.btn_dgvViewPListed.Size = New System.Drawing.Size(150, 30)
        Me.btn_dgvViewPListed.TabIndex = 28
        Me.btn_dgvViewPListed.Text = "View P-Listed"
        Me.btn_dgvViewPListed.UseVisualStyleBackColor = False
        '
        'rbtn_Listed_PYes
        '
        Me.rbtn_Listed_PYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_PYes.Location = New System.Drawing.Point(45, 7)
        Me.rbtn_Listed_PYes.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_PYes.Name = "rbtn_Listed_PYes"
        Me.rbtn_Listed_PYes.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_PYes.TabIndex = 30
        Me.rbtn_Listed_PYes.TabStop = True
        Me.rbtn_Listed_PYes.Text = "Yes"
        Me.rbtn_Listed_PYes.UseVisualStyleBackColor = True
        '
        'rbtn_Listed_PNo
        '
        Me.rbtn_Listed_PNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_PNo.Location = New System.Drawing.Point(128, 7)
        Me.rbtn_Listed_PNo.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_PNo.Name = "rbtn_Listed_PNo"
        Me.rbtn_Listed_PNo.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_PNo.TabIndex = 31
        Me.rbtn_Listed_PNo.TabStop = True
        Me.rbtn_Listed_PNo.Text = "No"
        Me.rbtn_Listed_PNo.UseVisualStyleBackColor = True
        '
        'WSC_LHW_PList_NoteTextBox
        '
        Me.WSC_LHW_PList_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_PList_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_LHWBindingSource, "WSC_LHW_PList_Note", True))
        Me.WSC_LHW_PList_NoteTextBox.Location = New System.Drawing.Point(45, 40)
        Me.WSC_LHW_PList_NoteTextBox.Multiline = True
        Me.WSC_LHW_PList_NoteTextBox.Name = "WSC_LHW_PList_NoteTextBox"
        Me.WSC_LHW_PList_NoteTextBox.Size = New System.Drawing.Size(746, 50)
        Me.WSC_LHW_PList_NoteTextBox.TabIndex = 13
        '
        'WSC_LHW_PListCheckBox
        '
        Me.WSC_LHW_PListCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_PListCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_LHWBindingSource, "WSC_LHW_PList", True))
        Me.WSC_LHW_PListCheckBox.Location = New System.Drawing.Point(11, 46)
        Me.WSC_LHW_PListCheckBox.Name = "WSC_LHW_PListCheckBox"
        Me.WSC_LHW_PListCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.WSC_LHW_PListCheckBox.TabIndex = 11
        Me.WSC_LHW_PListCheckBox.UseVisualStyleBackColor = True
        '
        'Panel_dgv_KListed
        '
        Me.Panel_dgv_KListed.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_dgv_KListed.Controls.Add(Me.dgv_KList)
        Me.Panel_dgv_KListed.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_dgv_KListed.Location = New System.Drawing.Point(0, 400)
        Me.Panel_dgv_KListed.Name = "Panel_dgv_KListed"
        Me.Panel_dgv_KListed.Size = New System.Drawing.Size(819, 200)
        Me.Panel_dgv_KListed.TabIndex = 28
        Me.Panel_dgv_KListed.Visible = False
        '
        'dgv_KList
        '
        Me.dgv_KList.AllowUserToAddRows = False
        Me.dgv_KList.AllowUserToDeleteRows = False
        Me.dgv_KList.AutoGenerateColumns = False
        Me.dgv_KList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_KList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_KList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_KList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WSCLHWKListIDDataGridViewTextBoxColumn, Me.LHWKListIDDataGridViewTextBoxColumn, Me.WSCLHWIDDataGridViewTextBoxColumn2, Me.LHW_KList_HWN, Me.LHW_KList_Description})
        Me.dgv_KList.DataSource = Me.WSCLHWKListBindingSource
        Me.dgv_KList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_KList.Location = New System.Drawing.Point(0, 0)
        Me.dgv_KList.Name = "dgv_KList"
        Me.dgv_KList.ReadOnly = True
        Me.dgv_KList.RowHeadersWidth = 51
        Me.dgv_KList.RowTemplate.Height = 24
        Me.dgv_KList.Size = New System.Drawing.Size(819, 200)
        Me.dgv_KList.TabIndex = 31
        '
        'WSCLHWKListIDDataGridViewTextBoxColumn
        '
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_LHW_KList_ID"
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.HeaderText = "WSC_LHW_KList_ID"
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.Name = "WSCLHWKListIDDataGridViewTextBoxColumn"
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCLHWKListIDDataGridViewTextBoxColumn.Width = 125
        '
        'LHWKListIDDataGridViewTextBoxColumn
        '
        Me.LHWKListIDDataGridViewTextBoxColumn.DataPropertyName = "LHW_KList_ID"
        Me.LHWKListIDDataGridViewTextBoxColumn.HeaderText = "LHW_KList_ID"
        Me.LHWKListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LHWKListIDDataGridViewTextBoxColumn.Name = "LHWKListIDDataGridViewTextBoxColumn"
        Me.LHWKListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LHWKListIDDataGridViewTextBoxColumn.Visible = False
        Me.LHWKListIDDataGridViewTextBoxColumn.Width = 125
        '
        'WSCLHWIDDataGridViewTextBoxColumn2
        '
        Me.WSCLHWIDDataGridViewTextBoxColumn2.DataPropertyName = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn2.HeaderText = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.WSCLHWIDDataGridViewTextBoxColumn2.Name = "WSCLHWIDDataGridViewTextBoxColumn2"
        Me.WSCLHWIDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.WSCLHWIDDataGridViewTextBoxColumn2.Visible = False
        Me.WSCLHWIDDataGridViewTextBoxColumn2.Width = 125
        '
        'LHW_KList_HWN
        '
        Me.LHW_KList_HWN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LHW_KList_HWN.DataPropertyName = "LHW_KList_ID"
        Me.LHW_KList_HWN.DataSource = Me.TlkpLHWFKBindingSource
        Me.LHW_KList_HWN.DisplayMember = "Listed_FK_HWN"
        Me.LHW_KList_HWN.DisplayStyleForCurrentCellOnly = True
        Me.LHW_KList_HWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_KList_HWN.HeaderText = "Hazardous Waste No."
        Me.LHW_KList_HWN.MinimumWidth = 6
        Me.LHW_KList_HWN.Name = "LHW_KList_HWN"
        Me.LHW_KList_HWN.ReadOnly = True
        Me.LHW_KList_HWN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LHW_KList_HWN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LHW_KList_HWN.ValueMember = "Listed_FK_ID"
        Me.LHW_KList_HWN.Width = 180
        '
        'TlkpLHWFKBindingSource
        '
        Me.TlkpLHWFKBindingSource.DataMember = "tlkpLHW_FK"
        Me.TlkpLHWFKBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'LHW_KList_Description
        '
        Me.LHW_KList_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LHW_KList_Description.DataPropertyName = "LHW_KList_ID"
        Me.LHW_KList_Description.DataSource = Me.TlkpLHWFKBindingSource
        Me.LHW_KList_Description.DisplayMember = "Listed_FK_Description"
        Me.LHW_KList_Description.DisplayStyleForCurrentCellOnly = True
        Me.LHW_KList_Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHW_KList_Description.HeaderText = "Description"
        Me.LHW_KList_Description.MinimumWidth = 6
        Me.LHW_KList_Description.Name = "LHW_KList_Description"
        Me.LHW_KList_Description.ReadOnly = True
        Me.LHW_KList_Description.ValueMember = "Listed_FK_ID"
        '
        'WSCLHWKListBindingSource
        '
        Me.WSCLHWKListBindingSource.DataMember = "WSC_LHW_KList"
        Me.WSCLHWKListBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Panel_Listed_KList
        '
        Me.Panel_Listed_KList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Listed_KList.Controls.Add(Me.btn_dgvViewKListed)
        Me.Panel_Listed_KList.Controls.Add(Me.rbtn_Listed_KYes)
        Me.Panel_Listed_KList.Controls.Add(Me.rbtn_Listed_KNo)
        Me.Panel_Listed_KList.Controls.Add(Label5)
        Me.Panel_Listed_KList.Controls.Add(Me.WSC_LHW_KList_NoteTextBox)
        Me.Panel_Listed_KList.Controls.Add(Me.WSC_LHW_KListCheckBox)
        Me.Panel_Listed_KList.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Listed_KList.Location = New System.Drawing.Point(0, 300)
        Me.Panel_Listed_KList.Name = "Panel_Listed_KList"
        Me.Panel_Listed_KList.Size = New System.Drawing.Size(819, 100)
        Me.Panel_Listed_KList.TabIndex = 29
        '
        'btn_dgvViewKListed
        '
        Me.btn_dgvViewKListed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dgvViewKListed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_dgvViewKListed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dgvViewKListed.FlatAppearance.BorderSize = 0
        Me.btn_dgvViewKListed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dgvViewKListed.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dgvViewKListed.ForeColor = System.Drawing.Color.White
        Me.btn_dgvViewKListed.Location = New System.Drawing.Point(641, 6)
        Me.btn_dgvViewKListed.Name = "btn_dgvViewKListed"
        Me.btn_dgvViewKListed.Size = New System.Drawing.Size(150, 30)
        Me.btn_dgvViewKListed.TabIndex = 30
        Me.btn_dgvViewKListed.Text = "View K-Listed"
        Me.btn_dgvViewKListed.UseVisualStyleBackColor = False
        '
        'rbtn_Listed_KYes
        '
        Me.rbtn_Listed_KYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_KYes.Location = New System.Drawing.Point(45, 7)
        Me.rbtn_Listed_KYes.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_KYes.Name = "rbtn_Listed_KYes"
        Me.rbtn_Listed_KYes.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_KYes.TabIndex = 28
        Me.rbtn_Listed_KYes.TabStop = True
        Me.rbtn_Listed_KYes.Text = "Yes"
        Me.rbtn_Listed_KYes.UseVisualStyleBackColor = True
        '
        'rbtn_Listed_KNo
        '
        Me.rbtn_Listed_KNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_KNo.Location = New System.Drawing.Point(128, 7)
        Me.rbtn_Listed_KNo.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_KNo.Name = "rbtn_Listed_KNo"
        Me.rbtn_Listed_KNo.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_KNo.TabIndex = 29
        Me.rbtn_Listed_KNo.TabStop = True
        Me.rbtn_Listed_KNo.Text = "No"
        Me.rbtn_Listed_KNo.UseVisualStyleBackColor = True
        '
        'WSC_LHW_KList_NoteTextBox
        '
        Me.WSC_LHW_KList_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_KList_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_LHWBindingSource, "WSC_LHW_KList_Note", True))
        Me.WSC_LHW_KList_NoteTextBox.Location = New System.Drawing.Point(45, 40)
        Me.WSC_LHW_KList_NoteTextBox.Multiline = True
        Me.WSC_LHW_KList_NoteTextBox.Name = "WSC_LHW_KList_NoteTextBox"
        Me.WSC_LHW_KList_NoteTextBox.Size = New System.Drawing.Size(746, 50)
        Me.WSC_LHW_KList_NoteTextBox.TabIndex = 9
        '
        'WSC_LHW_KListCheckBox
        '
        Me.WSC_LHW_KListCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_KListCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_LHWBindingSource, "WSC_LHW_KList", True))
        Me.WSC_LHW_KListCheckBox.Location = New System.Drawing.Point(11, 40)
        Me.WSC_LHW_KListCheckBox.Name = "WSC_LHW_KListCheckBox"
        Me.WSC_LHW_KListCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.WSC_LHW_KListCheckBox.TabIndex = 7
        Me.WSC_LHW_KListCheckBox.UseVisualStyleBackColor = True
        '
        'Panel_dgv_FListed
        '
        Me.Panel_dgv_FListed.AutoScroll = True
        Me.Panel_dgv_FListed.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_dgv_FListed.Controls.Add(Me.dgv_FList)
        Me.Panel_dgv_FListed.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_dgv_FListed.Location = New System.Drawing.Point(0, 100)
        Me.Panel_dgv_FListed.Name = "Panel_dgv_FListed"
        Me.Panel_dgv_FListed.Size = New System.Drawing.Size(819, 200)
        Me.Panel_dgv_FListed.TabIndex = 34
        Me.Panel_dgv_FListed.Visible = False
        '
        'dgv_FList
        '
        Me.dgv_FList.AllowUserToAddRows = False
        Me.dgv_FList.AllowUserToDeleteRows = False
        Me.dgv_FList.AutoGenerateColumns = False
        Me.dgv_FList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_FList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_FList.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_FList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_FList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WSCLHWFListIDDataGridViewTextBoxColumn, Me.LHWFListIDDataGridViewTextBoxColumn, Me.FList_Description, Me.WSCLHWIDDataGridViewTextBoxColumn})
        Me.dgv_FList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_FList.DataSource = Me.WSCLHWFListBindingSource
        Me.dgv_FList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_FList.Location = New System.Drawing.Point(0, 0)
        Me.dgv_FList.Name = "dgv_FList"
        Me.dgv_FList.ReadOnly = True
        Me.dgv_FList.RowHeadersWidth = 51
        Me.dgv_FList.RowTemplate.Height = 24
        Me.dgv_FList.Size = New System.Drawing.Size(819, 200)
        Me.dgv_FList.TabIndex = 31
        '
        'WSCLHWFListIDDataGridViewTextBoxColumn
        '
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_LHW_FList_ID"
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.HeaderText = "WSC_LHW_FList_ID"
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.Name = "WSCLHWFListIDDataGridViewTextBoxColumn"
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCLHWFListIDDataGridViewTextBoxColumn.Width = 207
        '
        'LHWFListIDDataGridViewTextBoxColumn
        '
        Me.LHWFListIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LHWFListIDDataGridViewTextBoxColumn.DataPropertyName = "LHW_FList_ID"
        Me.LHWFListIDDataGridViewTextBoxColumn.DataSource = Me.TlkpLHWFKBindingSource
        Me.LHWFListIDDataGridViewTextBoxColumn.DisplayMember = "Listed_FK_HWN"
        Me.LHWFListIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.LHWFListIDDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.LHWFListIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LHWFListIDDataGridViewTextBoxColumn.HeaderText = "HW Number"
        Me.LHWFListIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LHWFListIDDataGridViewTextBoxColumn.Name = "LHWFListIDDataGridViewTextBoxColumn"
        Me.LHWFListIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LHWFListIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LHWFListIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LHWFListIDDataGridViewTextBoxColumn.ValueMember = "Listed_FK_ID"
        Me.LHWFListIDDataGridViewTextBoxColumn.Width = 138
        '
        'FList_Description
        '
        Me.FList_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FList_Description.DataPropertyName = "LHW_FList_ID"
        Me.FList_Description.DataSource = Me.TlkpLHWFKBindingSource
        Me.FList_Description.DisplayMember = "Listed_FK_Description"
        Me.FList_Description.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FList_Description.DisplayStyleForCurrentCellOnly = True
        Me.FList_Description.HeaderText = "Waste Description"
        Me.FList_Description.MaxDropDownItems = 1
        Me.FList_Description.MinimumWidth = 6
        Me.FList_Description.Name = "FList_Description"
        Me.FList_Description.ReadOnly = True
        Me.FList_Description.ValueMember = "Listed_FK_ID"
        '
        'WSCLHWIDDataGridViewTextBoxColumn
        '
        Me.WSCLHWIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn.HeaderText = "WSC_LHW_ID"
        Me.WSCLHWIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCLHWIDDataGridViewTextBoxColumn.Name = "WSCLHWIDDataGridViewTextBoxColumn"
        Me.WSCLHWIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCLHWIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCLHWIDDataGridViewTextBoxColumn.Width = 160
        '
        'WSCLHWFListBindingSource
        '
        Me.WSCLHWFListBindingSource.DataMember = "WSC_LHW_FList"
        Me.WSCLHWFListBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Panel_Listed_FList
        '
        Me.Panel_Listed_FList.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Listed_FList.Controls.Add(Me.Button1)
        Me.Panel_Listed_FList.Controls.Add(WSC_LHW_FListLabel)
        Me.Panel_Listed_FList.Controls.Add(Me.WSC_LHW_FList_NoteTextBox)
        Me.Panel_Listed_FList.Controls.Add(Me.WSC_LHW_FListCheckBox)
        Me.Panel_Listed_FList.Controls.Add(Me.rbtn_Listed_FYes)
        Me.Panel_Listed_FList.Controls.Add(Me.rbtn_Listed_FNo)
        Me.Panel_Listed_FList.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Listed_FList.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Listed_FList.Name = "Panel_Listed_FList"
        Me.Panel_Listed_FList.Size = New System.Drawing.Size(819, 100)
        Me.Panel_Listed_FList.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(641, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "View F-Listed"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WSC_LHW_FList_NoteTextBox
        '
        Me.WSC_LHW_FList_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_FList_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_LHWBindingSource, "WSC_LHW_FList_Note", True))
        Me.WSC_LHW_FList_NoteTextBox.Location = New System.Drawing.Point(45, 40)
        Me.WSC_LHW_FList_NoteTextBox.Multiline = True
        Me.WSC_LHW_FList_NoteTextBox.Name = "WSC_LHW_FList_NoteTextBox"
        Me.WSC_LHW_FList_NoteTextBox.Size = New System.Drawing.Size(746, 50)
        Me.WSC_LHW_FList_NoteTextBox.TabIndex = 5
        '
        'WSC_LHW_FListCheckBox
        '
        Me.WSC_LHW_FListCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_LHWBindingSource, "WSC_LHW_FList", True))
        Me.WSC_LHW_FListCheckBox.Location = New System.Drawing.Point(11, 40)
        Me.WSC_LHW_FListCheckBox.Name = "WSC_LHW_FListCheckBox"
        Me.WSC_LHW_FListCheckBox.Size = New System.Drawing.Size(28, 24)
        Me.WSC_LHW_FListCheckBox.TabIndex = 3
        Me.WSC_LHW_FListCheckBox.UseVisualStyleBackColor = True
        '
        'rbtn_Listed_FYes
        '
        Me.rbtn_Listed_FYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_FYes.Location = New System.Drawing.Point(45, 7)
        Me.rbtn_Listed_FYes.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_FYes.Name = "rbtn_Listed_FYes"
        Me.rbtn_Listed_FYes.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_FYes.TabIndex = 21
        Me.rbtn_Listed_FYes.TabStop = True
        Me.rbtn_Listed_FYes.Text = "Yes"
        Me.rbtn_Listed_FYes.UseVisualStyleBackColor = True
        '
        'rbtn_Listed_FNo
        '
        Me.rbtn_Listed_FNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_Listed_FNo.Location = New System.Drawing.Point(128, 7)
        Me.rbtn_Listed_FNo.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtn_Listed_FNo.Name = "rbtn_Listed_FNo"
        Me.rbtn_Listed_FNo.Size = New System.Drawing.Size(82, 30)
        Me.rbtn_Listed_FNo.TabIndex = 22
        Me.rbtn_Listed_FNo.TabStop = True
        Me.rbtn_Listed_FNo.Text = "No"
        Me.rbtn_Listed_FNo.UseVisualStyleBackColor = True
        '
        'Panel_ListedHazardousWaste
        '
        Me.Panel_ListedHazardousWaste.AutoScroll = True
        Me.Panel_ListedHazardousWaste.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_ListedHazardousWaste.Controls.Add(WSC_LHW_IDLabel)
        Me.Panel_ListedHazardousWaste.Controls.Add(Me.WSC_LHW_IDTextBox)
        Me.Panel_ListedHazardousWaste.Controls.Add(Me.WSC_IDTextBox2)
        Me.Panel_ListedHazardousWaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ListedHazardousWaste.Location = New System.Drawing.Point(0, 600)
        Me.Panel_ListedHazardousWaste.Name = "Panel_ListedHazardousWaste"
        Me.Panel_ListedHazardousWaste.Size = New System.Drawing.Size(840, 49)
        Me.Panel_ListedHazardousWaste.TabIndex = 19
        Me.Panel_ListedHazardousWaste.Visible = False
        '
        'WSC_LHW_IDTextBox
        '
        Me.WSC_LHW_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_LHW_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_LHWBindingSource, "WSC_LHW_ID", True))
        Me.WSC_LHW_IDTextBox.Location = New System.Drawing.Point(795, 6)
        Me.WSC_LHW_IDTextBox.Name = "WSC_LHW_IDTextBox"
        Me.WSC_LHW_IDTextBox.Size = New System.Drawing.Size(33, 34)
        Me.WSC_LHW_IDTextBox.TabIndex = 1
        '
        'WSC_IDTextBox2
        '
        Me.WSC_IDTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_IDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_LHWBindingSource, "WSC_ID", True))
        Me.WSC_IDTextBox2.Location = New System.Drawing.Point(753, 4)
        Me.WSC_IDTextBox2.Name = "WSC_IDTextBox2"
        Me.WSC_IDTextBox2.Size = New System.Drawing.Size(36, 34)
        Me.WSC_IDTextBox2.TabIndex = 19
        '
        'Excluded_S261_4vExempt_YCitationTextBox
        '
        Me.Excluded_S261_4vExempt_YCitationTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Excluded_S261_4vExempt_YCitationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SWE_261_4BindingSource, "Excluded_S261_4vExempt_YCitation", True))
        Me.Excluded_S261_4vExempt_YCitationTextBox.Location = New System.Drawing.Point(45, 72)
        Me.Excluded_S261_4vExempt_YCitationTextBox.Name = "Excluded_S261_4vExempt_YCitationTextBox"
        Me.Excluded_S261_4vExempt_YCitationTextBox.Size = New System.Drawing.Size(746, 34)
        Me.Excluded_S261_4vExempt_YCitationTextBox.TabIndex = 27
        '
        'Excluded_S261_4vExempt_YDescriptionTextBox
        '
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_SWE_261_4BindingSource, "Excluded_S261_4vExempt_YDescription", True))
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.Location = New System.Drawing.Point(45, 144)
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.Multiline = True
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.Name = "Excluded_S261_4vExempt_YDescriptionTextBox"
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.Size = New System.Drawing.Size(745, 85)
        Me.Excluded_S261_4vExempt_YDescriptionTextBox.TabIndex = 29
        '
        'Panel_SolidWaste_Details
        '
        Me.Panel_SolidWaste_Details.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_SolidWaste_Details.Controls.Add(Solid_261_2_NTypeLabel)
        Me.Panel_SolidWaste_Details.Controls.Add(Solid_261_2_NCitationLabel)
        Me.Panel_SolidWaste_Details.Controls.Add(Me.Solid_261_2_NCitationTextBox)
        Me.Panel_SolidWaste_Details.Controls.Add(Me.Solid_261_2_NDescriptionTextBox)
        Me.Panel_SolidWaste_Details.Controls.Add(Solid_261_2_NDescriptionLabel)
        Me.Panel_SolidWaste_Details.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_SolidWaste_Details.Location = New System.Drawing.Point(0, 50)
        Me.Panel_SolidWaste_Details.Name = "Panel_SolidWaste_Details"
        Me.Panel_SolidWaste_Details.Size = New System.Drawing.Size(840, 250)
        Me.Panel_SolidWaste_Details.TabIndex = 18
        Me.Panel_SolidWaste_Details.Visible = False
        '
        'Panel_ExcludedWaste_Detail
        '
        Me.Panel_ExcludedWaste_Detail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_ExcludedWaste_Detail.Controls.Add(Label2)
        Me.Panel_ExcludedWaste_Detail.Controls.Add(Excluded_S261_4vExempt_YCitationLabel)
        Me.Panel_ExcludedWaste_Detail.Controls.Add(Me.Excluded_S261_4vExempt_YCitationTextBox)
        Me.Panel_ExcludedWaste_Detail.Controls.Add(Excluded_S261_4vExempt_YDescriptionLabel)
        Me.Panel_ExcludedWaste_Detail.Controls.Add(Me.Excluded_S261_4vExempt_YDescriptionTextBox)
        Me.Panel_ExcludedWaste_Detail.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ExcludedWaste_Detail.Location = New System.Drawing.Point(0, 350)
        Me.Panel_ExcludedWaste_Detail.Name = "Panel_ExcludedWaste_Detail"
        Me.Panel_ExcludedWaste_Detail.Size = New System.Drawing.Size(840, 250)
        Me.Panel_ExcludedWaste_Detail.TabIndex = 20
        Me.Panel_ExcludedWaste_Detail.Visible = False
        '
        'WSC_SW_261_2TableAdapter
        '
        Me.WSC_SW_261_2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_WasteGeneratorTableAdapter = Nothing
        Me.TableAdapterManager.LibraryTableAdapter = Nothing
        Me.TableAdapterManager.SDSTableAdapter = Nothing
        Me.TableAdapterManager.sysdiagramsTableAdapter = Nothing
        Me.TableAdapterManager.tlkpCHW_Toxic_CategoryTableAdapter = Nothing
        Me.TableAdapterManager.tlkpCHW_Toxic_ConstituentTableAdapter = Nothing
        Me.TableAdapterManager.tlkpEmployee_TitleTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHazard_ClassTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHazard_TypeTableAdapter = Nothing
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
        'Me.TableAdapterManager.trace_xe_event_mapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnviroHealthSafety_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WSC_CHW_ToxicConstituentTableAdapter = Nothing
        Me.TableAdapterManager.WSC_CHWTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_FListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_KListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_PListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_UListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHWTableAdapter = Me.WSC_LHWTableAdapter
        Me.TableAdapterManager.WSC_RCRA_DeterminationTableAdapter = Nothing
        Me.TableAdapterManager.WSC_SupportingDocumentTableAdapter = Nothing
        Me.TableAdapterManager.WSC_SW_261_2TableAdapter = Me.WSC_SW_261_2TableAdapter
        Me.TableAdapterManager.WSC_SWE_261_4TableAdapter = Me.WSC_SWE_261_4TableAdapter
        Me.TableAdapterManager.WSC_WSD_UserKnowledgeTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSD_WasteAnalysisTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTD_UHCListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTDTableAdapter = Nothing
        Me.TableAdapterManager.WSCTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Nothing
        '
        'WSC_LHWTableAdapter
        '
        Me.WSC_LHWTableAdapter.ClearBeforeFill = True
        '
        'WSC_SWE_261_4TableAdapter
        '
        Me.WSC_SWE_261_4TableAdapter.ClearBeforeFill = True
        '
        'WSC_LHW_FListTableAdapter
        '
        Me.WSC_LHW_FListTableAdapter.ClearBeforeFill = True
        '
        'WSC_LHW_UListTableAdapter
        '
        Me.WSC_LHW_UListTableAdapter.ClearBeforeFill = True
        '
        'WSCLHWUListBindingSource1
        '
        Me.WSCLHWUListBindingSource1.DataMember = "WSC_LHW_UList"
        Me.WSCLHWUListBindingSource1.DataSource = Me.EnviroHealthSafety_Data
        '
        'TlkpLHW_PUTableAdapter
        '
        Me.TlkpLHW_PUTableAdapter.ClearBeforeFill = True
        '
        'WSC_LHW_KListTableAdapter
        '
        Me.WSC_LHW_KListTableAdapter.ClearBeforeFill = True
        '
        'WSC_LHW_PListTableAdapter
        '
        Me.WSC_LHW_PListTableAdapter.ClearBeforeFill = True
        '
        'Panel_CharacteristicWaste
        '
        Me.Panel_CharacteristicWaste.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton7)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton8)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton5)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton6)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton3)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton4)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton1)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.RadioButton2)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.lbl_CHW_HeaderText)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_IDTextBox)
        Me.Panel_CharacteristicWaste.Controls.Add(WSC_CHW_IgnitableLabel)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_IgnitableCheckBox)
        Me.Panel_CharacteristicWaste.Controls.Add(WSC_CHW_Ignitable_NoteLabel)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_Ignitable_NoteTextBox)
        Me.Panel_CharacteristicWaste.Controls.Add(WSC_CHW_CorrosiveLabel)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_CorrosiveCheckBox)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_Corrosive_NoteTextBox)
        Me.Panel_CharacteristicWaste.Controls.Add(WSC_CHW_ReactiveLabel)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_ReactiveCheckBox)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_CHW_Reactive_NoteTextBox)
        Me.Panel_CharacteristicWaste.Controls.Add(WCS_CHW_ToxicLabel)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WCS_CHW_ToxicCheckBox)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WCS_CHW_Toxic_NoteTextBox)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.WSC_IDTextBox3)
        Me.Panel_CharacteristicWaste.Controls.Add(Me.Panel_ChacteristicWaste_Toxic)
        Me.Panel_CharacteristicWaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_CharacteristicWaste.Location = New System.Drawing.Point(0, 1049)
        Me.Panel_CharacteristicWaste.Name = "Panel_CharacteristicWaste"
        Me.Panel_CharacteristicWaste.Size = New System.Drawing.Size(840, 525)
        Me.Panel_CharacteristicWaste.TabIndex = 30
        Me.Panel_CharacteristicWaste.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(45, 252)
        Me.RadioButton7.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton7.TabIndex = 32
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Yes"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(128, 252)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton8.TabIndex = 33
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "No"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(45, 182)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton5.TabIndex = 30
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Yes"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(128, 182)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton6.TabIndex = 31
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "No"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(45, 112)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton3.TabIndex = 28
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Yes"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(128, 112)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton4.TabIndex = 29
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "No"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(45, 42)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton1.TabIndex = 26
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(128, 41)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 30)
        Me.RadioButton2.TabIndex = 27
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'lbl_CHW_HeaderText
        '
        Me.lbl_CHW_HeaderText.AutoSize = True
        Me.lbl_CHW_HeaderText.Location = New System.Drawing.Point(13, 10)
        Me.lbl_CHW_HeaderText.Name = "lbl_CHW_HeaderText"
        Me.lbl_CHW_HeaderText.Size = New System.Drawing.Size(669, 28)
        Me.lbl_CHW_HeaderText.TabIndex = 21
        Me.lbl_CHW_HeaderText.Text = "Is the waste a characteristic hazardous waste? (Detail rationale, as necessary)"
        '
        'WSC_CHW_IDTextBox
        '
        Me.WSC_CHW_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_CHWBindingSource, "WSC_CHW_ID", True))
        Me.WSC_CHW_IDTextBox.Location = New System.Drawing.Point(763, 10)
        Me.WSC_CHW_IDTextBox.Name = "WSC_CHW_IDTextBox"
        Me.WSC_CHW_IDTextBox.Size = New System.Drawing.Size(28, 34)
        Me.WSC_CHW_IDTextBox.TabIndex = 2
        '
        'WSC_CHWBindingSource
        '
        Me.WSC_CHWBindingSource.DataMember = "WSC_CHW"
        Me.WSC_CHWBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'WSC_CHW_IgnitableCheckBox
        '
        Me.WSC_CHW_IgnitableCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_IgnitableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_CHWBindingSource, "WSC_CHW_Ignitable", True))
        Me.WSC_CHW_IgnitableCheckBox.Location = New System.Drawing.Point(815, 45)
        Me.WSC_CHW_IgnitableCheckBox.Name = "WSC_CHW_IgnitableCheckBox"
        Me.WSC_CHW_IgnitableCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.WSC_CHW_IgnitableCheckBox.TabIndex = 4
        Me.WSC_CHW_IgnitableCheckBox.UseVisualStyleBackColor = True
        '
        'WSC_CHW_Ignitable_NoteTextBox
        '
        Me.WSC_CHW_Ignitable_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_Ignitable_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_CHWBindingSource, "WSC_CHW_Ignitable_Note", True))
        Me.WSC_CHW_Ignitable_NoteTextBox.Location = New System.Drawing.Point(45, 74)
        Me.WSC_CHW_Ignitable_NoteTextBox.Multiline = True
        Me.WSC_CHW_Ignitable_NoteTextBox.Name = "WSC_CHW_Ignitable_NoteTextBox"
        Me.WSC_CHW_Ignitable_NoteTextBox.Size = New System.Drawing.Size(746, 35)
        Me.WSC_CHW_Ignitable_NoteTextBox.TabIndex = 6
        '
        'WSC_CHW_CorrosiveCheckBox
        '
        Me.WSC_CHW_CorrosiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_CorrosiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_CHWBindingSource, "WSC_CHW_Corrosive", True))
        Me.WSC_CHW_CorrosiveCheckBox.Location = New System.Drawing.Point(815, 118)
        Me.WSC_CHW_CorrosiveCheckBox.Name = "WSC_CHW_CorrosiveCheckBox"
        Me.WSC_CHW_CorrosiveCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.WSC_CHW_CorrosiveCheckBox.TabIndex = 8
        Me.WSC_CHW_CorrosiveCheckBox.UseVisualStyleBackColor = True
        '
        'WSC_CHW_Corrosive_NoteTextBox
        '
        Me.WSC_CHW_Corrosive_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_Corrosive_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_CHWBindingSource, "WSC_CHW_Corrosive_Note", True))
        Me.WSC_CHW_Corrosive_NoteTextBox.Location = New System.Drawing.Point(45, 144)
        Me.WSC_CHW_Corrosive_NoteTextBox.Multiline = True
        Me.WSC_CHW_Corrosive_NoteTextBox.Name = "WSC_CHW_Corrosive_NoteTextBox"
        Me.WSC_CHW_Corrosive_NoteTextBox.Size = New System.Drawing.Size(746, 35)
        Me.WSC_CHW_Corrosive_NoteTextBox.TabIndex = 10
        '
        'WSC_CHW_ReactiveCheckBox
        '
        Me.WSC_CHW_ReactiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_ReactiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_CHWBindingSource, "WSC_CHW_Reactive", True))
        Me.WSC_CHW_ReactiveCheckBox.Location = New System.Drawing.Point(815, 190)
        Me.WSC_CHW_ReactiveCheckBox.Name = "WSC_CHW_ReactiveCheckBox"
        Me.WSC_CHW_ReactiveCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.WSC_CHW_ReactiveCheckBox.TabIndex = 12
        Me.WSC_CHW_ReactiveCheckBox.UseVisualStyleBackColor = True
        '
        'WSC_CHW_Reactive_NoteTextBox
        '
        Me.WSC_CHW_Reactive_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_CHW_Reactive_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_CHWBindingSource, "WSC_CHW_Reactive_Note", True))
        Me.WSC_CHW_Reactive_NoteTextBox.Location = New System.Drawing.Point(45, 214)
        Me.WSC_CHW_Reactive_NoteTextBox.Multiline = True
        Me.WSC_CHW_Reactive_NoteTextBox.Name = "WSC_CHW_Reactive_NoteTextBox"
        Me.WSC_CHW_Reactive_NoteTextBox.Size = New System.Drawing.Size(746, 35)
        Me.WSC_CHW_Reactive_NoteTextBox.TabIndex = 14
        '
        'WCS_CHW_ToxicCheckBox
        '
        Me.WCS_CHW_ToxicCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WCS_CHW_ToxicCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSC_CHWBindingSource, "WCS_CHW_Toxic", True))
        Me.WCS_CHW_ToxicCheckBox.Location = New System.Drawing.Point(815, 256)
        Me.WCS_CHW_ToxicCheckBox.Name = "WCS_CHW_ToxicCheckBox"
        Me.WCS_CHW_ToxicCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.WCS_CHW_ToxicCheckBox.TabIndex = 16
        Me.WCS_CHW_ToxicCheckBox.UseVisualStyleBackColor = True
        '
        'WCS_CHW_Toxic_NoteTextBox
        '
        Me.WCS_CHW_Toxic_NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WCS_CHW_Toxic_NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_CHWBindingSource, "WCS_CHW_Toxic_Note", True))
        Me.WCS_CHW_Toxic_NoteTextBox.Location = New System.Drawing.Point(45, 284)
        Me.WCS_CHW_Toxic_NoteTextBox.Multiline = True
        Me.WCS_CHW_Toxic_NoteTextBox.Name = "WCS_CHW_Toxic_NoteTextBox"
        Me.WCS_CHW_Toxic_NoteTextBox.Size = New System.Drawing.Size(746, 35)
        Me.WCS_CHW_Toxic_NoteTextBox.TabIndex = 18
        '
        'WSC_IDTextBox3
        '
        Me.WSC_IDTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_IDTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSC_CHWBindingSource, "WSC_ID", True))
        Me.WSC_IDTextBox3.Location = New System.Drawing.Point(803, 10)
        Me.WSC_IDTextBox3.Name = "WSC_IDTextBox3"
        Me.WSC_IDTextBox3.Size = New System.Drawing.Size(25, 34)
        Me.WSC_IDTextBox3.TabIndex = 20
        '
        'Panel_ChacteristicWaste_Toxic
        '
        Me.Panel_ChacteristicWaste_Toxic.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_ChacteristicWaste_Toxic.Controls.Add(Me.DataGridView1)
        Me.Panel_ChacteristicWaste_Toxic.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_ChacteristicWaste_Toxic.Location = New System.Drawing.Point(0, 325)
        Me.Panel_ChacteristicWaste_Toxic.Name = "Panel_ChacteristicWaste_Toxic"
        Me.Panel_ChacteristicWaste_Toxic.Size = New System.Drawing.Size(840, 200)
        Me.Panel_ChacteristicWaste_Toxic.TabIndex = 0
        Me.Panel_ChacteristicWaste_Toxic.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn, Me.WSCCHWIDDataGridViewTextBoxColumn, Me.ToxicConstituentIDDataGridViewTextBoxColumn, Me.ToxicConstituent_HWN, Me.ToxicConstituent_Contaminant, Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WSCCHWToxicConstituentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(823, 160)
        Me.DataGridView1.TabIndex = 0
        '
        'WSCToxicConstiuentIDDataGridViewTextBoxColumn
        '
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_ToxicConstiuent_ID"
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.HeaderText = "WSC_ToxicConstiuent_ID"
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.Name = "WSCToxicConstiuentIDDataGridViewTextBoxColumn"
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCToxicConstiuentIDDataGridViewTextBoxColumn.Width = 125
        '
        'WSCCHWIDDataGridViewTextBoxColumn
        '
        Me.WSCCHWIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_CHW_ID"
        Me.WSCCHWIDDataGridViewTextBoxColumn.HeaderText = "WSC_CHW_ID"
        Me.WSCCHWIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCCHWIDDataGridViewTextBoxColumn.Name = "WSCCHWIDDataGridViewTextBoxColumn"
        Me.WSCCHWIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCCHWIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCCHWIDDataGridViewTextBoxColumn.Width = 125
        '
        'ToxicConstituentIDDataGridViewTextBoxColumn
        '
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.DataPropertyName = "ToxicConstituent_ID"
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.HeaderText = "ToxicConstituent_ID"
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.Name = "ToxicConstituentIDDataGridViewTextBoxColumn"
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.Visible = False
        Me.ToxicConstituentIDDataGridViewTextBoxColumn.Width = 125
        '
        'ToxicConstituent_HWN
        '
        Me.ToxicConstituent_HWN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ToxicConstituent_HWN.DataPropertyName = "ToxicConstituent_ID"
        Me.ToxicConstituent_HWN.DataSource = Me.TlkpCHWToxicConstituentBindingSource
        Me.ToxicConstituent_HWN.DisplayMember = "ToxicConstituent_HWN"
        Me.ToxicConstituent_HWN.HeaderText = "Hazardous Waste No. "
        Me.ToxicConstituent_HWN.MinimumWidth = 6
        Me.ToxicConstituent_HWN.Name = "ToxicConstituent_HWN"
        Me.ToxicConstituent_HWN.ReadOnly = True
        Me.ToxicConstituent_HWN.ValueMember = "ToxicConstituent_ID"
        Me.ToxicConstituent_HWN.Width = 157
        '
        'TlkpCHWToxicConstituentBindingSource
        '
        Me.TlkpCHWToxicConstituentBindingSource.DataMember = "tlkpCHW_Toxic_Constituent"
        Me.TlkpCHWToxicConstituentBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'ToxicConstituent_Contaminant
        '
        Me.ToxicConstituent_Contaminant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ToxicConstituent_Contaminant.DataPropertyName = "ToxicConstituent_ID"
        Me.ToxicConstituent_Contaminant.DataSource = Me.TlkpCHWToxicConstituentBindingSource
        Me.ToxicConstituent_Contaminant.DisplayMember = "ToxicConstituent_Contaminant"
        Me.ToxicConstituent_Contaminant.HeaderText = "Contaminant"
        Me.ToxicConstituent_Contaminant.MinimumWidth = 6
        Me.ToxicConstituent_Contaminant.Name = "ToxicConstituent_Contaminant"
        Me.ToxicConstituent_Contaminant.ReadOnly = True
        Me.ToxicConstituent_Contaminant.ValueMember = "ToxicConstituent_ID"
        '
        'ToxicConstituentDescriptionDataGridViewTextBoxColumn
        '
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ToxicConstituent_Description"
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn.HeaderText = "ToxicConstituent_Description"
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn.Name = "ToxicConstituentDescriptionDataGridViewTextBoxColumn"
        Me.ToxicConstituentDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WSCCHWToxicConstituentBindingSource
        '
        Me.WSCCHWToxicConstituentBindingSource.DataMember = "WSC_CHW_ToxicConstituent"
        Me.WSCCHWToxicConstituentBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'WSC_CHWTableAdapter
        '
        Me.WSC_CHWTableAdapter.ClearBeforeFill = True
        '
        'WSC_CHW_ToxicConstituentTableAdapter
        '
        Me.WSC_CHW_ToxicConstituentTableAdapter.ClearBeforeFill = True
        '
        'TlkpCHW_Toxic_ConstituentTableAdapter
        '
        Me.TlkpCHW_Toxic_ConstituentTableAdapter.ClearBeforeFill = True
        '
        'TlkpLHW_FKTableAdapter
        '
        Me.TlkpLHW_FKTableAdapter.ClearBeforeFill = True
        '
        'frmWSC_WSD_Identification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(861, 1181)
        Me.Controls.Add(Me.Panel_CharacteristicWaste)
        Me.Controls.Add(Me.Panel_Listed_Control)
        Me.Controls.Add(Me.Panel_ListedHazardousWaste)
        Me.Controls.Add(Me.Panel_ExcludedWaste_Detail)
        Me.Controls.Add(Me.Panel_ExcludedWaste)
        Me.Controls.Add(Me.Panel_SolidWaste_Details)
        Me.Controls.Add(Me.Panel_SolidWaste)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmWSC_WSD_Identification"
        Me.Text = "Hazardous Waste Identification Process"
        CType(Me.WSC_SW_261_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_SolidWaste.ResumeLayout(False)
        Me.Panel_SolidWaste.PerformLayout()
        Me.Panel_ExcludedWaste.ResumeLayout(False)
        Me.Panel_ExcludedWaste.PerformLayout()
        CType(Me.WSC_SWE_261_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Listed_Control.ResumeLayout(False)
        Me.Panel_dgv_UListed.ResumeLayout(False)
        CType(Me.dgv_UList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpLHWPUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCLHWUListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Listed_UList.ResumeLayout(False)
        Me.Panel_Listed_UList.PerformLayout()
        CType(Me.WSC_LHWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_dgv_PListed.ResumeLayout(False)
        CType(Me.dgv_PList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCLHWPListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Listed_PList.ResumeLayout(False)
        Me.Panel_Listed_PList.PerformLayout()
        Me.Panel_dgv_KListed.ResumeLayout(False)
        CType(Me.dgv_KList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpLHWFKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCLHWKListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Listed_KList.ResumeLayout(False)
        Me.Panel_Listed_KList.PerformLayout()
        Me.Panel_dgv_FListed.ResumeLayout(False)
        CType(Me.dgv_FList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCLHWFListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Listed_FList.ResumeLayout(False)
        Me.Panel_Listed_FList.PerformLayout()
        Me.Panel_ListedHazardousWaste.ResumeLayout(False)
        Me.Panel_ListedHazardousWaste.PerformLayout()
        Me.Panel_SolidWaste_Details.ResumeLayout(False)
        Me.Panel_SolidWaste_Details.PerformLayout()
        Me.Panel_ExcludedWaste_Detail.ResumeLayout(False)
        Me.Panel_ExcludedWaste_Detail.PerformLayout()
        CType(Me.WSCLHWUListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_CharacteristicWaste.ResumeLayout(False)
        Me.Panel_CharacteristicWaste.PerformLayout()
        CType(Me.WSC_CHWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ChacteristicWaste_Toxic.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpCHWToxicConstituentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCCHWToxicConstituentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents WSC_SW_261_2BindingSource As BindingSource
    Friend WithEvents WSC_SW_261_2TableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_SW_261_2TableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents Solid261_2_IDTextBox As TextBox
    Friend WithEvents WSC_IDTextBox As TextBox
    Friend WithEvents Solid_261_2CheckBox As CheckBox
    Friend WithEvents Solid_261_2_NCitationTextBox As TextBox
    Friend WithEvents Solid_261_2_NDescriptionTextBox As TextBox
    Friend WithEvents rbtn_261_2Yes As RadioButton
    Friend WithEvents rbtn_261_2No As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents WSC_SWE_261_4TableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_SWE_261_4TableAdapter
    Friend WithEvents Panel_SolidWaste As Panel
    Friend WithEvents Panel_ExcludedWaste As Panel
    Friend WithEvents Panel_Listed_Control As Panel
    Friend WithEvents Panel_ListedHazardousWaste As Panel
    Friend WithEvents WSC_SWE_261_4BindingSource As BindingSource
    Friend WithEvents Panel_SolidWaste_Details As Panel
    Friend WithEvents Panel_ExcludedWaste_Detail As Panel
    Friend WithEvents Excluded_S261_4vExempt_YCitationTextBox As TextBox
    Friend WithEvents Excluded_S261_4vExempt_YDescriptionTextBox As TextBox
    Friend WithEvents rbtn_261_4No As RadioButton
    Friend WithEvents Excluded_S261_4_IDTextBox As TextBox
    Friend WithEvents rbtn_261_4Yes As RadioButton
    Friend WithEvents WSC_IDTextBox1 As TextBox
    Friend WithEvents Excluded_S261_4vExemptCheckBox As CheckBox
    Friend WithEvents WSC_LHWTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_LHWTableAdapter
    Friend WithEvents WSC_LHWBindingSource As BindingSource
    Friend WithEvents WSC_LHW_IDTextBox As TextBox
    Friend WithEvents WSC_LHW_FListCheckBox As CheckBox
    Friend WithEvents WSC_LHW_FList_NoteTextBox As TextBox
    Friend WithEvents WSC_LHW_PListCheckBox As CheckBox
    Friend WithEvents WSC_LHW_PList_NoteTextBox As TextBox
    Friend WithEvents WSC_LHW_UListCheckBox As CheckBox
    Friend WithEvents WSC_LHW_UList_NoteTextBox As TextBox
    Friend WithEvents WSC_IDTextBox2 As TextBox
    Friend WithEvents rbtn_Listed_FNo As RadioButton
    Friend WithEvents rbtn_Listed_FYes As RadioButton
    Friend WithEvents Panel_Listed_FList As Panel
    Friend WithEvents Panel_Listed_UList As Panel
    Friend WithEvents rbtn_Listed_UYes As RadioButton
    Friend WithEvents rbtn_Listed_UNo As RadioButton
    Friend WithEvents Panel_Listed_PList As Panel
    Friend WithEvents rbtn_Listed_PYes As RadioButton
    Friend WithEvents rbtn_Listed_PNo As RadioButton
    Friend WithEvents WSCLHWFListBindingSource As BindingSource
    Friend WithEvents WSC_LHW_FListTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_LHW_FListTableAdapter
    Friend WithEvents TlkpLHWFKBindingSource As BindingSource
    Friend WithEvents TlkpLHW_FKTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpLHW_FKTableAdapter
    Friend WithEvents Panel_Listed_KList As Panel
    Friend WithEvents rbtn_Listed_KYes As RadioButton
    Friend WithEvents rbtn_Listed_KNo As RadioButton
    Friend WithEvents WSC_LHW_KList_NoteTextBox As TextBox
    Friend WithEvents WSC_LHW_KListCheckBox As CheckBox
    Friend WithEvents Panel_dgv_FListed As Panel
    Friend WithEvents dgv_FList As DataGridView
    Friend WithEvents WSCLHWFListIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LHWFListIDDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FList_Description As DataGridViewComboBoxColumn
    Friend WithEvents WSCLHWIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgv_UList As DataGridView
    Friend WithEvents dgv_PList As DataGridView
    Friend WithEvents dgv_KList As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_dgv_UListed As Panel
    Friend WithEvents WSCLHWUListBindingSource As BindingSource
    Friend WithEvents WSC_LHW_UListTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_LHW_UListTableAdapter
    Friend WithEvents WSCLHWUListBindingSource1 As BindingSource
    Friend WithEvents TlkpLHWPUBindingSource As BindingSource
    Friend WithEvents TlkpLHW_PUTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpLHW_PUTableAdapter
    Friend WithEvents WSCLHWUListIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WSCLHWIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LHWPUListIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LHW_PUList_HWN As DataGridViewComboBoxColumn
    Friend WithEvents LHW_PUList_AbstractNo As DataGridViewComboBoxColumn
    Friend WithEvents LHW_PUList_Substance As DataGridViewComboBoxColumn
    Friend WithEvents btn_dgvViewUListed As Button
    Friend WithEvents Panel_dgv_KListed As Panel
    Friend WithEvents Panel_dgv_PListed As Panel
    Friend WithEvents WSCLHWKListBindingSource As BindingSource
    Friend WithEvents WSC_LHW_KListTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_LHW_KListTableAdapter
    Friend WithEvents WSCLHWKListIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LHWKListIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WSCLHWIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LHW_KList_HWN As DataGridViewComboBoxColumn
    Friend WithEvents LHW_KList_Description As DataGridViewComboBoxColumn
    Friend WithEvents btn_dgvViewPListed As Button
    Friend WithEvents btn_dgvViewKListed As Button
    Friend WithEvents WSCLHWPListBindingSource As BindingSource
    Friend WithEvents WSC_LHW_PListTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_LHW_PListTableAdapter
    Friend WithEvents WSCLHWPListIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LHWPUListIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WSCLHWIDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LHW_PList_HWN As DataGridViewComboBoxColumn
    Friend WithEvents LHW_PList_CAN As DataGridViewComboBoxColumn
    Friend WithEvents LHW_PList_Substance As DataGridViewComboBoxColumn
    Friend WithEvents Panel_CharacteristicWaste As Panel
    Friend WithEvents Panel_ChacteristicWaste_Toxic As Panel
    Friend WithEvents WSC_CHWBindingSource As BindingSource
    Friend WithEvents WSC_CHWTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_CHWTableAdapter
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents lbl_CHW_HeaderText As Label
    Friend WithEvents WSC_CHW_IDTextBox As TextBox
    Friend WithEvents WSC_CHW_IgnitableCheckBox As CheckBox
    Friend WithEvents WSC_CHW_Ignitable_NoteTextBox As TextBox
    Friend WithEvents WSC_CHW_CorrosiveCheckBox As CheckBox
    Friend WithEvents WSC_CHW_Corrosive_NoteTextBox As TextBox
    Friend WithEvents WSC_CHW_ReactiveCheckBox As CheckBox
    Friend WithEvents WSC_CHW_Reactive_NoteTextBox As TextBox
    Friend WithEvents WCS_CHW_ToxicCheckBox As CheckBox
    Friend WithEvents WCS_CHW_Toxic_NoteTextBox As TextBox
    Friend WithEvents WSC_IDTextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WSCCHWToxicConstituentBindingSource As BindingSource
    Friend WithEvents WSC_CHW_ToxicConstituentTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_CHW_ToxicConstituentTableAdapter
    Friend WithEvents TlkpCHWToxicConstituentBindingSource As BindingSource
    Friend WithEvents TlkpCHW_Toxic_ConstituentTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpCHW_Toxic_ConstituentTableAdapter
    Friend WithEvents WSCToxicConstiuentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WSCCHWIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToxicConstituentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToxicConstituent_HWN As DataGridViewComboBoxColumn
    Friend WithEvents ToxicConstituent_Contaminant As DataGridViewComboBoxColumn
    Friend WithEvents ToxicConstituentDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
