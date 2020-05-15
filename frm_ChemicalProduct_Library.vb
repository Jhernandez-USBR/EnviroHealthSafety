Public Class frm_ChemicalProduct_Library
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpOffice' table. You can move, or remove it, as needed.
        Me.TlkpOfficeTableAdapter.Fill(Me.EnviroHealthSafety.tlkpOffice)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.tlkpLibrary_DocumentType' table. You can move, or remove it, as needed.
        Me.TlkpLibrary_DocumentTypeTableAdapter.Fill(Me.EnviroHealthSafety.tlkpLibrary_DocumentType)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.Library' table. You can move, or remove it, as needed.
        Me.LibraryTableAdapter.Fill(Me.EnviroHealthSafety.Library)
        'TODO: This line of code loads data into the 'EnviroHealthSafety.Library' table. You can move, or remove it, as needed.
        Me.LibraryTableAdapter.Fill(Me.EnviroHealthSafety.Library)

    End Sub


End Class