<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryForm
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
        MembershipIDTextBox = New TextBox()
        BookTypeComboBox = New ComboBox()
        BorrowButton = New Button()
        SuspendLayout()
        ' 
        ' MembershipIDTextBox
        ' 
        MembershipIDTextBox.Location = New Point(328, 53)
        MembershipIDTextBox.Name = "MembershipIDTextBox"
        MembershipIDTextBox.Size = New Size(214, 23)
        MembershipIDTextBox.TabIndex = 0
        ' 
        ' BookTypeComboBox
        ' 
        BookTypeComboBox.FormattingEnabled = True
        BookTypeComboBox.Location = New Point(328, 82)
        BookTypeComboBox.Name = "BookTypeComboBox"
        BookTypeComboBox.Size = New Size(214, 23)
        BookTypeComboBox.TabIndex = 1
        ' 
        ' BorrowButton
        ' 
        BorrowButton.Location = New Point(440, 217)
        BorrowButton.Name = "BorrowButton"
        BorrowButton.Size = New Size(102, 32)
        BorrowButton.TabIndex = 2
        BorrowButton.Text = "Borrow"
        BorrowButton.UseVisualStyleBackColor = True
        ' 
        ' LibraryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BorrowButton)
        Controls.Add(BookTypeComboBox)
        Controls.Add(MembershipIDTextBox)
        Name = "LibraryForm"
        Text = "Library Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MembershipIDTextBox As TextBox
    Friend WithEvents BookTypeComboBox As ComboBox
    Friend WithEvents BorrowButton As Button
End Class
