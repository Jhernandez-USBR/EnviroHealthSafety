<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ChemicalProduct_Location
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChemicalProduct_Location))
        Me.dgv_ProductPhysicalLocation = New System.Windows.Forms.DataGridView()
        Me.ProductLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductLocationActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductLocationApprovedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryChemicalProductCurrentLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.FillByFilterProductIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.IconToolStripButton1 = New FontAwesome.Sharp.IconToolStripButton()
        Me.IconToolStripButton2 = New FontAwesome.Sharp.IconToolStripButton()
        Me.Qry_ChemicalProduct_CurrentLocationTableAdapter = New EnviroHealthSafetyTableAdapters.qry_ChemicalProduct_CurrentLocationTableAdapter()
        CType(Me.dgv_ProductPhysicalLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryChemicalProductCurrentLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByFilterProductIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_ProductPhysicalLocation
        '
        Me.dgv_ProductPhysicalLocation.AllowUserToAddRows = False
        Me.dgv_ProductPhysicalLocation.AllowUserToDeleteRows = False
        Me.dgv_ProductPhysicalLocation.AllowUserToOrderColumns = True
        Me.dgv_ProductPhysicalLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ProductPhysicalLocation.AutoGenerateColumns = False
        Me.dgv_ProductPhysicalLocation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_ProductPhysicalLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ProductPhysicalLocation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductLocationIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.BuildingNameDataGridViewTextBoxColumn, Me.PhysicalLocationNameDataGridViewTextBoxColumn, Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn, Me.ProductLocationActiveDataGridViewCheckBoxColumn, Me.ProductLocationApprovedDataGridViewTextBoxColumn})
        Me.dgv_ProductPhysicalLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_ProductPhysicalLocation.DataSource = Me.QryChemicalProductCurrentLocationBindingSource
        Me.dgv_ProductPhysicalLocation.Location = New System.Drawing.Point(12, 76)
        Me.dgv_ProductPhysicalLocation.Name = "dgv_ProductPhysicalLocation"
        Me.dgv_ProductPhysicalLocation.ReadOnly = True
        Me.dgv_ProductPhysicalLocation.RowHeadersWidth = 51
        Me.dgv_ProductPhysicalLocation.RowTemplate.Height = 24
        Me.dgv_ProductPhysicalLocation.Size = New System.Drawing.Size(707, 365)
        Me.dgv_ProductPhysicalLocation.TabIndex = 2
        '
        'ProductLocationIDDataGridViewTextBoxColumn
        '
        Me.ProductLocationIDDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_ID"
        Me.ProductLocationIDDataGridViewTextBoxColumn.HeaderText = "ProductLocation_ID"
        Me.ProductLocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductLocationIDDataGridViewTextBoxColumn.Name = "ProductLocationIDDataGridViewTextBoxColumn"
        Me.ProductLocationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductLocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductIDDataGridViewTextBoxColumn.Width = 125
        '
        'BuildingNameDataGridViewTextBoxColumn
        '
        Me.BuildingNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BuildingNameDataGridViewTextBoxColumn.DataPropertyName = "Building_Name"
        Me.BuildingNameDataGridViewTextBoxColumn.HeaderText = "Building"
        Me.BuildingNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BuildingNameDataGridViewTextBoxColumn.Name = "BuildingNameDataGridViewTextBoxColumn"
        Me.BuildingNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhysicalLocationNameDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_Name"
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.Name = "PhysicalLocationNameDataGridViewTextBoxColumn"
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductLocationVerifiedDateDataGridViewTextBoxColumn
        '
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_VerifiedDate"
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.HeaderText = "Location Verified"
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.Name = "ProductLocationVerifiedDateDataGridViewTextBoxColumn"
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.Width = 187
        '
        'ProductLocationActiveDataGridViewCheckBoxColumn
        '
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.DataPropertyName = "ProductLocation_Active"
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.Name = "ProductLocationActiveDataGridViewCheckBoxColumn"
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.Width = 72
        '
        'ProductLocationApprovedDataGridViewTextBoxColumn
        '
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_Approved"
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.HeaderText = "Approved"
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.Name = "ProductLocationApprovedDataGridViewTextBoxColumn"
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.Width = 129
        '
        'QryChemicalProductCurrentLocationBindingSource
        '
        Me.QryChemicalProductCurrentLocationBindingSource.DataMember = "qry_ChemicalProduct_CurrentLocation"
        Me.QryChemicalProductCurrentLocationBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillByFilterProductIDToolStrip
        '
        Me.FillByFilterProductIDToolStrip.AutoSize = False
        Me.FillByFilterProductIDToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FillByFilterProductIDToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByFilterProductIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByFilterProductIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.IconToolStripButton1, Me.IconToolStripButton2})
        Me.FillByFilterProductIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByFilterProductIDToolStrip.Name = "FillByFilterProductIDToolStrip"
        Me.FillByFilterProductIDToolStrip.Size = New System.Drawing.Size(732, 40)
        Me.FillByFilterProductIDToolStrip.TabIndex = 3
        Me.FillByFilterProductIDToolStrip.Text = "FillByFilterProductIDToolStrip"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(277, 37)
        Me.ToolStripLabel1.Text = "Current Product Locations"
        '
        'IconToolStripButton1
        '
        Me.IconToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.IconToolStripButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IconToolStripButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconToolStripButton1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.IconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.IconToolStripButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconToolStripButton1.IconSize = 16
        Me.IconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IconToolStripButton1.Name = "IconToolStripButton1"
        Me.IconToolStripButton1.Rotation = 0R
        Me.IconToolStripButton1.Size = New System.Drawing.Size(29, 37)
        Me.IconToolStripButton1.Text = "Report"
        '
        'IconToolStripButton2
        '
        Me.IconToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.IconToolStripButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IconToolStripButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconToolStripButton2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconToolStripButton2.ForeColor = System.Drawing.Color.Black
        Me.IconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconToolStripButton2.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconToolStripButton2.IconSize = 16
        Me.IconToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IconToolStripButton2.Name = "IconToolStripButton2"
        Me.IconToolStripButton2.Rotation = 0R
        Me.IconToolStripButton2.Size = New System.Drawing.Size(29, 37)
        Me.IconToolStripButton2.Text = "Refresh"
        '
        'Qry_ChemicalProduct_CurrentLocationTableAdapter
        '
        Me.Qry_ChemicalProduct_CurrentLocationTableAdapter.ClearBeforeFill = True
        '
        'frm_ChemicalProduct_Location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(732, 453)
        Me.Controls.Add(Me.FillByFilterProductIDToolStrip)
        Me.Controls.Add(Me.dgv_ProductPhysicalLocation)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "frm_ChemicalProduct_Location"
        Me.Text = "Current Product Locations"
        CType(Me.dgv_ProductPhysicalLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryChemicalProductCurrentLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByFilterProductIDToolStrip.ResumeLayout(False)
        Me.FillByFilterProductIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_ProductPhysicalLocation As DataGridView
    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents QryChemicalProductCurrentLocationBindingSource As BindingSource
    Friend WithEvents Qry_ChemicalProduct_CurrentLocationTableAdapter As EnviroHealthSafetyTableAdapters.qry_ChemicalProduct_CurrentLocationTableAdapter
    Friend WithEvents ProductLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuildingNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductLocationVerifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductLocationActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProductLocationApprovedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByFilterProductIDToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents IconToolStripButton1 As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents IconToolStripButton2 As FontAwesome.Sharp.IconToolStripButton
End Class
