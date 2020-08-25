Public Class Form1
    Dim path As String
    Dim dt_Files As New DataTable("Files")
    Public total_files As Integer = 0
    Public error_file As Integer = 0

#Region "Properties"
    Public Property valor_total() As Integer
        Get
            valor_total = total_files
        End Get
        Set(ByVal Value As Integer)
            total_files = Value
        End Set
    End Property
    Public Property valor_error() As Integer
        Get
            valor_error = error_file
        End Get
        Set(ByVal Value As Integer)
            error_file = Value
        End Set
    End Property
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        path = String.Empty
        tx_path.Text = String.Empty

        'To creatre rows of table
        Dim dc_id As New DataColumn("ID")
        dt_Files.Columns.Add(dc_id)
        Dim dc_type_file As New DataColumn("TYPE")
        dt_Files.Columns.Add(dc_type_file)
        Dim dc_total As New DataColumn("NUMBER")
        dt_Files.Columns.Add(dc_total)
        Dim dc_size As New DataColumn("SIZE")
        dt_Files.Columns.Add(dc_size)

    End Sub

    Private Sub btn_selectFolder_Click(sender As Object, e As EventArgs) Handles btn_selectFolder.Click
        'To choose path
        Dim selection As New FolderBrowserDialog
        path = String.Empty

        If selection.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = selection.SelectedPath
            btn_dig.Enabled = True
            tx_path.Text = path
        End If
    End Sub

    Private Sub btn_dig_Click(sender As Object, e As EventArgs) Handles btn_dig.Click
        Me.Cursor = Cursors.WaitCursor
        total_files = 0
        error_file = 0
        traverse(path)
        bytes(dt_Files)
        Form2.DataGridView1.DataSource = dt_Files
        Form2.ShowDialog()
        Me.Cursor = DefaultCursor
    End Sub

    Private Sub traverse(ruta As String)
        'Dig on path choosed
        Dim nf As Integer = My.Computer.FileSystem.GetFiles(ruta).Count

        If My.Computer.FileSystem.GetFiles(ruta).Count > 0 Then
            'Get files of first directory
            get_files(ruta)
        End If

        For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(ruta)
            get_files(foundDirectory)
            If My.Computer.FileSystem.GetDirectories(foundDirectory).Count > 0 Then
                'If there are directories, it looks for on directories too
                traverse(foundDirectory)
            End If
        Next
    End Sub

    Private Sub get_files(ruta As String)
        'Get files of path
        Dim nameFile As String() = Nothing

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(ruta)

            Dim dv_Files As DataView = New DataView(dt_Files)

            Dim information = My.Computer.FileSystem.GetFileInfo(foundFile)
            Dim type_file As String = information.Extension

            dv_Files.RowFilter = "TYPE = '" & type_file & "'"

            If dv_Files.Count > 0 Then
                'If type of file is on table, row is update 
                dt_Files.Rows(dv_Files.Item(0).Item("ID") - 1)(2) = CInt(dt_Files.Rows(dv_Files.Item(0).Item("ID") - 1)(2)) + 1
                Try
                    dt_Files.Rows(dv_Files.Item(0).Item("ID") - 1)(3) = CInt(dt_Files.Rows(dv_Files.Item(0).Item("ID") - 1)(3)) + information.Length
                Catch ex As Exception
                    'Path is too long
                    error_file = error_file + 1
                End Try

            Else
                'To create row with dates
                Dim row As DataRow = dt_Files.NewRow()
                row("ID") = dt_Files.Rows.Count + 1
                row("TYPE") = type_file
                row("NUMBER") = 1
                row("SIZE") = information.Length
                dt_Files.Rows.Add(row)
            End If
            total_files = total_files + 1
        Next

    End Sub

    Private Sub bytes(table As DataTable)
        'Show size of type of file in B, KB, MB or GB
        For i As Integer = 0 To table.Rows.Count - 1 Step 1
            Dim size As Double = CDbl(table.Rows(i)(3))

            If size > 1024 * 1024 * 1024 Then
                table.Rows(i)(3) = Math.Round((size / (1024 * 1024 * 1024)), 2).ToString() + " GB"
                Continue For
            End If
            If size > 1024 * 1024 Then
                table.Rows(i)(3) = Math.Round((size / (1024 * 1024)), 2).ToString() + " MB"
                Continue For
            End If
            If size > 1024 Then
                table.Rows(i)(3) = Math.Round((size / 1024), 2).ToString() + " KB"
                Continue For
            Else
                table.Rows(i)(3) = (size).ToString() + " B"
                Continue For
            End If

        Next

    End Sub

End Class

