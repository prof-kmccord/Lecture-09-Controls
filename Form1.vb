Public Class LibraryForm



    ' Declare the variables

    Private memberID As String

    Private bookType As String



    Private Sub LibraryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate the ComboBox with book types

        BookTypeComboBox.Items.Add("Fiction")

        BookTypeComboBox.Items.Add("Non-Fiction")

        BookTypeComboBox.Items.Add("Children")

        BookTypeComboBox.Items.Add("Magazine")

    End Sub



    Private Sub BorrowButton_Click(sender As Object, e As EventArgs)

        ' Get the membership ID and book type

        memberID = MembershipIDTextBox.Text

        bookType = BookTypeComboBox.SelectedItem.ToString()



        ' TODO: Display a MessageBox to confirm the borrowing

    End Sub



End Class
