<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SDSResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SDSResult))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_SDSResult = New System.Windows.Forms.DataGridView()
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.ChemicalProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafetyTableAdapters.Chemical_ProductTableAdapter()
        Me.EnviroHealthSafetyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgv_SDSResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafetyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(267, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_SDSResult
        '
        Me.dgv_SDSResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_SDSResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_SDSResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_SDSResult.Location = New System.Drawing.Point(22, 21)
        Me.dgv_SDSResult.Name = "dgv_SDSResult"
        Me.dgv_SDSResult.RowHeadersWidth = 51
        Me.dgv_SDSResult.RowTemplate.Height = 24
        Me.dgv_SDSResult.Size = New System.Drawing.Size(675, 446)
        Me.dgv_SDSResult.TabIndex = 2
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChemicalProductBindingSource
        '
        Me.ChemicalProductBindingSource.DataMember = "Chemical_Product"
        Me.ChemicalProductBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'EnviroHealthSafetyBindingSource
        '
        Me.EnviroHealthSafetyBindingSource.DataSource = Me.EnviroHealthSafety
        Me.EnviroHealthSafetyBindingSource.Position = 0
        '
        'frm_SDSResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 522)
        Me.Controls.Add(Me.dgv_SDSResult)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_SDSResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Safety Data Sheet Search Results"
        CType(Me.dgv_SDSResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafetyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv_SDSResult As DataGridView
    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents ChemicalProductBindingSource As BindingSource
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafetyTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents EnviroHealthSafetyBindingSource As BindingSource
End Class
