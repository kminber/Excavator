Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(1).Width = "130"
        Me.DataGridView1.Columns(2).Width = "130"
        Me.DataGridView1.Columns(3).Width = "130"
        Me.DataGridView1.Columns(1).HeaderText = "Type of file"
        Me.DataGridView1.Columns(2).HeaderText = "Total number of files"
        Me.DataGridView1.Columns(3).HeaderText = "Total file size"

        lb_totalFiles.Text = "Total files: " + Form1.valor_total.ToString()

        If Form1.error_file > 0 Then
            lb_errorFiles.Text = "The number of failed files: " + Form1.valor_error.ToString()
            lb_errorFiles.Visible = True
        End If

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DataGridView1.DataSource.clear()
    End Sub

End Class

